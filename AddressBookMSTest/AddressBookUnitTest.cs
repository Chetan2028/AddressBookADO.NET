using AddressBookADO.NET;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddressBookMSTest
{
    [TestClass]
    public class AddressBookUnitTest
    {
        [TestMethod]
        public void GivenQueryForAddingContact_WhenDatabaseConnected_ShouldReturnTrue_HappyCase()
        {
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            AddressBookModel model = new AddressBookModel();

            model.FirstName = "Sandy";
            model.LastName = "Pujeri";
            model.Address = "Hampi Nagar";
            model.City = "Bangalore";
            model.State = "Karnataka";
            model.Zip = 589647;
            model.PhoneNumber = "8523691475";
            model.Email = "Sandy@gmail.com";
            model.AddedDate = Convert.ToDateTime("2018-05-26");

            bool actual = addressBookRepo.AddContactToDatabase(model);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void GivenQueryForAddingContact_WhenDatabaseConnected_ShouldReturnFalse_SadCase()
        {
            AddressBookRepo addressBookRepo = new AddressBookRepo();
            AddressBookModel model = new AddressBookModel();

            bool actual = addressBookRepo.AddContactToDatabase(model);
            Assert.IsFalse(actual);
        }
    }
}
