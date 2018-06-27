using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoCTestApp.Models;

namespace MoCTestApp.Helpers
{
    public class Customers
    {
        public static List<Customer> CreateCustomers()
        {
            List<Customer> customerList = new List<Customer>();

            customerList.Add(new Customer(1, "Joe"));
            customerList.Add(new Customer(2, "Sara"));
            customerList.Add(new Customer(3, "John"));
            customerList.Add(new Customer(4, "Melissa"));

            return customerList;
        }


    }
}