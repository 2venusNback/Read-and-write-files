using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write_and_Read_tct_file.Models
{
    internal class PersonModel
    {
        public enum gender { Male, Female, NonBinary, Other}//starts counting a 0
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public gender Gender { get; set; }

        public override string ToString()
        {
            return $"Person: {FirstName} {LastName}\nAge: {Age}\nGender: {Gender}";
        }
    }
}
