﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPrototype
{
    /// <summary>
    /// The 'Prototype' interface
    /// </summary>
    public interface IEmployee
    {
        IEmployee Clone();
        string GetDetails();
    }
}
