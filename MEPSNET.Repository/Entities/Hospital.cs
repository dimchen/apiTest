using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MEPSNET.Repositories.Entities
{
    public class Hospital
    {
        [Key]
        public int HospId { get; set; }
        [Required]
        public string HospName { get; set; }

        public string CustomerNo { get; set; }
        public string DEA { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationId { get; set; }
        public string AccountType { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int ZipCode { get; set; }
        public DateTime LiveDate { get; set; }
        public string Note { get; set; }
        public string Note3 { get; set; }

        public string PharmacyContact { get; set; }
        public string ItConctact { get; set; }
        public string Installer { get; set; }

        public virtual List<Hardware> Hardwares { get; set; }
        public virtual List<Problem> Problems { get; set; }
        
    }

    

    public class HosptialGroup
    {
        [Key]
        public int HospitalGroupId { get; set; }
        [Required]
        public string HospitalGroupName { get; set; }
        public int HospitalGroupNo { get; set; }

        public virtual List<Hospital> Hospitals { get; set; }
    }

    public class PharmaGroup
    {
        [Key]
        public int PharmaGroupId { get; set; }
        public string PharmaGorupName { get; set; }

        public virtual List<HosptialGroup> HospitalGroups { get; set; }
    }
}