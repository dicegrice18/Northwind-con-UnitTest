using Northwind.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Controller
{
    internal class SerCustomers
    {
        public ObservableCollection<Customers> AllCustomers()
        {
            using (NorthwindEntities Entities = new NorthwindEntities())
            {
                return new ObservableCollection<Customers>(Entities.Customers.ToList());
            }
        }

        public Customers GetCustomer(string ID)
        {
            using (NorthwindEntities Entities = new NorthwindEntities())
            {
                return Entities.Customers.FirstOrDefault(c => c.CustomerID == ID);
            }
        }

        public ObservableCollection<Customers> AllCustomersSQL()
        {
            ObservableCollection<Customers> cust = new ObservableCollection<Customers>();
            using (NorthwindEntities Entities = new NorthwindEntities())
            {
                var elenco = (from c in Entities.Customers select c ).ToList();
                cust = new ObservableCollection<Customers>(elenco);
            }
            return cust;
        }


    }
}
