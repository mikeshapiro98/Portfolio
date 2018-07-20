using ScheduleUsers.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ScheduleUsers.ViewModels
{

    //Instantiating EventList View Model
    public class EventListVm

    {
        /// <summary>
        /// The Id of the current user
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// User Clock in date and time for display
        /// </summary>
        [DisplayName("Shift Begin Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DisplayBeginDate { get; set; }

        /// <summary>
        /// User Clock Out date and timer for display
        /// </summary>
        [DisplayName("Shift End Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DisplayEndDate { get; set; }

        /// <summary>
        /// List of Pay periods for display
        /// </summary>
        //public List<PayPeriod> PayPeriods { get; set; }

        /// <summary>
        /// List of properties from EventVm to populate object
        /// </summary>
        public List<EventVm> EventVms { get; set; }

        /// <summary>
        /// Status of whether or not the user is clocked in
        /// </summary>
        [DisplayName("Current Working Status")]
        public bool ClockedIn { get; set; }

        /// <summary>
        /// Total hours worked by a user over a given timespan
        /// </summary>
        [DisplayName("Total Hours")]
        public TimeSpan EventsTotalHours { get; set; }

        /// <summary>
        /// Expected gross wages for a user
        /// </summary>
        [DisplayName("Gross Projected Pay")]
        public decimal GrossExpectedPay { get; set; }



        public EventListVm(List<WorkTimeEvent> workTime, ApplicationUser user)
            : this(workTime, user, DateTime.Now.AddDays(-14), DateTime.Today.AddDays(1).AddSeconds(-1), false)
        {
        }

        public EventListVm(List<WorkTimeEvent> workTime, ApplicationUser user, bool ClockedIn)
            : this(workTime, user, DateTime.Now.AddDays(-14), DateTime.Today.AddDays(1).AddSeconds(-1), ClockedIn)
        {

        }
        public EventListVm()
        {

        }
        public EventListVm(List<WorkTimeEvent> workTime, ApplicationUser user, DateTime Start, DateTime? End, bool ClockedIn)
        {
            this.UserId = user.Id;
            this.DisplayBeginDate = Start;
            this.DisplayEndDate = End;
            this.EventVms = new List<EventVm>();
            this.ClockedIn = ClockedIn;


            for (var i = 0; i < workTime.Count; i++)
            {
                EventVm EVM = new EventVm(workTime[i]);
                EventsTotalHours += EVM.EventHoursWorked;
                EventVms.Add(EVM);
            }
            GrossExpectedPay = Convert.ToDecimal(EventsTotalHours.TotalMinutes / 60) * user.HourlyPayRate;

        }
    }
    //Instansiation of Event View Model for passing to EventList View Model
    public class EventVm
    {
        /// <summary>
        /// Event Clock in date and time for user.
        /// </summary>
        [DisplayName("Shift Begin Date")]
        public DateTime EventTimeIn{ get; set; }

        /// <summary>
        /// Event Clock out data and time for user.
        /// </summary>
        [DisplayName("Shift End Date")]
        public DateTime? EventTimeOut { get; set; }

        /// <summary>
        /// Event Notes associated with current user
        /// </summary>
        [DisplayName("Shift Notes")]
        public string EventNote { get; set; }

        /// <summary>
        /// Event Type of work for user. 
        /// </summary>
        //public string EventWorkType { get; set; }

        /// <summary>
        /// Event Amount of hours the user worked
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:%d}" + "d " + "{0:%h}" + "h " + "{0:%m}" + "m", ApplyFormatInEditMode = true)]
        [DisplayName("Total Shift Length")]
        public TimeSpan EventHoursWorked{ get; set; }

        /// <summary>
        /// Event Id for individualization 
        /// </summary>
        public string Id { get; set; }

        public EventVm(/*EventListVm EVM*/) { }
        public EventVm(WorkTimeEvent WTE)
        {            
            this.Id = WTE.Id;
            this.EventTimeIn = WTE.Start;
            this.EventTimeOut = WTE.End;
            this.EventNote = WTE.Note;
            if(EventTimeOut != null)
            {
                this.EventHoursWorked = EventTimeOut.Value - EventTimeIn;
            }
          
        }

    }

  
}