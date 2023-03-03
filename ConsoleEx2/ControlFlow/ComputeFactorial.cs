using System.Numerics;

namespace ConsoleEx2.ControlFlow;

public class ComputeFactorial
{
    public void GetFactorial()
    {
        Console.WriteLine("Please enter a number.");
        var input = Convert.ToInt16(Console.ReadLine());

        dynamic factorial = 1;
        if (input > 33) factorial = new BigInteger(factorial);

        for (var i = 1; i <= input; i++) factorial *= i;

        Console.WriteLine($"{input}! = {factorial}, (Factorial of {input} is {factorial})");
    }
}