using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double ml = double.Parse(Console.ReadLine());
            int kcal = int.Parse(Console.ReadLine());
            int g = int.Parse(Console.ReadLine());

            Console.WriteLine($"{ml}ml {product}:");

            double allkcal = (ml / 100) * kcal;
            double sugar = (ml / 100) * g;
            Console.WriteLine($"{allkcal}kcal, {sugar}g sugars");

        }
    }
}
