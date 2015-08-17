using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MEPSNET.Repositories.Entities
{
    public class HardwareType
    {
        [Key]
        public int HardwareTypeId { get; set; }

        public string IpComPort { get; set; }
        public int NumPorts { get; set; }
        public string SubAntennas { get; set; }
        public string PhysicalAntenna { get; set; }
        public string  SubAntennaSeq { get; set; }
        public string AntennaSwitchPort { get; set; }
        public string RevAntenna { get; set; }
        public string BeamSweeperAntennas { get; set; }
        public int IOpin { get; set; }
        public int DoorOpenTime { get; set; }
        public bool Multiplexer { get; set; }
        public int NoOfScanner { get; set; }
        public int ScanTime { get; set; }
        public int SliceTime { get; set; }
        public int DelayTime { get; set; }
        public bool AntennaRotation { get; set; }

        [Required]
        public bool EnableBeamSweeper { get; set; }
        public int BeamSweeperTimeSlice { get; set; }




    }
}