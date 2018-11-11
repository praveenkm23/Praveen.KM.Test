using System;
using dotNetTechChallenge.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotNetTechChallenge.Tests.Controllers
{
    [TestClass]
    public class ConversionControllerTest
    {
        /// <summary>
        /// Test Method to validate the number conversion in hundreds
        /// </summary>
        [TestMethod]
        public void ConvertNumberHundreds()
        {
            ConversionController controller = new ConversionController();
            decimal inputNumber = 123.45M;
            string expectedOutput = "one hundred and twenty-three dollars and forty-five cents";

            string result = controller.ConvertToWords(inputNumber);

            // Assert if the result is NULL
            Assert.IsNotNull(result);

            // Assert if the result is not equal to input value
            Assert.AreNotEqual(inputNumber, result);

            // Asset if the result matches the expected output
            Assert.AreEqual(expectedOutput, result);
        }

        /// <summary>
        /// Test Method to validate the number conversion in Thousands
        /// </summary>
        [TestMethod]
        public void ConvertNumberThousands()
        {
            ConversionController controller = new ConversionController();
            decimal inputNumber = 23561.89M;
            string expectedOutput = "twenty-three thousand five hundred and sixty-one dollars and eighty-nine cents";

            string result = controller.ConvertToWords(inputNumber);

            // Assert if the result is NULL
            Assert.IsNotNull(result);

            // Assert if the result is not equal to input value
            Assert.AreNotEqual(inputNumber, result);

            // Asset if the result matches the expected output
            Assert.AreEqual(expectedOutput, result);
        }

        /// <summary>
        /// Test Method to validate the number conversion in Millions
        /// </summary>
        [TestMethod]
        public void ConvertNumberMillions()
        {
            ConversionController controller = new ConversionController();
            decimal inputNumber = 1234561.89M;
            string expectedOutput = "one million two hundred and thirty-four thousand five hundred and sixty-one dollars and eighty-nine cents";

            string result = controller.ConvertToWords(inputNumber);

            // Assert if the result is NULL
            Assert.IsNotNull(result);

            // Assert if the result is not equal to input value
            Assert.AreNotEqual(inputNumber, result);

            // Asset if the result matches the expected output
            Assert.AreEqual(expectedOutput, result);
        }

        /// <summary>
        /// Test Method to validate the number conversion for a input of Zero
        /// </summary>
        [TestMethod]
        public void ConvertNumberZero()
        {
            ConversionController controller = new ConversionController();
            decimal inputNumber = 0.0M;
            string expectedOutput = "zero";

            string result = controller.ConvertToWords(inputNumber);

            // Assert if the result is NULL
            Assert.IsNotNull(result);

            // Assert if the result is not equal to input value
            Assert.AreNotEqual(inputNumber, result);

            // Asset if the result matches the expected output
            Assert.AreEqual(expectedOutput, result);
        }

        /// <summary>
        /// Test Method to validate the number conversion for a number less than One
        /// </summary>
        [TestMethod]
        public void ConvertNumberLessThanOne()
        {
            ConversionController controller = new ConversionController();
            decimal inputNumber = 0.2M;
            string expectedOutput = "zero dollars and twenty cents";

            string result = controller.ConvertToWords(inputNumber);

            // Assert if the result is NULL
            Assert.IsNotNull(result);

            // Assert if the result is not equal to input value
            Assert.AreNotEqual(inputNumber, result);

            // Asset if the result matches the expected output
            Assert.AreEqual(expectedOutput, result);
        }

        /// <summary>
        /// Test Method to validate the number conversion for a negative number
        /// </summary>
        [TestMethod]
        public void ConvertNegativeNumber()
        {
            ConversionController controller = new ConversionController();
            decimal inputNumber = -123.45M;
            string expectedOutput = "minus one hundred and twenty-three dollars and forty-five cents";

            string result = controller.ConvertToWords(inputNumber);

            // Assert if the result is NULL
            Assert.IsNotNull(result);

            // Assert if the result is not equal to input value
            Assert.AreNotEqual(inputNumber, result);

            // Asset if the result matches the expected output
            Assert.AreEqual(expectedOutput, result);
        }
    }
}
