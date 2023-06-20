using System;

class Calculator
{
    static void Main(string[] args)
    {
        if (args.Length != 3)
        {
            Console.WriteLine("error");
            return;
        }

        string operation = args[0];
        double num1 = double.Parse(args[1]);
        double num2 = double.Parse(args[2]);

        double result = 0;

        if (operation == "add")
        {
            result = num1 + num2;
        }

        else if (operation == "subtract")
        {
            result = num1 - num2;
        }

        else if (operation == "multiply")
        {
            result = num1 * num2;
        }

        else if (operation == "divide")
        {
            result = num1 / num2;
        }

        else
        {
            Console.WriteLine("error");
            return;
        }

        Console.WriteLine("The answer is: " + result);
    }
}