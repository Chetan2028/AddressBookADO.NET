using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AddressBookADO.NET
{
    public class AddressBookRepo
    {
        private static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AddressBook_Service;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);

        /// <summary>
        /// Gets all contacts.
        /// </summary>
        /// <exception cref="System.Exception"></exception>
        public void GetAllContacts()
        {
            try
            {
                AddressBookModel model = new AddressBookModel();
                using (this.connection)
                {
                    string query = "Select * from New_Address_Book";
                    SqlCommand command = new SqlCommand(query, this.connection);
                    this.connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            model.ContactId = reader.GetInt32(0);
                            model.FirstName = reader.GetString(1);
                            model.LastName = reader.GetString(2);
                            model.Address = reader.GetString(3);
                            model.City = reader.GetString(4);
                            model.State = reader.GetString(5);
                            model.Zip = reader.GetInt32(6);
                            model.PhoneNumber = reader.GetString(7);
                            model.Email = reader.GetString(8);

                            Console.WriteLine(model.ContactId + "\t" + model.FirstName + "\t"+model.LastName+"\t"+model.Address+"\t"
                                +model.City + "\t"+model.State+"\t"+model.Zip+"\t"+model.PhoneNumber+"\t"+model.Email);

                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Data Not Found");
                    }
                    reader.Close();
                    this.connection.Close();
                }
            }
           catch(Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }
    }
}
