using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_23_Extras
{
    public class Superhero
    {


        public string name { get; set; }
        public string city { get; set; }
        public string superpower { get; set; }




        public Superhero(string Name, string Superpower) : this(Name, "Metropolis", Superpower)
        {
        }
        public Superhero(string City) : this("Batman", City, "Tons of Money")
        { 
        }
        public Superhero() : this("Spiderman", "New York City", "Spidey Senses") 
        {
           
        }
        public Superhero(string Name, string City, string Superpower )
        {

            name = Name;
            city = City;
            superpower = Superpower;

            

        }

     
        


    }
}
