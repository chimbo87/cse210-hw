using System;

class Program
{
    static void Main(string[] args)
    {
        // Test constructor with no parameters (1/1)
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        // Test constructor with one parameter (5/1)
        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        // Test constructor with two parameters (3/4)
        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        // Test constructor with two parameters (1/3)
        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());
        
        // Test getters and setters
        Console.WriteLine("\nTesting getters and setters:");
        
        // Get and display the current values
        Console.WriteLine($"Current fraction: {fraction3.GetTop()}/{fraction3.GetBottom()}");
        
        // Change the values using setters
        fraction3.SetTop(5);
        fraction3.SetBottom(8);
        
        // Get and display the new values
        Console.WriteLine($"New fraction: {fraction3.GetTop()}/{fraction3.GetBottom()}");
        Console.WriteLine($"New fraction string: {fraction3.GetFractionString()}");
        Console.WriteLine($"New decimal value: {fraction3.GetDecimalValue()}");
    }
}