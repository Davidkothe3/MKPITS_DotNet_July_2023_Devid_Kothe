﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_no_10_to_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;

            while (num > 0)
            {
                Console.WriteLine(num);
                num--;
            }
            Console.ReadKey();
        }
    }
}
