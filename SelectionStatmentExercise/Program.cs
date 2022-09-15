

using System.Reflection.Metadata;


var r = new Random();
var favNumber = r.Next(1, 1000);
Console.Write("Guess a number from 1 to 1000: ");
var userInput = int.Parse(Console.ReadLine());

do
{
    
    if (userInput > favNumber)
    {

        Console.WriteLine($"{userInput} is too high!");
        userInput = int.Parse(Console.ReadLine());

    }

    else if (userInput < favNumber)
    {

        Console.WriteLine($"{userInput} is too low!");
        userInput = int.Parse(Console.ReadLine());
    }
} while (userInput!= favNumber);

Console.Clear();
Console.WriteLine($"you guessed it! The answer was {favNumber}");
