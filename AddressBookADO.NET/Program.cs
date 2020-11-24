using System;

namespace AddressBookADO.NET
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address book Service");
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            addressBookRepo.RetrieveContactWithinDateRange();
        }
    }
}
