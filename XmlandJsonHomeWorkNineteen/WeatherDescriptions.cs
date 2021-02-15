using System;
using System.Collections.Generic;
using System.Text;

namespace XmlandJsonHomeWorkNineteen
{
    public class WeatherDescriptions
    {
        public List<string> PartlyCloudy;
        public int WindSpeed { get; set; }
        public int WindDegree { get; set; }
        public string WindDir { get; set; }
        public int Pressure { get; set; }
        public int Precip { get; set; }
        public int Humidity { get; set; }
        public int Cloudcover { get; set; }
        public string Feelslike { get; set; }
        public int UvIndex { get; set; }
        public int Visibility { get; set; }
        public string IsDay { get; set; }
    }
}
