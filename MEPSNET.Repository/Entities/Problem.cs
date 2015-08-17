using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MEPSNET.Repositories.Entities
{
    public class Problem
    {
        [Key]
        public int ProblemId { get; set; }

        
        public DateTime ProblemDate { get; set; }
        public string Status { get; set; }
        public bool Priority { get; set; }
        public string Note { get; set; }

        public Hardware Hardware { get; set; }
        public ProblemType ProblemType { get; set; }
        public virtual List<Task> Tasks { get; set; }
    }
}