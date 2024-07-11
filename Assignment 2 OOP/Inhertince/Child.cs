using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_OOP.Inhertince
{
    internal class Child : Parent
    {
        public int Z { get; set; }

        public Child(int _x , int _y , int _z):base(_x, _y)
        {
            Z = _z;
        }

        ///  With New
        //public new int Product()
        //{
        //    return X * Y * Z;
        //}
        ///  With override
        public override int Product()
        {
            return X * Y * Z;
        }

        public override string ToString()
        {
            return $"{X} , {Y} , {Z}";
        }
    }
}
