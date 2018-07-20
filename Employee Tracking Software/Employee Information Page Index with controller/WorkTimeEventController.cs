using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using ScheduleUsers.Areas.Employer.ViewModels;
using ScheduleUsers.Models;
using ScheduleUsers.ViewModels;

namespace ScheduleUsers.Controllers
{
    [Authorize]
    public class WorkTimeEventController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        
        // GET: WorkTimeEvent
        //[Authorize(Roles = "Admin")]
      [HttpPost]
        public ActionResult Index(EventListVm EVMView, string DateFilterSort, string HoursSorter)
        {
            //Sets the time of end date at 11:59:59 PM in order to account for events taking place on that day
            EVMView.DisplayEndDate = EVMView.DisplayEndDate.Value.AddDays(1).AddSeconds(-1);
            // Grabs the current user ID
            var userId = User.Identity.GetUserId();
            // Grabs all events in Db that have the same user ID as the one logging in
            ApplicationUser user = db.Users.Find(userId);
            //Checking for clocked in status
            bool ClockedInStatus = db.WorkTimeEvents.Any(x => x.Id == userId && !x.End.HasValue);
            //Begin query for selected dates on index page. 
            //This IF statement accounts for the user putting in a start date that is after the end date. This switches their values. 
            if (EVMView.DisplayBeginDate > EVMView.DisplayEndDate)
            {
                var temp = EVMView.DisplayBeginDate;
                EVMView.DisplayBeginDate = EVMView.DisplayEndDate.Value;
                EVMView.DisplayEndDate = temp;
            }            
            //This variable is taking in selected dates from the user and and ensuring that the dates are filtered correctly.
            var Dates = db.WorkTimeEvents.Where(w => w.User.Id == userId).Where(w =>
                                                              w.End <= EVMView.DisplayEndDate &&
                                                              w.End >= EVMView.DisplayBeginDate ||
                                                              w.Start <= EVMView.DisplayEndDate &&
                                                              w.Start >= EVMView.DisplayBeginDate ||
                                                              w.Start <= EVMView.DisplayBeginDate &&
                                                              w.End >= EVMView.DisplayEndDate
                                                              ).OrderBy(w => w.Start);
            EventListVm EVM = new EventListVm(workTime: Dates.ToList(), user: user, ClockedIn: ClockedInStatus, Start: EVMView.DisplayBeginDate, End: EVMView.DisplayEndDate);
            //Switch statement for sorting header columns by date
            if (DateFilterSort != "update")
            {
                    //Sorting method by EventTotalHours(Total hours worked) of shifts
                    if (HoursSorter != null)
                    {
                        HoursSorter = HoursSorter != "HoursSort" ? "HoursSort" : "HoursSortDec";
                        switch(HoursSorter)
                        {
                            case "HoursSort":
                                EVM.EventVms = EVM.EventVms.OrderBy(w => w.EventHoursWorked).ToList();
                                break;
                            case "HoursSortDec":
                                EVM.EventVms = EVM.EventVms.OrderByDescending(w => w.EventHoursWorked).ToList();
                                break;
                        }
                        ViewBag.HoursSortParm = HoursSorter;
                    }
                    else if(DateFilterSort != null)
                    {
                        //Sorting method by Start/End dates of shifts
                        DateFilterSort = DateFilterSort != "date_desc" ? "date_desc" : "Date";
                        switch (DateFilterSort)
                        {

                            case "Date":
                                EVM.EventVms = EVM.EventVms.OrderBy(d => d.EventTimeIn).ToList();
                                break;
                            case "date_desc":
                                EVM.EventVms = EVM.EventVms.OrderByDescending(d => d.EventTimeIn).ToList();
                                break;

                        }
                        ViewBag.DateSortParm = DateFilterSort;                       
                    }

            }
            return View("Index", EVM);
        }

        // GET: WorkTimeEvent
        //[Authorize(Roles = "Admin")]
        public ActionResult Index()
        {

            // Grabs the current user ID
            var userId = User.Identity.GetUserId();
            ApplicationUser user = db.Users.Find(userId);
            bool ClockedInStatus = db.WorkTimeEvents.Any(x => x.Id == userId && !x.End.HasValue);
            //Sorting the order to pre-populate the table with dates in ascending oerder
            DateTime DisplayBeginDate = DateTime.Now.AddDays(-14);
            DateTime DisplayEndDate = DateTime.Today.AddDays(1).AddSeconds(-1);
            //This variable is taking in selected dates from the user and and ensuring that the dates are filtered correctly and sorted.
            var Sorting = db.WorkTimeEvents.Where(w => w.User.Id == userId).Where(w =>
                                                              w.End <=  DisplayEndDate &&
                                                              w.End >=  DisplayBeginDate ||
                                                              w.Start <=DisplayEndDate &&
                                                              w.Start >=DisplayBeginDate ||
                                                              w.Start <=DisplayBeginDate &&
                                                              w.End >=  DisplayEndDate
                                                              ).OrderBy(w => w.Start);
            EventListVm EVM = new EventListVm(workTime: Sorting.ToList(), user: user, ClockedIn: ClockedInStatus);
            return View(EVM);
        }

        
    }
}