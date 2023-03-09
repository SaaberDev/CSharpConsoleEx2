using System.Text.RegularExpressions;

namespace ConsoleEx2.ControlFlow;

public class FindMaximumNumber
{
    public void GetMaxNumber()
    {
        AskQuestion:
        Console.WriteLine("Please enter a series of numbers separated by comma.");
        
        var input = Console.ReadLine();
        
        if (!string.IsNullOrWhiteSpace(input))
        {
            var isMatched = Regex.IsMatch(input, "^([0-9]*)+(,[0-9]+)+$");
            if (!isMatched)
            {
                Console.WriteLine("You probably forgot to add comma or ended with a comma. Please check and try again. i.e. 1,2,3");
                goto AskQuestion;
            }

            var inputAsArray = input.Split(",");
                
            // Way - 1: Convert string array to int array and directly grab max value from array
            // var numbers = Array.ConvertAll(inputAsArray, int.Parse);
            // var max = numbers.Max();
                
            // Way - 2: use loop to find max value
            var max = Convert.ToInt32(inputAsArray[0]);
            foreach (var value in inputAsArray)
            {
                var number = Convert.ToInt32(value);
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"The max number is {max}");
        }
        else
        {
            Console.WriteLine("You did not provide any numbers !!");
            goto AskQuestion;
        }
    }
}