using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create individual shapes and test them
        Square square = new Square("Red", 5);
        Console.WriteLine($"Square: Color = {square.GetColor()}, Area = {square.GetArea()}");

        Rectangle rectangle = new Rectangle("Blue", 4, 6);
        Console.WriteLine($"Rectangle: Color = {rectangle.GetColor()}, Area = {rectangle.GetArea()}");

        Circle circle = new Circle("Green", 3);
        Console.WriteLine($"Circle: Color = {circle.GetColor()}, Area = {circle.GetArea()}");

        Console.WriteLine("\nNow using polymorphism with a list of shapes:\n");

        // Create a list of shapes
        List<Shape> shapes = new List<Shape>();
        
        // Add different shapes to the list
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);
        shapes.Add(new Square("Yellow", 2));
        shapes.Add(new Rectangle("Purple", 3, 7));
        shapes.Add(new Circle("Orange", 4));

        // Iterate through the list and display each shape's color and area
        int count = 1;
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape {count}: Type = {shape.GetType().Name}, Color = {shape.GetColor()}, Area = {shape.GetArea()}");
            count++;
        }
    }
}