﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N:");
            var n = int.Parse(Console.ReadLine());
            for (int y = 0; y < n; y++)
            {
                for (int xS = n-y; xS >1; xS--)
                {
                    Console.Write(' ');
                }
                for (int x = 2*y+1; x > 0; x--)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
