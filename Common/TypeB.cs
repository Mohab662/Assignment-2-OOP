using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB : TypeA
    {
        public TypeB()
        {
            TypeA obj = new TypeA();
            // without inhertance //
            //  obj.x = 0; // inValid
            // obj.y = 0; // inValid
            // obj.z=0;   // Valid

            // with inhertance //
            //  obj.x = 0; // inValid
            // obj.y = 0; // inValid
            // obj.z=0;   // Valid

            /////same Project
            // x is  private
            // y is  private
            // z is  internal
        }
    }
}
