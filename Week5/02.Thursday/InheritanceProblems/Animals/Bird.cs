﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Bird : Animal
    {
        public virtual string Nest()
        {
            return null;
        }
    }
}
