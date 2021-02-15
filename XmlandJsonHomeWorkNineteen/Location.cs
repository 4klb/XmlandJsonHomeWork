using System;
using System.Collections.Generic;
using System.Text;

namespace XmlandJsonHomeWorkNineteen
{
    public class Location
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string Lat { get; set; }
        public string Lon { get; set; }
        public string TimezoneId { get; set; }
        public double Localtime { get; set; }
        public double LocaltimeEpoch { get; set; }
        public double UtcOffset { get; set; }
    }
}
