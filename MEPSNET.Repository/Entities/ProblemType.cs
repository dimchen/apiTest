using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MEPSNET.Repositories.Entities
{
    public class ProblemType
    {
        [Key]
        public int ProblemTypeId { get; set; }
        public string ProblemTypeName { get; set; }
        public string ProblemTypeDescription { get; set; }
    }
}