namespace ConsoleEx2.ControlFlow;

public class CountDivisionByNumber
{
    public void CountDividable()
    {
        Console.WriteLine("Type a number to see how many times it can be divided by that number between 1 and 100.");
        var provability = 0;
        var range = MyArray(100);
        var number = Convert.ToInt16(Console.ReadLine());
        
        foreach (var value in range)
        {
            if (value % number == 0)
            {
                provability += 1;
            }
        }
        
        Console.WriteLine($"Numbers between 1 and 100 can be divided by {number} in total ({provability}) times");
    }

    private static int[] MyArray(int range)
    {
        var array = new int[range];
        for (var i = 0; i < array.Length; i++)
        {
            array[i] = i;
        }

        return array;
    }
}