﻿using System;
using System.Collections.Generic;

namespace Parrot
{
    public abstract class Parrot
    {
	    public abstract double GetSpeed();

        protected double GetBaseSpeed(double voltage)
        {
            return Math.Min(24.0, voltage * GetBaseSpeed());
        }

        protected double GetLoadFactor()
        {
            return 9.0;
        }

        protected double GetBaseSpeed()
        {
            return 12.0;
        }

        public abstract string GetCry();

    }
}