using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       
        List<int> numbers = new List<int>();
        
      
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int number;
        bool validInput;
        
        do
        {
       
            Console.Write("Enter number: ");
            validInput = int.TryParse(Console.ReadLine(), out number);
            
            if (!validInput)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }
            
       
            if (number != 0)
            {
                numbers.Add(number);
            }
            
        } while (number != 0);
        
 
        if (numbers.Count > 0)
        {
            
            
       
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine($"The sum is: {sum}");
            
        
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");
            
        
            int largest = numbers[0];
            foreach (int num in numbers)
            {
                if (num > largest)
                {
                    largest = num;
                }
            }
            Console.WriteLine($"The largest number is: {largest}");
            
         
            int smallestPositive = int.MaxValue;
            bool foundPositive = false;
            
            foreach (int num in numbers)
            {
                if (num > 0 && num < smallestPositive)
                {
                    smallestPositive = num;
                    foundPositive = true;
                }
            }
            
            if (foundPositive)
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            }
            else
            {
                Console.WriteLine("There are no positive numbers in the list.");
            }
            
          
            numbers.Sort();
            
            Console.WriteLine("The sorted list is:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}