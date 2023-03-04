namespace ConsoleEx2.ControlFlow;

public class GuessTheNumber
{
    public void PickARandomNumber()
    {
        const int chance = 4;
        var random = new Random().Next(1,10);
        
        // display random number in console for testing
        Console.WriteLine($"Secret Number is {random}");

        Console.WriteLine("Please guess the random number between 1 and 10. You will get 4 chances to guess.");

        for (var i = 1; i <= chance; i++)
        {
            var input = Convert.ToInt16(Console.ReadLine());
            if (input == random)
            {
                Console.WriteLine("You Won ! :)");
                return;
            }

            Console.WriteLine(i == 4
                ? "You have exceeded maximum attempts."
                : $"You guessed the wrong number. {chance - i} attempts left. Try again.");
        }
        
        Console.WriteLine("You Lost ! :(");
        Console.WriteLine("Better luck next time.");
    }
}