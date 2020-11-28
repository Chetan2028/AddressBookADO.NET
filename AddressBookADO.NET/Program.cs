using System;

namespace AddressBookADO.NET
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address book Service");
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            AddressBookModel model = new AddressBookModel();
            model.FirstName = "Ayush";
            model.LastName = "Vedpatak";
            model.Address = "Near IMA HAll";
            model.City = "Mysore";
            model.State = "Karnataka";
            model.Zip = 410256;
            model.PhoneNumber = "8523146978";
            model.Email = "ayush@gmail.com";
            model.BookName = "GogteCollege";
            model.Type = "Family";

           var result = addressBookRepo.AddContactToDatabase(model);
            Console.WriteLine("Contact added to database : " + result);
        }
    }
}
