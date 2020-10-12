using CalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace UnitTestProject
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTwoPositiveNumbers()
        {
            Calculator calculator = new Calculator();
            double a = 2.4;
            double b = 3.9;

            double answer = a + b;
            double methodReturn = calculator.DoOperation(a, b, "+");
            Assert.AreEqual(answer, methodReturn);
            calculator.Finish();
        }

        [TestMethod]
        public void AddFirstPositiveNumberWithSecondNegativeNumber()
        {
            Calculator calculator = new Calculator();
            double a = 2.1;
            double b = -3.9;

            double answer = a + b;
            double methodReturn = calculator.DoOperation(a, b, "+");
            Assert.AreEqual(answer, methodReturn);
            calculator.Finish();
        }

        [TestMethod]
        public void AddTwoNegativeNumbers()
        {
            Calculator calculator = new Calculator();
            double a = -2.0;
            double b = -3.4;

            double answer = a + b;
            double methodReturn = calculator.DoOperation(a, b, "+");
            Assert.AreEqual(answer, methodReturn);
            calculator.Finish();
        }

        [TestMethod]
        public void AddFirstNegativeNumberWithSecondPositiveNumber()
        {
            Calculator calculator = new Calculator();
            double a = -2.0;
            double b = 3.4;
            double answer = a + b;
            double methodReturn = calculator.DoOperation(a, b, "+");
            Assert.AreEqual(answer, methodReturn);
            calculator.Finish();
        }

        [TestMethod]
        public void SubstractTwoPositiveNumbers()
        {
            Calculator calculator = new Calculator();
            double a = 8.0;
            double b = 4.4;
            double answer = a - b;
            double methodReturn = calculator.DoOperation(a, b, "-");
            Assert.AreEqual(answer, methodReturn);
            calculator.Finish();
        }

        [TestMethod]
        public void SubstractTwoNegativeNumbers()
        {
            Calculator calculator = new Calculator();
            double a = -2.0;
            double b = -3.4;

            double answer = a - b;
            double methodReturn = calculator.DoOperation(a, b, "-");
            Assert.AreEqual(answer, methodReturn);
            calculator.Finish();
        }

        [TestMethod]
        public void MultiplyTwoPositiveNumbers()
        {
            Calculator calculator = new Calculator();
            double a = 2.0;
            double b = 3.7;

            double answer = a * b;
            double methodReturn = calculator.DoOperation(a, b, "*");
            Assert.AreEqual(answer, methodReturn);
            calculator.Finish();

        }

        [TestMethod]
        public void MultiplyTwoNegativeNumbers()
        {
            Calculator calculator = new Calculator();
            double a = -2.0;
            double b = -3.7;

            double answer = a * b;
            double methodReturn = calculator.DoOperation(a, b, "*");
            Assert.AreEqual(answer, methodReturn);
            calculator.Finish();

        }

        [TestMethod]
        public void MultiplyFirstPositiveNumberWithSecondNegativeNumber()
        {
            Calculator calculator = new Calculator();
            double a = 2.0;
            double b = -3.7;

            double answer = a * b;
            double methodReturn = calculator.DoOperation(a, b, "*");
            Assert.AreEqual(answer, methodReturn);
            calculator.Finish();

        }

        [TestMethod]
        public void MultiplyFirstNegativeNumberWithSecondPositiveNumber()
        {
            Calculator calculator = new Calculator();
            double a = -2.0;
            double b = 3.7;

            double answer = a * b;
            double methodReturn = calculator.DoOperation(a, b, "*");
            Assert.AreEqual(answer, methodReturn);
            calculator.Finish();

        }


        [TestMethod]
        public void DivideTwoPositiveNumbers()
        {
            Calculator calculator = new Calculator();
            double a = 4;
            double b = 2;
            double answer = a / b;
            double methodReturn = calculator.DoOperation(a, b, "/");
            Assert.AreEqual(answer, methodReturn);
            calculator.Finish();
        }
    }
}
