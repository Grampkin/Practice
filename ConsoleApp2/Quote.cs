using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Quote
    {
        readonly decimal dollars;
        readonly Cents cents = new (0,0);

        public Quote(decimal dollars, Cents cents)
        {
            this.dollars = dollars;
            this.cents = cents;
        }

        public string Value => $"{dollars}" + $".{cents.Value}";

        public Quote Add(Quote quoteToAdd)
        {
            var dollarsFromCents = 0m;
            var numericCentsSum = decimal.Parse(quoteToAdd.cents.Value) + decimal.Parse(cents.Value);
            var newCents = new Cents(Convert.ToInt32(Math.Floor(numericCentsSum/10)), Convert.ToInt32(numericCentsSum - Math.Floor(numericCentsSum/10)*10));
            if(newCents.Dozens >= 10)
            {
                dollarsFromCents = Math.Floor(newCents.Dozens/10m);
                newCents = new(Convert.ToInt32(newCents.Dozens - Math.Floor(newCents.Dozens / 10m) * 10), newCents.Units);
            }
            var newDollars = dollars + quoteToAdd.dollars;
            return new Quote(newDollars + dollarsFromCents, newCents);
         
        }
    }
}
