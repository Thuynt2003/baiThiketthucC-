using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample
{
    public class Lion : Base
    {
        public Lion() { }
        public Lion(int weight, string name):base(weight, name) { }
        public override void Show()
        {
            Console.WriteLine("Name: " + name + "," + "Weight: " + weight);
        }
        public override void SetMe(int weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }

    }

}
