using ConsoleApp2;

namespace TestProject1;

public class Tests
{
    [Test]
    public void Test1()
    {
        var decimalNumber = 0;
        var expectedBinary = "0";
        var actualBinary = NumberConverter.DecimalToBinary(decimalNumber);
        Assert.That(actualBinary, Is.EqualTo(expectedBinary));
    }
    
    [Test]
    public void TestDecimalToBinary_Ten_ExpectedOneZeroOneZeroOneZero()
    {
        var decimalNumber = 10;
        var expectedBinary = "1010";
        var actualBinary = NumberConverter.DecimalToBinary(decimalNumber);
        Assert.That(actualBinary, Is.EqualTo(expectedBinary));
    }

    [Test]
    public void TestDecimalToBinary_NegativeOne_ExpectedNegativeBinary()
    {
        var decimalNumber = -1;
        var expectedBinary = String.Empty;
        var actualBinary = NumberConverter.DecimalToBinary(decimalNumber);
        Assert.That(actualBinary, Is.EqualTo(expectedBinary));
    }
}