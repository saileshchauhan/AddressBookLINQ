using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AddressBookLINQ
{
    class AdBookDataTable
    {
        DataTable adressBookTable = new DataTable();
        public void AddDataRow()
        {
            adressBookTable.Columns.Add("FirstName", typeof(string));
            adressBookTable.Columns.Add("LastName", typeof(string));
            adressBookTable.Columns.Add("Address", typeof(string));
            adressBookTable.Columns.Add("City", typeof(string));
            adressBookTable.Columns.Add("State", typeof(string));
            adressBookTable.Columns.Add("ZIP", typeof(string));
            adressBookTable.Columns.Add("PhoneNumber", typeof(int));
            adressBookTable.Columns.Add("E-mail", typeof(string));
            adressBookTable.Rows.Add("Sam", "Bush", "Street 12", "Bhopal", "Madhya Pradesh", "460551", 98989898, "sam@gmail.com");
            adressBookTable.Rows.Add("Som", "Clan", "Street 15", "Indore", "Madhya Pradesh", "460512", 98456423, "som@gmail.com");
            adressBookTable.Rows.Add("Luke", "Obama", "Street 11", "Hyderabad", "Andhra Pradesh", "460897", 98789566, "bill@gmail.com");
            adressBookTable.Rows.Add("Sam", "Bush", "Street 12", "Bhopal", "Madhya Pradesh", "460551", 98989898, "sam@gmail.com");
            adressBookTable.Rows.Add("Sam", "Bush", "Street 12", "Bhopal", "Madhya Pradesh", "460551", 98989898, "sam@gmail.com");
            adressBookTable.Rows.Add("Sam", "Bush", "Street 12", "Bhopal", "Madhya Pradesh", "460551", 98989898, "sam@gmail.com");
            adressBookTable.Rows.Add("Sam", "Bush", "Street 12", "Bhopal", "Madhya Pradesh", "460551", 98989898, "sam@gmail.com");
            adressBookTable.Rows.Add("Sam", "Bush", "Street 12", "Bhopal", "Madhya Pradesh", "460551", 98989898, "sam@gmail.com");
            adressBookTable.Rows.Add("Sam", "Bush", "Street 12", "Bhopal", "Madhya Pradesh", "460551", 98989898, "sam@gmail.com");
            adressBookTable.Rows.Add("Sam", "Bush", "Street 12", "Bhopal", "Madhya Pradesh", "460551", 98989898, "sam@gmail.com");
            adressBookTable.Rows.Add("Sam", "Bush", "Street 12", "Bhopal", "Madhya Pradesh", "460551", 98989898, "sam@gmail.com");
        }
    }
}
