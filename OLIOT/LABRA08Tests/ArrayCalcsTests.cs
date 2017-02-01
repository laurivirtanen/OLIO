using Microsoft.VisualStudio.TestTools.UnitTesting;
using LABRA08_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABRA08_.Tests
{
    [TestClass()]
    public class ArrayCalcsTests
    {
        [TestMethod()]
        public void ArrayCalcsTest()
        {

            Assert.Fail();
        }

        [TestMethod()]
        public void SumTest()
        {
            ///AAA periaate
            ///A=Arrange - tietojen alustus
            ///A=Act - kutsutaan metodia
            ///A=Assert - varmistetaan että tulos ok
            //arrange
            double[] arr = { 1.0, 2.0, 3.0 };
            ArrayCalcs lask = new ArrayCalcs(arr);
            double expected = 6.0;
            //act
            double actual = ArrayCalcs.Sum(arr);
            //assert
            Assert.AreEqual(expected, actual);

                
        }

        [TestMethod()]
        public void AvgTest()
        {
            double[] arr = { 1.0, 2.0, 3.0 };
            ArrayCalcs lask = new ArrayCalcs(arr);
            double expected = 2.0;
            //act
            double actual = ArrayCalcs.Avg(arr);
            //assert
            Assert.AreEqual(expected, actual);


            ///empty double array fails the test due to "Index was outside the bounds of the array."
            double[] ar = { };
            ArrayCalcs lask2 = new ArrayCalcs(ar);
            expected = 0d;
            //act
            actual = ArrayCalcs.Avg(ar);
            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod()]
        public void MinTest()
        {
            double[] arr = { 1.0, 2.0, 3.0 };
            ArrayCalcs lask = new ArrayCalcs(arr);
            double expected = 1.0;
            //act
            double actual = ArrayCalcs.Min(arr);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxTest()
        {
            double[] arr = { 1.0, 2.0, 3.0 };
            ArrayCalcs lask = new ArrayCalcs(arr);
            double expected = 3.0;
            //act
            double actual = ArrayCalcs.Max(arr);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.Fail();
        }
    }
}