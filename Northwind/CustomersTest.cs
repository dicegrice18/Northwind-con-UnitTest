using Northwind.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind
{
    public class CustomersTest
    {
        public void CountCustomersTest()
        {
            int count = 91;
            vmCustomers vmCustomers = new vmCustomers();

            if(vmCustomers.Cust.Count == count)
            {
                Console.WriteLine("Ci sono tutti i record");
            }
            else
            {
                Console.WriteLine("Manca qualche record");
            }
        }
    }
}
