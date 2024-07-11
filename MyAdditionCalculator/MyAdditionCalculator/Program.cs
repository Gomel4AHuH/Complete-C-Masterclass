using System.Globalization;

Console.WriteLine("Enter the first number:");

double firstNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"The first number is {firstNumber.ToString(CultureInfo.InvariantCulture)}");

Console.WriteLine("Enter the second number:");

double secondNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double sum = firstNumber + secondNumber;

Console.WriteLine($"The second number is {secondNumber.ToString(CultureInfo.InvariantCulture)}");

Console.WriteLine($"The sum of" +
    $" {firstNumber.ToString(CultureInfo.InvariantCulture)} and" +
    $" {secondNumber.ToString(CultureInfo.InvariantCulture)} is" +
    $" {sum.ToString(CultureInfo.InvariantCulture)}", CultureInfo.InvariantCulture);

Console.ReadKey();
