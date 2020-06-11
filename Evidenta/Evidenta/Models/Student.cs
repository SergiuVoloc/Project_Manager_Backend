using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evidenta.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string StudentName { get; set; }
        public string Group { get; set; }
        public string Field { get; set; }
        public int Year { get; set; }
    }
}
