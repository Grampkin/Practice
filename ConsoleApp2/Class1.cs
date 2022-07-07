using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Burger
    {
        readonly decimal singlePrice = 5.50m;
        readonly decimal quantuty;

        public Burger(decimal quantuty)
        {
            this.quantuty = quantuty;
        }
        public decimal TotalPrice => quantuty * singlePrice;
    }
    internal class Shake
    {
        readonly decimal singlePrice = 2.86m;
        readonly decimal quantuty;

        public Shake(decimal quantuty)
        {
            this.quantuty = quantuty;
        }
        public decimal TotalPrice => quantuty * singlePrice;
    }

    public static class Order
    {
        static Burger burgers = new(4000000000000000);
        static Shake shakes = new(2);
        const decimal tax = 0.0765m;

        public static void ShowOrderInfo()
        {
             Console.WriteLine($"Total price before tax: {Math.Round(TotalPriceBeforeTax,2)}$;\n" +
                 $"Total tax price: {Math.Round(TaxValue,2)}$;\n" +
                 $"Total price after tax: {Math.Round(TotalPriceAfterTax,2)}$;\n" +
                 $"Have a nice day!");
        }
        static decimal TotalPriceBeforeTax => burgers.TotalPrice + shakes.TotalPrice;
        static decimal TaxValue  => (burgers.TotalPrice + shakes.TotalPrice) * tax;
        static decimal TotalPriceAfterTax => TotalPriceBeforeTax + TaxValue;

    }
}
