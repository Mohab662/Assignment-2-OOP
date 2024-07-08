using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment_2_OOP
{
    internal class HiringDate
    {
        #region Attributes
        int day, month, years;
        int hiringDate;
        #endregion

        #region Constractors
        public HiringDate(int day, int month, int year)
        {

            this.day = day;
            this.month = month;
            this.years = year;
        }
        #endregion


        #region Properties
        public int Day
        {
            get { return day; }
            set
            {
                if (value > 0 && value < 31)
                {
                    day = value;
                }
                else
                {
                    return;
                }
                {
                }
            }
        }
        public int Month
        {
            get { return month; }
            set
            {
                if (value > 0 && value < 12)
                {
                    month = value;
                }
                else
                {
                    return;
                }

            }
        }
        public int Years
        {
            get { return years; }
            set
            {
                if (value > 2000 && value < 2024)
                {
                    years = value;
                }
                else
                {
                    return;
                }

            }
        } 
        #endregion


        #region Methods
        public string FullDate()
        {
            return $"{day}\\{month}\\{years}";
        } 
        #endregion


    }
}
