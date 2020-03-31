using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11_TimePerson.Models
{
    public class TimePerson
    {
        //put all {get; set;} from lab here
        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Context { get; set; }


        public static List<TimePerson> GetPerson(int beginningYear, int endYear)
        {
            //instantiate a new list of Time persons
            //get the path of your timeperson.csv file - google how to get the root file path for an mvc web application
            //once you get the file path, read all the lines and save it into an array of strings
            //travserse through the strings for each line item
            //remember CSV is delimited by commas.

            //use LINQ to filter out with the years you brought in against your list of persons
            return null; 
        }
    
    }
}
