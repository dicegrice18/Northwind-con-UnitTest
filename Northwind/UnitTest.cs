using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind
{
    public class UnitTest
    {
        public void TestSum()
        {
            //Arrange --> cose da "sistemare"/testare
            Math math = new Math();

            //Act --> test vero è proprio
            double result = math.Sum(100, 123);


            //Assert --> risultato del test
            if(result == 223)
            {
                Console.WriteLine("Works!");
                //Assert.Equals(223, result);
            }
            else
            {
                Console.WriteLine("Doesn't Works!");
            }
        }
    }
}
