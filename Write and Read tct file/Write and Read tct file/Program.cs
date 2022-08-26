using System;
using Write_and_Read_tct_file.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;


namespace Write_and_Read_tct_file
{
    internal class Program
    {
        static void Main(string[] args)
            {
                /*string file = @"C:\Users\1058693\Documents\App Dev\ReadWrite.txt";

                WriteWitheStream(file);

                StreamRead(file);*/

            PersonModel person1 = new PersonModel();
            person1.FirstName = "Nicki";
            person1.LastName = "Malilay";
            person1.Age = 17;
            person1.Gender = PersonModel.gender.Male;

            PersonModel person2 = new PersonModel
            { 
                FirstName = "Dwayne",
                LastName = "TheRockJohnson",
                Age=50,
                Gender = PersonModel.gender.Male,
            };

            PersonModel person3 = UserInterface.AddPerson();

            List<PersonModel> people = UserInterface.BuildPersonList();

            Console.WriteLine(person1);
            Console.WriteLine("\n" + person2);
            Console.WriteLine("\n" + person3);

            foreach(PersonModel p in people)
            {
                Console.WriteLine(p);  
            }
                
            Console.ReadLine();
                
            }

            static void WriteWitheStream(string file)
            {
                using (StreamWriter sw = new StreamWriter(file))
                {                    
                        sw.WriteLine("Sujit is short");
                        sw.WriteLine("I love coding");
                    }

                }
            }

    static void StreamRead(string file)
            {
                using (StreamReader stream = new StreamReader(file))
                {
                    string line;
                    while ((line = stream.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }

                }
            }
        }


