// See https://aka.ms/new-console-template for more information
using Opgave4;

Fibonacci fibonacci = new Fibonacci(4000000);

Console.WriteLine($"Sum of even Fibonacci numbers below 4 million: {fibonacci.GetSumOfEvenValues()}");