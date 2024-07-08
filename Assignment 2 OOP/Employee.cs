using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_2_OOP
{
    #region Enums
    public enum SecurityPrivileges : byte
    {
        guest, Developer, secretary, DBA
    }
    public enum Gender
    {
        Male, Female
    } 
    #endregion
    internal class Employee
    {
        #region Attributes
        int? id;
        string? name;
        SecurityPrivileges securityLevel;
        public HiringDate? hireDate;
        public Gender gender { get; set; }
        double salary;
        public Employee[] empArr;

        #endregion


        #region Constractors
        public Employee()
        {

        }
        public Employee(int id, string name, Gender gender, double salary, HiringDate hireDate, SecurityPrivileges securityLevel)
        {
            empArr = new Employee[3];


            if (salary < 0)
            {
                Console.WriteLine("Salary cannot be negative.");
                return;
            }
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.salary = salary;
            this.hireDate = hireDate;
            this.securityLevel = securityLevel;
        }

        #endregion


        #region Properties
        //public char Gender
        //{
        //    get { return gender; }
        //    set
        //    {
        //        if (value == '\0')
        //        {
        //            Console.WriteLine("Wrong Format");
        //            return;
        //        }
        //        if (value == 'F' || value == 'M')
        //        {
        //            gender = value;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Wrong Format");
        //        }

        //    }
        //}



        #endregion


        #region Methods
        public override string ToString()
        {
            string salaryyy = string.Format("{0:C}", salary);
            return $"Id : {id}\nName : {name}\nSecurity Level : {securityLevel}\nHire Date : {hireDate?.FullDate()}\nGender : {gender}\nSalary : {salaryyy}";
        } 
        #endregion




    }
}
