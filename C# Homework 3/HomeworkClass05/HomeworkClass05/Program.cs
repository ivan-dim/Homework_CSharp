Console.WriteLine("Enter DoB(yr-mo-day");
if (DateTime.TryParse(Console.ReadLine(), out DateTime birthDate))
{
    int age = AgeCalc(birthDate);
    Console.WriteLine($"You're {age} yrs old");
}
else
{
    Console.WriteLine("Invalid input");
}

int AgeCalc(DateTime birthDate)
{
    DateTime today = DateTime.Today;
    int age = today.Year - birthDate.Year;

    if(birthDate.Date > today.AddYears(-age))
    {
        age--;
    }
    return age;
}