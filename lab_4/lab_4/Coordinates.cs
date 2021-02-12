using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4_structs
{ 
    public class Coordinates
    {
        public double x { get; set; }
        public double y { get; set; }
        public Coordinates(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Coordinates(Tuple<double, double> coords)
        {
            this.x = coords.Item1;
            this.y = coords.Item2;
        }
    }
}
