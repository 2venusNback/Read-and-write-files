using Write_and_Read_tct_file.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static Write_and_Read_tct_file.Models.PersonModel;

namespace Write_and_Read_tct_file.Models
{
    internal class UserInterface
    {
        public static List<PersonModel> BuildPersonList()
        {
            List<PersonModel> people = new List<PersonModel>();
            bool addPerson = true;

            while (addPerson)
            {
                //System.Console.WriteLine(   );
                Console.WriteLine("Please answer the following questions:");
                people.Add(AddPerson());

                bool correctFormat = false;
                while (!correctFormat)
                {
                    Console.WriteLine("Add another person (true or false ONLY");
                    correctFormat = Boolean.TryParse(Console.ReadLine(), out addPerson);
                }  
            }


            return people;
        }

        public static PersonModel AddPerson()
        {
            PersonModel person = new PersonModel();

            person.FirstName = GetString("Please enter first name: ");
            person.LastName = GetString("Please enter last name");
            person.Age = GetInt("Please enter age: ");
            int findGender = GetInt("Please select gender (1=Male, 2=Female, 3=NonBinary, 4=Other)") - 1;
            person.Gender = (gender)findGender;

            return person;
        }




        private static string GetString(string msg)
        {
            Console.WriteLine(msg);
            string output = Console.ReadLine();
            return output;
        }

        private static int GetInt(string msg)
        {
            int output = Int32.MinValue;
            bool validInt = false;

            while (!validInt)
            {
                Console.Write(msg);
                validInt = Int32.TryParse(Console.ReadLine(), out output);

            }
            return output;
        }
    }
}
