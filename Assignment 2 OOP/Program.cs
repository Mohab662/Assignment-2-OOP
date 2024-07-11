namespace Assignment_2_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //last Session
            #region Phonebook [With & Without Indexer]
            //PhoneBook Note = new PhoneBook(3);

            //Note.AddPerson(0, "Mohab", 123);
            //Note.AddPerson(1, "Mohamed", 563);

            /////[Without Indexer]
            //Note.SetNumber("Belkan", 888888);
            //Console.WriteLine(Note.GetNumber("Mohamed"));

            /////[With Indexer]
            //Note["Mohamed"] = 9999;
            //Console.WriteLine(Note["Mohamed"]);

            //Console.WriteLine(Note[0]);


            #endregion

            #region Class
            Car c1= new Car(10, "BMW" , 320);
            Console.WriteLine(c1.ToString());
           // c1 = new Car(20,"Verna");
           // c1 = new Car(20);

            #endregion



            Employee employee = new Employee();
            
            employee.empArr=new Employee[3];

            Console.WriteLine(employee.ToString());
            Console.WriteLine("*************************");

            employee.empArr[0] = new Employee(123,"Mohab",Gender.Male, 1008000.0,new HiringDate(2,6,2003), SecurityPrivileges.DBA);
            employee.empArr[1] = new Employee(2003, "Mohamed", Gender.Male, 1500000.0, new HiringDate(2, 5, 2003), SecurityPrivileges.guest);
            employee.empArr[2] = new Employee(27, "Mohab", Gender.Male,12000000.0, new HiringDate(2, 5, 2007), SecurityPrivileges.secretary);

            //  Console.WriteLine(employee.empArr[0]);


            #region Sort The Array
            //Sort
            for (int i = 0; i < employee.empArr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < employee.empArr?.Length; j++)
                {
                    if (employee.empArr is not null)
                    {
                        if (employee.empArr[j].hireDate?.Years < employee.empArr[minIndex].hireDate?.Years)
                        {
                            minIndex = j;
                        }
                        else if (employee.empArr[j].hireDate?.Years == employee.empArr[minIndex].hireDate?.Years)
                        {
                            if (employee.empArr[j].hireDate?.Month < employee.empArr[minIndex].hireDate?.Month)
                            {
                                minIndex = j;
                            }
                        }
                        else
                        {
                            if (employee.empArr[j].hireDate?.Day < employee.empArr[minIndex].hireDate?.Day)
                            {
                                minIndex = j;
                            }
                        }
                    }
                }

                Employee temp = employee.empArr[minIndex];
                employee.empArr[minIndex] = employee.empArr[i];
                employee.empArr[i] = temp;


            }

            //Print
            for (int i = 0; i < employee.empArr.Length; i++)
            {
                Console.WriteLine(employee.empArr[i]);
                Console.WriteLine();
            } 
            #endregion

        }
    }
}
