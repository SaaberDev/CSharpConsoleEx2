﻿using ConsoleEx2.ControlFlow;

Console.WriteLine("Please choose a program between 1 and 4.");

var program = Convert.ToInt16(Console.ReadLine());

switch (program)
{
    case 1:
        (new CountDivisionByNumber()).CountDividable();
    break;
    
    case 2:
        (new SumOfPreviousNumber()).SumPreviousNumbers();
    break;
    
    default:
        Console.WriteLine("You did not choose any program.");
        break;
}