using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            // Arrange - create a new Mock<IFileReader> and set up the Read method
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr => fr.Read("MagicNumbers.txt"))
                           .Returns(new string[2] { "42", "42" }); // Simulating file content

            // Instantiate the Calculator
            _calculator = new Calculator();
        }

        [Test]
        public void GenMagicNum_WhenValidInput_ReturnsCorrectMagicNumber()
        {
            // Arrange
            double input = 0; // This corresponds to the first magic number (42)

            // Act
            double result = _calculator.GenMagicNum(input, _mockFileReader.Object);

            // Assert
            Assert.That(result, Is.EqualTo(84)); // 2 * 42 = 84
        }

        [Test]
        public void GenMagicNum_WhenInputOutOfBounds_ReturnsNegativeDoubleOfLastMagicNumber()
        {
            // Arrange
            double input = 10; // Out of bounds input
            

            // Act
            double result = _calculator.GenMagicNum(input, _mockFileReader.Object);

            // Assert
            Assert.That(result, Is.EqualTo(-0.0)); 
        }

        [Test]
        public void GenMagicNum_WhenInputIsNegative_ReturnsNegativeDoubleOfFirstMagicNumber()
        {
            // Arrange
            double input = -1;

            // Act
            double result = _calculator.GenMagicNum(input, _mockFileReader.Object);

            // Assert
            Assert.That(result, Is.EqualTo(-0.0)); 
        }

        [Test]
        public void GenMagicNum_WhenInputIsFloatingPointNumber_TruncatesToNearestInteger()
        {
            // Arrange
            double input = 0.9;

            // Act
            double result = _calculator.GenMagicNum(input, _mockFileReader.Object);

            // Assert
            Assert.That(result, Is.EqualTo(84));
        }
    }
}
