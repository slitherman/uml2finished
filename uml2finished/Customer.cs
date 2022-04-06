using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml2finished
{
    public class Customer
    {
        public string _Name { get; set; }
        public string _Email { get; set; }
        public static List<string> Customers = new List<string>();

        //Customer customer1 = new Customer("adamn sandler", "adamsandler@gmail.com");
        //Customer customer2 = new Customer("rxknephew", "slitherman@gmail.com");
        //Customer customer3 = new Customer("idi amin", "idiadmin@hotmail.com");
        //Customer customer4 = new Customer("purityfilter", "purityfilter@gmail.com");
        //Customer customer5 = new Customer("adam sandler 2", "adamnsandler2@gmail.com");



        public Customer()
        {
        
        }


        public Customer(string name, string email)
        {
            _Email = email;
            _Name = name;
        }

        //public static  void Createcustomer(Customer customer )
        //{
        //    Customers.Add(customer._Email);
        //}

        public void Deletecustomer(Customer customer)
        {
            Customers.Remove(customer._Email);
        }

        public static  void Searchcustomer(Customer customer)
        {
            Customers.Find(x => x.Contains(customer._Email));
        }
    }
}
