namespace TestProjectFreitag;

public class UnitTest1
{

    [Fact]
    public void ConstructorTest_EmptyConstructor_NoException()
    {
        FizzBuzz fizzbuzz = new FizzBuzz();
    }

    [Fact]
    public void RunTest_Input1_Expects1()
    {
        FizzBuzz fizzBuzz = new FizzBuzz();
        int input = 1;
        string expected = "1";

        string actual = fizzBuzz.Run(input);
        
        Assert.Equal(actual, expected);
    }
}