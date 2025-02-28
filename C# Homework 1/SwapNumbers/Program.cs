Console.WriteLine("Enter first number");
int firstNumber;
int.TryParse(Console.ReadLine(), out firstNumber);

Console.WriteLine("Enter second number");
int secondNumber;
int.TryParse(Console.ReadLine(), out secondNumber);

(firstNumber, secondNumber) = (secondNumber, firstNumber);

Console.WriteLine($"Now first one is {firstNumber} and second one is {secondNumber}");