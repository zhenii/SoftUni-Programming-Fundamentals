﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milimeters_to_kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double mile = double.Parse(Console.ReadLine());

            double kilometers = mile * 1.60934;

            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
