using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evidenta.Models
{
    public class Project_review
    {
        public int Project_reviewId { get; set; }
        public int Grade { get; set; }
        public string Comment { get; set; }
        public int ProjectId { get; set; }
    }
}
