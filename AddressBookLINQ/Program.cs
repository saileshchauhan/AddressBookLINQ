using System;

namespace AddressBookLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AdBookDataTable obj = new AdBookDataTable();
                obj.AddDataRow();
                obj.EditContact();
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            
        }
    }
}
