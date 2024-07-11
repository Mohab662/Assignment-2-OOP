using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_OOP.Inhertince
{
    internal class Parent
    {
        #region Properties
        public int X { get; set; }
        public int Y { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{X} , {Y}";
        } 

        public virtual int Product()
        {
            return X * Y;
        }
        #endregion

        #region Constractors
        public Parent(int _x , int _y)
        {
            X=_x ;
            Y=_y ;
        } 
        #endregion
    }
}
