﻿using System;
using System.Collections.Generic;

namespace AddressBookADO.NET
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address book Service");
            AddressBookRepo addressBookRepo = new AddressBookRepo();

            List<AddressBookModel> listContacts = new List<AddressBookModel>();
            listContacts.Add(new AddressBookModel(FirstName: "Rashmi", LastName: "Sollapure", Address: "Hukkeri", City: "Belgaum", State: "Karnataka", Zip: 562974, PhoneNumber: "7223691472", Email: "rashmi@gmail.com", AddedDate: Convert.ToDateTime("2019-05-31 12:00:00 AM")));
            listContacts.Add(new AddressBookModel(FirstName: "Sabil", LastName: "Mujawar", Address: "Maula Ali", City: "Vizag", State: "Andhra Pradesh", Zip: 562874, PhoneNumber: "8523691472", Email: "sabil@gmail.com", AddedDate: Convert.ToDateTime("05 - 02 - 2019 12:00:00 AM")));
            listContacts.Add(new AddressBookModel(FirstName: "Zaid", LastName: "Soudagar", Address: "Chikodi", City: "Belgaum", State: "Karnataka", Zip: 479874, PhoneNumber: "8523647472", Email: "zaid@gmail.com", AddedDate: Convert.ToDateTime("19 - 10 - 2020 12:00:00 AM")));
            listContacts.Add(new AddressBookModel(FirstName: "Anusha", LastName: "Adapa", Address: "Athani", City: "Belgaum", State: "Karnataka", Zip: 569823, PhoneNumber: "6523791472", Email: "anusha@gmail.com", AddedDate: Convert.ToDateTime("15 - 01 - 2018 12:00:00 AM")));
            listContacts.Add(new AddressBookModel(FirstName: "Aishwarya", LastName: "Pise", Address: "Hinjewadi", City: "Pune", State: "Maharastra", Zip: 536981, PhoneNumber: "8253691472", Email: "ash@gmail.com", AddedDate: Convert.ToDateTime("25 - 07 - 2017 12:00:00 AM")));
            listContacts.Add(new AddressBookModel(FirstName: "Sushil", LastName: "Ashtekar", Address: "Kakti", City: "Belgaum", State: "Karnataka", Zip: 569874, PhoneNumber: "7623691472", Email: "sushil@gmail.com", AddedDate: Convert.ToDateTime("18 - 02 - 2020 12:00:00 AM")));
            listContacts.Add(new AddressBookModel(FirstName: "Adnan", LastName: "Darga", Address: "Chinchwad", City: "Pune", State: "Maharastra", Zip: 590016, PhoneNumber: "7583691474", Email: "addy@gmail.com", AddedDate: Convert.ToDateTime("10 - 11 - 2018 12:00:00 AM")));
            listContacts.Add(new AddressBookModel(FirstName: "Pratik", LastName: "Dharnaik", Address: "Hukkeri", City: "Belgaum", State: "Karnataka", Zip: 590006, PhoneNumber: "7223691442", Email: "pratik@gmail.com", AddedDate: Convert.ToDateTime("31 - 12 - 2019 12:00:00 AM")));

            addressBookRepo.AddContactToDbUsingThreads(listContacts);
        }
    }
}