using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evidenta.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string TeacherName { get; set; }
        public string Subject { get; set; }
    }
}
