using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Empty string!");
            return;
        }

        string result = "";
        char previousChar = input[0];
        result += previousChar;

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != previousChar)
            {
                result += input[i];
                previousChar = input[i];
            }
        }

        Console.WriteLine("Results: " + result);
    }
}