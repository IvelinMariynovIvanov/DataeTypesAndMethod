﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataeTypesAndMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("centiries = ");
            int centuries = int.Parse(Console.ReadLine());
            int years = 100 * centuries;
            int days = (int) (years * 365.2422);
            int hours = 24 * days;
            long minutes = 60 * hours;

            Console.WriteLine(" {0} centuries = {1} years = {2} days = {3} hours = {4} minutes",
                centuries, years, days, hours, minutes);

        }
    }
}
