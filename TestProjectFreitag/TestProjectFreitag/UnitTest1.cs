namespace TestProjectFreitag;

public class UnitTest1
{

    
    
    [Fact]
    public void ConstructorTest_EmptyConstructor_NoException()
    {
        FizzBuzz fizzbuzz = new FizzBuzz();
    }

    [Fact]
    public void RunTest_Input3_ExpectsFizz()
    {
        FizzBuzz fizzBuzz = new FizzBuzz();
        int input = 3;
        string expected = "Fizz";

        string actual = fizzBuzz.Run(input);
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void RunTest_Input5_ExpectsBuzz()
    {
        FizzBuzz fizzBuzz = new FizzBuzz();
        int input = 5;
        string expected = "Buzz";

        string actual = fizzBuzz.Run(input);
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void RunTest_Input15_ExpectsFizzBuzz()
    {
        FizzBuzz fizzBuzz = new FizzBuzz();
        int input = 15;
        string expected = "FizzBuzz";

        string actual = fizzBuzz.Run(input);
        
        Assert.Equal(expected, actual);
    }

    [Theory]
    [MemberData(nameof(InputStuff))]
    public void TheoryTest(int input)
    {
        FizzBuzz fizzBuzz = new FizzBuzz();
        string expected = input.ToString();

        string actual = fizzBuzz.Run(input);
        
        Assert.Equal(expected, actual);
    }


    public static IEnumerable<object[]> InputStuff()
    {
        yield return new object[] {1};
        yield return new object[] {2};
        yield return new object[] {4};
        yield return new object[] {7};
        yield return new object[] {8};
        yield return new object[] {11};
        yield return new object[] {13};
        yield return new object[] {14};
        yield return new object[] {16};
        yield return new object[] {17};
        yield return new object[] {19};
        yield return new object[] {22};
        yield return new object[] {23};
        yield return new object[] {26};
    }
}