using ConsoleApp2;

namespace TestProject2;

public class Tests
{
    [Test]
    public void TestIsEven_Zero_ExpectedTrue()
    {
        var number = 0;
        var expectedResult = true;
        var actualResult = EvennessChecker.IsEven(number);
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsEven_Two_ExpectedTrue()
    {
        var number = 2;
        var expectedResult = true;
        var actualResult = EvennessChecker.IsEven(number);
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    
    [Test]
    public void TestIsEven_Three_ExpectedFalse()
    {
        var number = 2;
        var expectedResult = true;
        var actualResult = EvennessChecker.IsEven(number);
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}