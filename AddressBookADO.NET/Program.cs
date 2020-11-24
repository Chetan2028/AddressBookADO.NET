using System;

namespace AddressBookADO.NET
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address book Service");
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            bool result = addressBookRepo.UpdateContactTable();
            Console.WriteLine("Contact Updated in Table : " + result);
        }
    }
}
