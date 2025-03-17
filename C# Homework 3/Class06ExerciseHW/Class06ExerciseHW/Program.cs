using CarRacing;
using Class06ExerciseHW;
Car[] cars =
{
    new Car("Hyundai", 120),
    new Car("Mazda", 150),
    new Car("Ferrari", 280),
    new Car("Porsche", 260)
};

Driver[] drivers =
{
    new Driver("Bob", 7),
    new Driver("Greg", 8),
    new Driver("Jill", 9),
    new Driver("Anne", 10)
};

bool raceAgain = true;
while (raceAgain)
{
    Console.WriteLine("Choose car1");
    for (int i = 0; i < cars.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {cars[i].Model}");
    }
    int car1Choice = Input(1, cars.Length) - 1;
    Car selectedCar1 = cars[car1Choice];

    Console.WriteLine("Choose driver for car1");
    for (int i = 0; i < drivers.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {drivers[i].Name}");
    }
    int driver1Choice = Input(1, drivers.Length) - 1;
    selectedCar1.Driver = drivers[driver1Choice];

    Console.WriteLine("Choose car2");
    for (int i = 0; i < cars.Length; i++)
    {
        if (i != car1Choice)
        {
            Console.WriteLine($"{i + 1}. {cars[i].Model}");
        }
    }

    int car2Choice;
    do
    {
        car2Choice = Input(1, cars.Length) - 1;
        if (car2Choice == car1Choice)
        {
            Console.WriteLine("Car in use. choose other");
        }
    } while (car2Choice == car1Choice);
    Car selectedCar2 = cars[car2Choice];

    Console.WriteLine("Choose driver for car2");
    for (int i = 0; i < drivers.Length; i++)
    {
        if (i != driver1Choice)
        {
            Console.WriteLine($"{i + 1}. {drivers[i].Name}");
        }
    }

    int driver2Choice;
    do
    {
        driver2Choice = Input(1, drivers.Length) - 1;
        if (driver2Choice == driver1Choice)
        {
            Console.WriteLine("driver in use. choose other");
        }
    } while (driver2Choice == driver1Choice);
    selectedCar2.Driver = drivers[driver2Choice];

    Console.WriteLine("Result:");
    RaceManager.RaceCars(selectedCar1, selectedCar2);

    Console.WriteLine("Continiue? (Y/N)");
    string response = Console.ReadLine().ToUpper();
    raceAgain = (response == "Y");
}

Console.WriteLine("Press anything to exit");
static int Input(int min, int max)
{
    int choice;
    bool isValid = false;
    do
    {
        Console.Write($"Enter a number between {min} and {max}");
        isValid = int.TryParse(Console.ReadLine(), out choice) && choice >= min && choice <= max;
        if (!isValid)
        {
            Console.WriteLine("Invalid input");
        }
    } while (!isValid);
    return choice;
}