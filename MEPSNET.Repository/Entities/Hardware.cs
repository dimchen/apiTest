using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MEPSNET.Repositories.Entities
{
    public class Hardware
    {
        [Key]
        public int HardwareId { get; set; }

        [Required]
        public string HardwareSerial { get; set; }
        public DateTime InstallationDate { get; set; }
        public int StationId { get; set; }
        public string Status { get; set; }

        [Required]
        public virtual HardwareType HardwareType { get; set; }
    }
}