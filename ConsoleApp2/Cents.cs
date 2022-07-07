using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Cents
    {
        readonly int dozens;
        readonly int units;

        public Cents(int dozens, int units)
        {
            this.dozens = dozens;
            this.units = units;
        }

        public string Value => $"{Dozens}" + $"{Units}";

        public int Dozens => dozens;

        public int Units => units;
    }
}
