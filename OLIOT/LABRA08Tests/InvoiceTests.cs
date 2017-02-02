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
    public class InvoiceTests
    {
        [TestMethod()]
        public void InTotalTest()
        {
            ///AAA periaate
            ///A=Arrange - tietojen alustus
            ///A=Act - kutsutaan metodia
            ///A=Assert - varmistetaan että tulos ok
            //arrange
            List<InvoiceItem> itams = new List<InvoiceItem>();
            itams.Add(new InvoiceItem("daa", 2.5, 1));
            itams.Add(new InvoiceItem("lal", 2.5, 2));
            Invoice baa = new Invoice(itams, "test");
            double expected = 7.5;

            //act
            double actual = baa.InTotal();
            //assert
            Assert.AreEqual(expected, actual);

            List<InvoiceItem> itams2 = new List<InvoiceItem>();
            itams2.Add(new InvoiceItem("daa", 2.5, 3));
            itams2.Add(new InvoiceItem("lal", 2.5, 2));
            itams2.Add(new InvoiceItem("lal", 2, 2));
            Invoice baa2 = new Invoice(itams2, "test");
            expected = 16.5;

            //act
            actual = baa2.InTotal();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}