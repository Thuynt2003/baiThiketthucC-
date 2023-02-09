using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GeometryExample
{
    public abstract class Base
    {
        public int weight;
        public string name;

        public Base() { }
        public Base(int weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }
        public abstract void Show();
        public abstract void SetMe(int weight, string name);
    }
}
