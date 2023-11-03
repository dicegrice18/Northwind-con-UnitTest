using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Controller;
using Northwind.Model;

namespace Northwind.ViewModel
{
    public class vmCustomers
    {
        SerCustomers sc;
        ObservableCollection<Customers> cust = new ObservableCollection<Customers>();
        public ObservableCollection<Customers> Cust { get => cust; set => cust = value; }

        public vmCustomers()
        {
            sc = new SerCustomers();
            CaricaDati();
        }

        public void CaricaDati()
        {
            cust = sc.AllCustomers();
        }
    }
}
