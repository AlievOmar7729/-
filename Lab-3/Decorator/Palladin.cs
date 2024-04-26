﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Palladin : Hero
    {
        public Palladin()
        {
            Hit = 100;
            Protection = 50;
            Speed = 80;
        }
        public override int GetHit()
        {
            return Hit;
        }
        public override int GetProtection()
        {
            return Protection;
        }
        public override int GetSpeed()
        {
            return Speed;
        }

    }
}