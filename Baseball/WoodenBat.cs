﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    public class WoodenBat : IBaseballBat
    {
        public int WeightInGrams { get; set; }

       
        public void Swing()
        {
            Console.WriteLine("Crack");
        }
    }
}
