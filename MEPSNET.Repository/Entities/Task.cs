using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MEPSNET.Repositories.Entities
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }

        public DateTime ProblemTime { get; set; }
        public string Status { get; set; }
        public string TaskDescription { get; set; }

        public TaskType TaskType { get; set; }
        public InternalUser User { get; set; }
    }
}