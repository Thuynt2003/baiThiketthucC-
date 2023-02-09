using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample
{
    public class Cylinder
    {
        public double BaseArea;
        public double LateralArea;
        public double TotalArea;
        public double Volume;
        public double Radius;
        public double Height;
        public Cylinder()
        {

        }

        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public void Process()
        {
            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;

        }
        public void Result()
        {
            Console.WriteLine("Base :" + BaseArea);
            Console.WriteLine("Lateral :" + LateralArea);
            Console.WriteLine("Total :" + TotalArea);
            Console.WriteLine("Volume :" + Volume);
        }
    }
}
