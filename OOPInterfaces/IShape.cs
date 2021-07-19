﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInterfaces
{
    public interface IShape:ITranslatableObject,
                            IRotatableObject, 
                            IObjectWithARea
    {
        Point[] Points { get; }
    }
}
