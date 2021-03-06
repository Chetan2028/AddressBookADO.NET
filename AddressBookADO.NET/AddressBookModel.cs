﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookADO.NET
{
    public class AddressBookModel
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string BookName { get; set; }
        public int TypeId { get; set; }
        public string Type { get; set; }
        public int BookId { get; set; }
        public DateTime AddedDate { get; set; }

        public AddressBookModel() { }

        public AddressBookModel(string FirstName, string LastName, string Address, string City, string State, int Zip, string PhoneNumber, string Email, DateTime AddedDate)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.Zip = Zip;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.AddedDate = AddedDate;
        }
    }
}
