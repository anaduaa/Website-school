using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication15.Models
{
    public class Student
    {
        public int Studentid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        
        public Teacher teacher { get; set; }
    }
}
