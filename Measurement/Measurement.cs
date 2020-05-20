using System;
using System.Collections.Generic;
using System.Text;

namespace Measurement
{
    public class Measurement
    {
        
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public double Pressure { get; set; }
        
       

        public Measurement(int temperature, int humidity, double pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
           
            
        }

        public override string ToString()
        {
            
            return Temperature + " " + Humidity + " " + Pressure ;
        }
    }
}
