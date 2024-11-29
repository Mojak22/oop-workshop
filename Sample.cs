using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Data
{

    public class Sample
    {
        private string filename;

        public void ReadSensorValues(string filename)
        {
            this.filename = filename;
            
            // read sensor values from file
            List<string> values = File.ReadAllLines(filename).ToList();
            
            foreach (string value in values)
            {
                Console.WriteLine(value);
            }
        }

        static void Main(string[] args)
        {
            Sample sample = new Sample();
            string filename =
                "/Users/morten/Desktop/SDU/Software_teknologi/1._semester/OOP/oop-workshop/oop-workshop/data/room1_temp_sensor.txt";
            
            sample.ReadSensorValues(filename);
        }
    }
}