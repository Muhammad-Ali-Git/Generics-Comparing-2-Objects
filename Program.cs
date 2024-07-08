// See https://aka.ms/new-console-template for more information
using System;

class Ali
{
    public static void Main()
    {
        Console.WriteLine("This program compares two objects with the use of Generics.");
        Console.WriteLine("\n-------------------------------------------------------\n");

        START:
        Console.WriteLine("So do you want to compare two strings or numbers? (strings/numbers)");
        string obj = Console.ReadLine().ToLower();

        Console.WriteLine("\n-------------------------------------------------------\n");

        if(obj == "strings")
        {
            Console.WriteLine("Remember that strings will be compared based on their ASCII Codes.");
            Console.WriteLine("Enter first string: ");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter second string: ");
            string str2 = Console.ReadLine();

            Comparator.Comparison <string>(str1, str2);
        }
        else if(obj == "numbers")
        {
            Console.WriteLine("Enter first number: ");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter second string: ");
            float num2 = float.Parse(Console.ReadLine());

            Comparator.Comparison <float>(num1, num2);
        }
        else
        {
            Console.WriteLine("Wrong Input! Please Try Again!");
            Console.WriteLine("\n-------------------------------------------------------\n");
            goto START;
        }
    }
}

public class Comparator
{
    public static void Comparison<T>(T x, T y) where T : IComparable<T> // Using T as Generic here
    {
        int result = x.CompareTo(y);

        if (result > 0)
        {
            Console.WriteLine("{0} is Greater than {1}", x, y);
        }
        else if (result == 0)
        {
            Console.WriteLine("{0} is Equal to {1}", x, y);
        }
        else
        {
            Console.WriteLine("{0} is Less than {1}", x, y);
        }
    }
}