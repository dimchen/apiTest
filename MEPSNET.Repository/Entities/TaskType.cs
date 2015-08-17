using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MEPSNET.Repositories.Entities
{
    public class TaskType
    {
        [Key]
        public int TaskTypeId { get; set; }
        public string TaskTypeName { get; set; }
        public string TaskTypeDescription { get; set; }
    }
}