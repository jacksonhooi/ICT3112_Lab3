using Lab2;

public class CalculatorTests
{

    private Calculator _calculator;
  
    [SetUp]
    public void Setup()
    {
        // Arrange
        _calculator = new Calculator();

    }
    [Test]
    public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
    {
        // Act
        double result = _calculator.Add(10, 20);
        // Assert
        Assert.That(result, Is.EqualTo(30));
    }
    [Test]
    public void Add_WhenAddingZero_ResultEqualToOtherNumber()
    {
        // Act
        double result1 = _calculator.Add(0, 5);
        double result2 = _calculator.Add(5, 0);
        // Assert
        Assert.That(result1, Is.EqualTo(5));
        Assert.That(result2, Is.EqualTo(5));
    }
    [Test]
    public void Add_WhenAddingNegativeNumbers_ResultEqualToSum()
    {
        // Act
        double result = _calculator.Add(-10, -20);
        // Assert
        Assert.That(result, Is.EqualTo(-30));
    }

    [Test]
    [TestCase(0, 0)]
    public void Divide_WithZeroZeroAsInputs_Result(double a, double b)
    {
        // Act
        double result = _calculator.Divide(a, b);
        // Assert
        Assert.That(result, Is.EqualTo(1));

    }
    [Test]
    [TestCase(0, 10)]
    public void Divide_WithFirstZerosAsInputs(double a, double b)
    {
        // Act
        double result = _calculator.Divide(a, b);
        // Assert
        Assert.That(result, Is.EqualTo(0));

    }
    [Test]
    [TestCase(10, 0)]
    public void Divide_WithSecZerosAsInputs(double a, double b)
    {
        // Act
        double result = _calculator.Divide(a, b);
        // Assert
        Assert.That(result, Is.EqualTo(double.PositiveInfinity));

    }

    [Test]
    public void Divide_WhenDividingNegativeNumbers_ResultIsCorrect()
    {
        // Act
        double result = _calculator.Divide(-10, -2);
        // Assert
        Assert.That(result, Is.EqualTo(5));
    }



    [Test]
    public void Multiply_WhenMultiplyingByZero_ResultIsZero()
    {
        // Act
        double result = _calculator.Multiply(10, 0);
        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Multiply_WhenMultiplyingNegativeNumbers_ResultIsCorrect()
    {
        // Act
        double result = _calculator.Multiply(-10, 2);
        // Assert
        Assert.That(result, Is.EqualTo(-20));
    }

    [Test]
    public void Factorial_WhenCalculatingFactorialOfPositiveNumber_ResultIsCorrect()
    {
        // Act
        long result = _calculator.Factorial(5);
        // Assert
        Assert.That(result, Is.EqualTo(120));
    }

    [Test]
    public void Factorial_WhenCalculatingFactorialOfZero_ResultIsOne()
    {
        // Act
        long result = _calculator.Factorial(0);
        // Assert
        Assert.That(result, Is.EqualTo(1)); // 0! = 1
    }

    [Test]
    public void Factorial_WhenCalculatingFactorialOfNegativeNumber_ThrowsArgumentException()
    {
        // Act & Assert
        Assert.Throws<ArgumentException>(() => _calculator.Factorial(-1));
    }

    [Test]
    public void CalculateTriangleArea_WithPositiveHeightAndBase_ReturnsCorrectArea()
    {
        // Act
        double result = _calculator.TriangleArea(10, 5);

        // Assert
        Assert.That(result, Is.EqualTo(25));
    }

    [Test]
    public void CalculateTriangleArea_WithZeroHeight_ReturnsZeroArea()
    {
        // Act
        double result = _calculator.TriangleArea(0, 5);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }
    [Test]
    public void CalculateCircleArea_WithPositiveRadius_ReturnsCorrectArea()
    {
        // Act
        double result = _calculator.CircleArea(5);

        // Assert
        Assert.That(result, Is.EqualTo(Math.PI * 5 * 5).Within(0.0001));
    }

    [Test]
    public void CalculateCircleArea_WithZeroRadius_ReturnsZeroArea()
    {
        // Act
        double result = _calculator.CircleArea(0);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void UnknownFunctionA_WhenGivenTest0_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionA(5, 5);
        // Assert
        Assert.That(result, Is.EqualTo(120));
    }
    [Test]
    public void UnknownFunctionA_WhenGivenTest1_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionA(5, 4);
        // Assert
        Assert.That(result, Is.EqualTo(120));
    }
    [Test]
    public void UnknownFunctionA_WhenGivenTest2_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionA(5, 3);
        // Assert
        Assert.That(result, Is.EqualTo(60));
    }

    [Test]
    public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
    {
        // Act
        // Assert
        Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
    }
    [Test]
    public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
    {
        // Act
        // Assert
        Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
    }

    [Test]
    public void UnknownFunctionB_WhenGivenTest0_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionB(5, 5);
        // Assert
        Assert.That(result, Is.EqualTo(1));
    }
    [Test]
    public void UnknownFunctionB_WhenGivenTest1_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionB(5, 4);
        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
    [Test]
    public void UnknownFunctionB_WhenGivenTest2_Result()
    {
        // Act
        double result = _calculator.UnknownFunctionB(5, 3);
        // Assert
        Assert.That(result, Is.EqualTo(10));
    }
    [Test]
    public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
    {
        // Act
        // Assert
        Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
    }
    [Test]
    public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
    {
        // Act
        // Assert
        Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
    }

    [Test]
    public void GenMagicNum_WhenValidInput_ReturnsCorrectMagicNumber()
    {
        // Arrange
        double input = 0;
        IFileReader fileReader = new FileReader();  
                                                    // Act
        double result = _calculator.GenMagicNum(input, fileReader);
        // Assert
        Assert.That(result, Is.EqualTo(24));
    }

    [Test]
    public void GenMagicNum_WhenInputOutOfBounds_ReturnsNegativeDoubleOfLastMagicNumber()
    {
        // Arrange
        double input = 10;
        IFileReader fileReader = new FileReader();

        // Act
        double result = _calculator.GenMagicNum(input, fileReader);

        // Assert
        Assert.That(result, Is.EqualTo(-0.0)); 
    }

    [Test]
    public void GenMagicNum_WhenInputIsNegative_ReturnsNegativeDoubleOfFirstMagicNumber()
    {
        // Arrange
        double input = -1;
        IFileReader fileReader = new FileReader();

        // Act
        double result = _calculator.GenMagicNum(input, fileReader);

        // Assert
        Assert.That(result, Is.EqualTo(-0.0));
    }

    [Test]
    public void GenMagicNum_WhenInputIsFloatingPointNumber_TruncatesToNearestInteger()
    {
        // Arrange
        double input = 2.9;
        IFileReader fileReader = new FileReader();

        // Act
        double result = _calculator.GenMagicNum(input, fileReader);

        // Assert
        Assert.That(result, Is.EqualTo(156.0)); 
    }

}