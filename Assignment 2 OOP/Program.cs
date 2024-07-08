namespace Assignment_2_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Phonebook 
            PhoneBook Note = new PhoneBook(3);

            Note.AddPerson(0, "Mohab", 123);
            Note.AddPerson(1, "Mohamed", 563);
            
            ///[Without Indexer]
            Note.SetNumber("Belkan", 888888);
            Console.WriteLine(Note.GetNumber("Mohamed"));  
            


            #endregion

        }
    }
}
