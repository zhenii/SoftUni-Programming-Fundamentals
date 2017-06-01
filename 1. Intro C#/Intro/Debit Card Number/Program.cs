using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumb = int.Parse(Console.ReadLine());
            int secondNumb = int.Parse(Console.ReadLine());
            int thirdNumb = int.Parse(Console.ReadLine());
            int fourthNumb = int.Parse(Console.ReadLine());


            Console.WriteLine($"{firstNumb:D4} {secondNumb:D4} {thirdNumb:D4} {fourthNumb:D4}");
        }
    }
}
