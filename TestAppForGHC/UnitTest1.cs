namespace TestAppForGHC;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Factorials()
    {
        Assert.That(1, Is.EqualTo(Program.Factorial(1)));
        Assert.That(1 * 2, Is.EqualTo(Program.Factorial(2)));
        Assert.That(1 * 2 * 3, Is.EqualTo(Program.Factorial(6)));
        Assert.That(1 * 2 * 3 * 4, Is.EqualTo(Program.Factorial(24)));
        Assert.That(1 * 2 * 3 * 4 * 5, Is.EqualTo(Program.Factorial(120)));
        Assert.That(1 * 2 * 3 * 4 * 5 * 6, Is.EqualTo(Program.Factorial(720)));
    }

    [Test]
    public void Multiplys()
    {
        Assert.That(-1 * -1, Is.EqualTo(Program.Multiply(-1, -1)));
        Assert.That(-1 * 10, Is.EqualTo(Program.Multiply(-1, -10)));
        Assert.That(2 * 2, Is.EqualTo(Program.Multiply(2, 2)));
    }
}