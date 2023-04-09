using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPrototype
{
    public class ConcretePrototypeA : IPrototype
    {
        public IPrototype Clone()
        {
            // Shallow Copy: only top-level objects are duplicated
            return (IPrototype)MemberwiseClone();

            // Deep Copy: all objects are duplicated
            //return (Prototype)this.Clone();
        }
       
    }

    public class ConcretePrototypeB : IPrototype
    {
        public IPrototype Clone()
        {
            // Shallow Copy: only top-level objects are duplicated
            return (IPrototype)MemberwiseClone();

            // Deep Copy: all objects are duplicated
            //return (Prototype)this.Clone();
        }
    }
}
