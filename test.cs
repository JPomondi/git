Console.Write("Enter a number: ");
string? input = Console.ReadLine();

if (!double.TryParse(input, out double number))
{
	Console.WriteLine("That is not a valid number.");
}
else if (number < 0)
{
	Console.WriteLine("This number does not have a real square root.");
}
else
{
	double squareRoot = Math.Sqrt(number);
	Console.WriteLine($"The square root of {number} is {squareRoot}.");
}
