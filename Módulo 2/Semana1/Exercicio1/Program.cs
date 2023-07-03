using System;
internal class Program
{
  private static void Main(string[] args)
  {
    int firstNumber;
    int secondNumber;
    int sum;

    Console.WriteLine("Informe o primeiro número:");
    firstNumber = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o segundo número:");
    secondNumber = int.Parse(Console.ReadLine());

    sum = firstNumber + secondNumber;

    Console.WriteLine("A soma dos números é " + sum + " .");
  }
}