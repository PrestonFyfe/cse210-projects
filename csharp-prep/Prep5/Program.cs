using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string userName = PromptUserName();

        int squaredNumber = PromptUserNumber();

        int birthYear; 
        PromptUserBirthYear(out birthYear);

        DisplayResult(userName, birthYear, squaredNumber);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        int square = number * number;

        return square;
    }

    static void DisplayResult(string name, int birthYear, int square)
    {
        int age = 2026 - birthYear;
        Console.WriteLine($"{name}, the square of your number is {square}");
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }
}