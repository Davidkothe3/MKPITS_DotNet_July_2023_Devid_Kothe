﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sn = 1, en = 2;
            int res1, res2;
            int counter = 1;
            while (counter <= 10)
            {
                res1 = sn * counter;
                res2 = en * counter;
                Console.Write("{0}*{1}={2}", sn, counter, res1);
                Console.Write("\t");
                Console.Write("{0}*{1}={2}", en, counter, res2);

                counter++;
                Console.WriteLine();

            }
        }
}
