using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment_2_OOP
{
    internal struct PhoneBook
    {
        #region Attributes
        string[] names;
        long[] numers;
        int size;
        #endregion

        #region Properties
        public int Size
        {
            get
            {
                return size;
            }

        }

        public long GetNumber(string Name) 
        {
            if (names is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (Name == names[i])
                    {
                        return numers[i];
                    }
                }
            }
            
            return -1;
        }

        public void SetNumber(string name , long newNumber) 
        {
            if (names is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (name == names[i])
                    {
                        numers[i]=newNumber;
                        break;
                    }
                }
            }
        }
        #endregion

        #region Constractor
        public PhoneBook(int _size)
        {
            size = _size;

            names = new string[size];
            numers = new long[size];
        }
        #endregion

        #region Methods
        public void AddPerson(int position, string name, long number)
        {
            if (names is not null && numers is not null)
            {
                if (position >= 0 && position < size)
                {
                    names[position] = name;
                    numers[position] = number;
                }
            }

        } 
        #endregion



    }
}
