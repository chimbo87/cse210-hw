using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Enter your grade percentage: ");
        string userInput = Console.ReadLine();


        int percentage = int.Parse(userInput);


        string letter;
        string sign = "";


        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        int lastDigit = percentage % 10;


        if (letter == "F")
        {

            sign = "";
        }
        else if (letter == "A" && lastDigit >= 7)
        {

            sign = "";
        }
        else
        {

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }


        Console.WriteLine($"Your grade is: {letter}{sign}");


        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep working hard. You'll do better next time!");
        }
    }
}