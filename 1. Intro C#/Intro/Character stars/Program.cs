﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_stars
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currestEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |{0}{1}|",new string('|',currentHealth), new string('.',maximumHealth-currentHealth));
            Console.WriteLine("Energy: |{0}{1}|",new string ('|',currestEnergy),new string('.',maximumEnergy-currestEnergy));


        }
    }
}
