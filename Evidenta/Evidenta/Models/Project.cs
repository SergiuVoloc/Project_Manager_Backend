using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evidenta.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Project_Adress { get; set; }
        public DateTime Uploaded_Date { get; set; }
        public int  StudentId { get; set; }
        public int TeacherId { get; set; }
    }
}
