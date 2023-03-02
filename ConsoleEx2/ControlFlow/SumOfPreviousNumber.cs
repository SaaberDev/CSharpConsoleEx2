namespace ConsoleEx2.ControlFlow;

public class SumOfPreviousNumber
{
    public void SumPreviousNumbers()
    {
        Console.WriteLine("Please enter multiple number. Type \"ok\" when done.");
        var sum = 0;
        while (true)
        {
            Console.WriteLine("Please enter a number.");
            var input = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Empty string or whitespace not allowed.");
            }
            else
            {
                var isNumeric = int.TryParse(input, out var number);
                if (isNumeric)
                {
                    sum += Convert.ToInt32(input);
                }
                else
                {
                    if (input.ToLower() == "ok")
                    {
                        break;
                    }

                    Console.WriteLine($"As string value only \"ok\" is allowed.");
                }
            }
        }

        Console.WriteLine($"Sum of previous numbers are: {sum}");
    }
}