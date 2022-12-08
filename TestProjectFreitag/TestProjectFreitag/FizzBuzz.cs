namespace TestProjectFreitag;

public class FizzBuzz
{
    public FizzBuzz()
    {
        
    }

    public string Run(int input)
    {
        string fizzBuzzString = "";
        if (input % 3 == 0)
        {
            fizzBuzzString += "Fizz";
        }

        if (input % 5 == 0)
        {
            fizzBuzzString += "Buzz";
        }

        if (fizzBuzzString.Equals(""))
        {
            fizzBuzzString += input.ToString();
        }

        return fizzBuzzString;
    }
}