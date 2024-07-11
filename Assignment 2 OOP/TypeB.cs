using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_OOP
{
    internal class TypeB : TypeA
    {
        public TypeB()
        {
            TypeA obj = new TypeA();
            //  obj.x;// inValid
            //  obj.y;// inValid
            //  obj.z;// Valid

            ///// not same Project
            // x is  not inherted
            // y is  private
            // z is  internal

        }

    }
}
