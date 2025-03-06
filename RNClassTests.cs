using Microsoft.VisualStudio.TestTools.UnitTesting;
using RationalNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumbers.Tests
{
    [TestClass()]
    public class RNClassTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            RNClass rn = new RNClass(5, 6);
            Assert.AreEqual("5/6", rn.ToString());
        }

        [TestMethod()]
        public void ToStringTestNegativeNumenator()
        {
            RNClass rn = new RNClass(-5, 6);
            Assert.AreEqual("-5/6", rn.ToString());
        }

        [TestMethod()]
        public void ToStringTestNegativeDenominator()
        {
            RNClass rn = new RNClass(5, -6);
            Assert.AreEqual("-5/6", rn.ToString());
        }

        [TestMethod()]
        public void ToStringTestNegativeNUMorDEN()
        {
            RNClass rn = new RNClass(-5, -6);
            Assert.AreEqual("5/6", rn.ToString());
        }

        [TestMethod()]
        public void SummTest()
        {
            RNClass rn = new RNClass(1,2);
            rn = rn + new RNClass(2,3);
            Assert.AreEqual("7/6",rn.ToString());
        }

        [TestMethod()]
        public void SubtractionTest()
        {
            RNClass rn = new RNClass(1, 2);
            rn = rn - new RNClass(2, 3);
            Assert.AreEqual("-1/6", rn.ToString());
        }

        [TestMethod()]
        public void MultiplicationTest()
        {
            RNClass rn = new RNClass(1, 2);
            rn = rn * new RNClass(2, 3);
            Assert.AreEqual("1/3", rn.ToString());
        }

        [TestMethod()]
        public void DivisionTest() 
        {
            RNClass rn = new RNClass(1, 2);
            rn /= new RNClass(2, 3);
            Assert.AreEqual("3/4", rn.ToString());
        }

        [TestMethod()]
        public void UnaryMinusTest() 
        {
            RNClass rn = new RNClass(1, 2);
            rn = -rn;
            Assert.AreEqual("-1/2", rn.ToString());
        }

        [TestMethod()]
        public void EqualTest() 
        { 
            RNClass rn1 = new RNClass(1, 2);
            RNClass rn2 = new RNClass(1, 2);

            Assert.IsTrue(rn1==rn2);
        }

        [TestMethod()]
        public void NotEqualTest()
        {
            RNClass rn1 = new RNClass(1, 2);
            RNClass rn2 = new RNClass(3, 2);

            Assert.IsTrue(rn1 != rn2);
        }

        [TestMethod()]
        public void Less()
        {
            RNClass rn1 = new RNClass(1, 5);
            RNClass rn2 = new RNClass(2,3);

            Assert.IsTrue(rn1 < rn2);
        }

        [TestMethod()]
        public void LessOrEquel()
        {
            RNClass rn1 = new RNClass(1, 2);
            RNClass rn2 = new RNClass(1, 2);

            Assert.IsTrue(rn1 <= rn2);
        }

        [TestMethod()]
        public void Greater()
        {

            RNClass rn1 = new RNClass(3, 5);
            RNClass rn2 = new RNClass(1, 2);

            Assert.IsTrue(rn1 > rn2);
        }

        [TestMethod()]
        public void GreaterOrEquel()
        {
            RNClass rn1 = new RNClass(1, 2);
            RNClass rn2 = new RNClass(1, 2);

            Assert.IsTrue(rn1 >= rn2);
        }

    }
}