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
    public class PercyJacksonTest
    {

        private PercyJackson percyJackson { get; set; }

        [SetUp]
        public void InstaciasAntesDeCadaTest()
        {
            // Arrange
            percyJackson = new PercyJackson();
        }

        [Test]
        public void Test2LibrosC()
        {
            // Act
            //---------------------------------->(A,B,C,D,E)
            var num = percyJackson.SumaPrecioTotal(0,0,0,0,2);

            // Assert
            Assert.AreEqual(16, Math.Round(num, 2));
        }


        [Test]
        public void Test5LibrosA()
        {
            // Act
            //---------------------------------->(A,B,C,D,E)
            var num = percyJackson.SumaPrecioTotal(5,0,0,0,0);

            // Assert
            Assert.AreEqual(40, Math.Round(num, 2));
        }


        [Test]
        public void Testx4Ax1Bx5Cx2Dx3E()
        {
            // Act
            //---------------------------------->(A,B,C,D,E)
            var num = percyJackson.SumaPrecioTotal(4,1,5,2,3);

            // Assert
            Assert.AreEqual(100.4, Math.Round(num, 2));
        }


        [Test]
        public void Testx2Ax2Bx2Cx1Dx1E()
        {
            // Act
            //---------------------------------->(A,B,C,D,E)
            var num = percyJackson.SumaPrecioTotal(2,2,2,1,1);

            // Assert
            Assert.AreEqual(51.6, Math.Round(num, 2));
        }

        [Test]
        public void Testx3Ax5Bx1Cx9Dx3E()
        {
            // Act
            //---------------------------------->(A,B,C,D,E)
            var num = percyJackson.SumaPrecioTotal(3, 5, 1, 9, 3);

            // Assert
            Assert.AreEqual(143.6, Math.Round(num, 2));
        }

        [Test]
        public void Testx4Ax5Bx2Cx3Dx1E()
        {
            // Act
            //---------------------------------->(A,B,C,D,E)
            var num = percyJackson.SumaPrecioTotal(4, 5, 2, 3, 1);

            // Assert
            Assert.AreEqual(100.4, Math.Round(num, 2));
        }

        [Test]
        public void Testx58Ax4Bx4Cx3Dx0E()
        {
            // Act
            //---------------------------------->(A,B,C,D,E)
            var num = percyJackson.SumaPrecioTotal(5, 4, 4, 3, 0);

            // Assert
            Assert.AreEqual(106.4, Math.Round(num, 2));
        }


    }
}
