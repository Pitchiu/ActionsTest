using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Tests
{
    [TestClass()]
    public class StringCalculatorTests
    {
        [TestMethod()]
        public void CalculatorShouldReturnZeroWithEmptyString()
        {
            var calculator = new StringCalculator();
            var input = "";

            var result = calculator.Calculate(input);

            Assert.IsTrue(result == 0);
        }

        [TestMethod()]
        public void CalculatorShouldReturnValueWithSingleNumber()
        {
            var calculator = new StringCalculator();
            var input = "1";

            var result = calculator.Calculate(input);

            Assert.IsTrue(result == 1);
        }

        [TestMethod()]
        public void CalculatorShouldReturnSumForCommaSeparatedValues()
        {
            var calculator = new StringCalculator();
            var input = "3,5";

            var result = calculator.Calculate(input);

            Assert.IsTrue(result == 8);
        }

        [TestMethod()]
        public void CalculatorShouldReturnSumForNewlineDelimitors()
        {
            var calculator = new StringCalculator();
            var input = "3\n5";

            var result = calculator.Calculate(input);

            Assert.IsTrue(result == 8);
        }

        [TestMethod()]
        public void CalculatorShouldReturnSumOfThreeNumbersForEitherDelimitor()
        {
            var calculator = new StringCalculator();
            var input = "3\n5,3";

            var result = calculator.Calculate(input);

            Assert.IsTrue(result == 11);
        }
    }
}