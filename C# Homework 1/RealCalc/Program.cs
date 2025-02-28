Console.WriteLine("Enter first number");
string firstInput = Console.ReadLine();
double firstNum;
double.TryParse(firstInput, out firstNum);

Console.WriteLine("Enter second number");
string secondInput = Console.ReadLine();
double secondNum;
double.TryParse(secondInput, out secondNum);

Console.WriteLine("Enter which operator you'd like to use( +, - , * , / )");

string Operator = Console.ReadLine();

if (Operator == "+")
{
    Console.WriteLine("Result is: " + (firstNum + secondNum));
}
else if (Operator == "-")
{
    Console.WriteLine("Result is: " + (firstNum - secondNum));
}
else if (Operator == "*") 
{
    Console.WriteLine("Result is: " + (firstNum * secondNum));

}
else if (Operator == "/")
{
    Console.WriteLine("Result is: " + (firstNum / secondNum));

} else
{
    Console.WriteLine("Invalid entry");
}
