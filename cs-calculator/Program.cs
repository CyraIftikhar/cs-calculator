﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter Operator: ");
string op = Console.ReadLine();

Console.WriteLine("Enter another number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

if (op == "+")
{
    Console.WriteLine(num1 + num2);
} else if (op == "-")
{
    Console.WriteLine(num1 - num2);
} else if (op == "/")
{ Console.WriteLine(num1 / num2);
}
else if (op == "*")
{ Console.WriteLine(num1 * num2);
}
Console.ReadLine();