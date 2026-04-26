using System;

class Program
{
    static void Main(string[] args)
    {
        string letter;
        Console.Write("What is your current grade percentage? ");
        string grade_in_text = Console.ReadLine();
        float grade_percent = float.Parse(grade_in_text);

        if (grade_percent >= 90)
        {
            letter = "A";
        }
        else if (grade_percent >= 80) 
        {
            letter = "B";
        }
        else if (grade_percent >= 70)
        {
            letter = "C";
        }
        else if (grade_percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }  
        Console.WriteLine($"You got an {letter}");

        if (grade_percent >= 70)
        {
            Console.WriteLine("Congrats! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't pass :(");
        }
    }
}