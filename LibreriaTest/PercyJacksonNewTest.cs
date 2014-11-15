using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using Libreria;

namespace LibreriaTest
{

    [TestFixture]
    public class PercyJacksonNewTest
    {

        private PercyJacksonNew percyJacksonNew { get; set; }

        [SetUp]
        public void InstaciasAntesDeCadaTest()
        {
            // Arrange
            percyJacksonNew = new PercyJacksonNew();
        }

        [Test]
        public void TestNumero1()
        {
            // Act
            //---------------------------------->(A,B,C,D,E)
            var num = percyJacksonNew.SumaPrecioTotalNew(4, 5, 2, 3, 1);
              
            // Assert
            Assert.AreEqual(100.4, Math.Round(num, 2));
        }


        [Test]
        public void TestNumero2()
        {
            // Act
            //---------------------------------->(A,B,C,D,E)
            var num = percyJacksonNew.SumaPrecioTotalNew(5, 4, 4, 3, 0);

            // Assert
            Assert.AreEqual(106.4, Math.Round(num, 2));
        }
    }
}