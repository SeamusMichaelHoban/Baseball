﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    interface IPlayer
    {
        int WeightInGrams { get; set; }
        void Swing();

    }
}
