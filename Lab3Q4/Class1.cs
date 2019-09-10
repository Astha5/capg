using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Q4
{
    public class SupplierTest
    {
        private int _supplierId;
        private string _supplierName;
        private string _city;
        private string _email;
        private string _phone;

        public int SupplierId { get => _supplierId; set => _supplierId = value; }
        public string SupplierName { get => _supplierName; set => _supplierName = value; }
        public string City { get => _city; set => _city = value; }
        public string Email { get => _email; set => _email = value; }
        public string Phone { get => _phone; set => _phone = value; }
     

        public void Acceptdetails()
        {
          
            Console.WriteLine("Enter the Supplier Id");
           SupplierId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter SupplierName");
            SupplierName = Console.ReadLine();
            Console.WriteLine("Enter City");
            City = Console.ReadLine();
            Console.WriteLine("Enter Email");
            Email = Console.ReadLine();
            Console.WriteLine("Enter Phone");
            Phone = Console.ReadLine();

        }
        public void Displaydetails()
        {
            Console.WriteLine(" Supplier Id: " + SupplierId);
            Console.WriteLine(" SupplierName: " + SupplierName);
            Console.WriteLine(" City: " + City);
            Console.WriteLine(" Email: " + Email);
            Console.WriteLine(" Phone: " + Phone);
        }
    }
}