using System.ComponentModel.Design;

string[] studentsG1 = {"Zdravko", "Petko", "Stanko", "Branko", "Trajko"};
string[] studentsG2 = {"Bobi", "Toni", "Dzoni", "Doni", "Ime5neznam"};

Console.WriteLine("Choose student group (1 / 2)");
int choice;
int.TryParse(Console.ReadLine(), out choice);
if (choice == 1)
{
    Console.WriteLine("Students of g1 are: ");
    foreach (string student in studentsG1)
    {
        Console.WriteLine(student);
    }
}
else if (choice == 2)
{
    Console.WriteLine("Students of g2 are: ");
    {
        foreach(string student in studentsG2)
        {
            Console.WriteLine(student);
        }
    }
}
else
{
    Console.WriteLine("invalid");
}