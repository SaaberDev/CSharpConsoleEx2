using ConsoleEx2.ControlFlow;

Console.Write(@"1. Count Division By Number
2. Sum Of Previously Entered Numbers
3. Compute Factorial Number
4. Guess The Number
5. Find The Maximum Number
");
Console.WriteLine("=============================");
Console.WriteLine("Please choose a program between 1 and 5.");

var program = Convert.ToInt16(Console.ReadLine());

switch (program)
{
    case 1:
        Console.WriteLine("=============================");
        Console.WriteLine("Program 1: Count Division By Number");
        // ask user a number and count how many numbers between 1 and 100 are divisible by the given number
        (new CountDivisionByNumber()).CountDividable();
    break;
    
    case 2:
        Console.WriteLine("=============================");
        Console.WriteLine("Program 2: Sum of Previously Entered Numbers");
        // continuously ask the user to enter a number, when done type "ok" to exit.
        // calculate the sum of all the previously entered numbers and display it on the console.
        (new SumOfPreviousNumber()).SumPreviousNumbers();
    break;
    
    case 3:
        Console.WriteLine("=============================");
        // ask the user to enter a number.
        // compute the factorial of the given number.
        Console.WriteLine("Program 3: Compute Factorial Number");
        (new ComputeFactorial()).GetFactorial();
    break;
    
    case 4:
        Console.WriteLine("=============================");
        Console.WriteLine("Program 4: Guess The Number");
        // user need to guess a number to win the game, if user guess wrong number user will lose.
        // user will get 4 chances to guess the number.
        // note that, for experiment testing purpose random generated number will be displayed in the console.
        (new GuessTheNumber()).PickARandomNumber();
        break;
    
    case 5:
        Console.WriteLine("=============================");
        Console.WriteLine("Program 5: Find The Maximum Number");
        // ask the user to enter a series of numbers separated by comma.
        // program will find the maximum number from the series of numbers.
        (new FindMaximumNumber()).GetMaxNumber();
        break;
    
    default:
        Console.WriteLine("You did not choose any program.");
        break;
}