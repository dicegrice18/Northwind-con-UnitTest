using Northwind.Controller;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Northwind
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SerCustomers sc;
        public MainWindow()
        {
            InitializeComponent();
            sc = new SerCustomers();
            Write();
        }

        private void btnCarica_Click(object sender, RoutedEventArgs e)
        {
            //drgDati.ItemsSource = sc.AllCustomers();
        }

        public void Write()
        {
            StreamWriter sw = new StreamWriter("test.txt");
            sw.WriteLine("ciao a tutti!");
            sw.Close();
        }


        //-------------Unit Test----------------//
        public void Test()
        {
            //Arrange

            //Act --> test vero è proprio
            Write();
            //Assert --> risultato del test
            StreamReader sr = new StreamReader("test.txt");
            string line = "";

            while ((line = sr.ReadLine())!= null)
            {
                lbxDati.Items.Add(line);
            }
            sr.Close();
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            
            for (int k = 0; k < 100; k++) { Test(); }
            
        }

        private void btnUnit_Click(object sender, RoutedEventArgs e)
        {
            UnitTest unitTest = new UnitTest();
            unitTest.TestSum();
        }
    }
}
