﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KenihAN.Sprint0.Task5.V0.Lib;

namespace Tyuiu.KenihAN.Sprint0.Task5.V0
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));
            Console.WriteLine("A - B = " + DataService.Addition(15, 5));
            Console.WriteLine("A * B = " + DataService.Addition(10, 10));
            Console.WriteLine("A / B = " + DataService.Addition(9, 3));
            Console.ReadKey();
        }
    }
}