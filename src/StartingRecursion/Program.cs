// See https://aka.ms/new-console-template for more information
using System;

Console.Write("Hello Recursion");

Print(1);

void Print(int nums)
{
    if (nums > 5)
        return;
    Console.WriteLine(nums);
    Print(nums + 1);
}