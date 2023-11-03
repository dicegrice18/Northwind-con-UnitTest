using System;
using Northwind;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //assegnazione
            Northwind.Math math = new Northwind.Math();
            
            //Act
            var result = math.Sum(1, 2);

            //assert
            Assert.Equal(3, result);
        }
    }
}
