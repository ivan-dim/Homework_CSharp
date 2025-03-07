int[] numbers = new int[6];

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("Enter num" + (i+1) + ":");
    int.TryParse(Console.ReadLine(), out numbers[i]);
}

int sumOfEven = 0;
foreach(int number in numbers)
{
    if (number % 2 == 0)
    {
        sumOfEven += number;
    }
}

Console.WriteLine("Res is " + sumOfEven);