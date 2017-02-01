using Microsoft.VisualStudio.TestTools.UnitTesting;
using CALCTEST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALCTEST.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            ///AAA periaate
            ///A=Arrange - tietojen alustus
            ///A=Act - kutsutaan metodia
            ///A=Assert - varmistetaan että tulos ok
            //arrange
            Calculator calc = new Calculator();
            int a = 4;
            int b = 5;
            int expected = 9;
            //act
            int actual = calc.Add(a, b);
            //assert
            Assert.AreEqual(expected, actual);

            a = 1;
            b = 0;
            expected = 1;
            actual = calc.Add(a, b);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Calculator calc = new Calculator();
            int a = 4;
            int b = 5;
            int expected = 20;

            int actual = calc.Multiply(a, b);

            Assert.AreEqual(expected, actual);

            a = 0;
            b = 10;
            expected = 0;

            actual = calc.Multiply(a, b);
            Assert.AreEqual(expected, actual);
           
        }
        [TestMethod()]
        public void DivideTest()
        {
            Calculator calc = new Calculator();
            int a = 10;
            int b = 5;
            int expected = 2;

            int actual = calc.Divide(a, b);

            Assert.AreEqual(expected, actual);

            a = 20;
            b = 4;
            expected = 5;

            actual = calc.Divide(a, b);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void SubtractTest()
        {
            Calculator calc = new Calculator();
            int a = 10;
            int b = 5;
            int expected = 5;
            //act
            int actual = calc.Subtract(a, b);
            //assert
            Assert.AreEqual(expected, actual);

            a = 55;
            b = 15;
            expected = 40;
            actual = calc.Subtract(a, b);
            Assert.AreEqual(expected, actual);

        }
    }
}