using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11_TimePerson.Models
{
    /// <summary>
    /// TimePerson class containing contructor and connection to CSV data file, read of data and query 
    /// </summary>
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

        /// <summary>
        /// Constructor for data from CSV file
        /// </summary>
        /// <param name="year">integer year</param>
        /// <param name="honor">string honor</param>
        /// <param name="name">string name</param>
        /// <param name="country">string country</param>
        /// <param name="birthYear">int birthyear</param>
        /// <param name="deathYear">int deathyear</param>
        /// <param name="title">string title</param>
        /// <param name="category">string category</param>
        /// <param name="context">string context</param>
        public TimePerson(int year, string honor, string name, string country, int birthYear, int deathYear, string title, string category, string context)
        {
            Year = year;
            Honor = honor;
            Name = name;
            Country = country;
            BirthYear = birthYear;
            DeathYear = deathYear;
            Title = title;
            Category = category;
            Context = context;

        }

        /// <summary>
        /// Instantiation of TimePerson, getting the timeperson.csv file, receiving all data as a string type, converting int types back to int, then running query
        /// </summary>
        /// <param name="beginningYear">int beginningYear as inputted by end user</param>
        /// <param name="endYear">int endYear as inputted by end user</param>
        /// <returns></returns>
        public static List<TimePerson> GetPerson(int beginningYear, int endYear)
        {
            //instantiate a new list of Time persons
            List<TimePerson> timePeople = new List<TimePerson>();

            //get the path of your timeperson.csv file - google how to get the root file path for an mvc web application
            var path = Environment.CurrentDirectory;
            var newPath = Path.GetFullPath(Path.Combine(path, @"wwwroot/personOfTheYear.csv"));
            //Console.WriteLine(timeData);
            string[] timeData = File.ReadAllLines(newPath);

            //once you get the file path, read all the lines and save it into an array of strings
            //(new string[] { "Year", "Honor", "Name", "Country", "BirthYear", "DeathYear", "Title", "Category", "Context" });

            for (var i = 1; i < timeData.Length; i++)
            {
                string[] timeDataSplit = timeData[i].Split(',');

                //travserse through the strings for each line item
                //remember CSV is delimited by commas.
                TimePerson timePerson = new TimePerson
                (
                    timeDataSplit[0] == "" ? 0 : Convert.ToInt32(timeDataSplit[0]), //ternary to convert value to int and return 0 if empty
                    timeDataSplit[1],
                    timeDataSplit[2],
                    timeDataSplit[3],
                    timeDataSplit[4] == "" ? 0 : Convert.ToInt32(timeDataSplit[4]), //ternary to convert value to int and return 0 if empty
                    timeDataSplit[5] == "" ? 0 : Convert.ToInt32(timeDataSplit[5]), //ternary to convert value to int and return 0 if empty
                    timeDataSplit[6],
                    timeDataSplit[7],
                    timeDataSplit[8]
                );

                timePeople.Add(timePerson);

            }

            //use LINQ to filter out with the years you brought in against your list of persons

            List<TimePerson> query = timePeople.Where(x => x.Year >= beginningYear && x.Year <= endYear).ToList();
            return query;


        }
    }
}
