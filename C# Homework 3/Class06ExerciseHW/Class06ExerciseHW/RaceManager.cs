namespace CarRacing
{
    public class RaceManager
    {
        public static void RaceCars(Car car1, Car car2)
        {
            double car1Speed = car1.CalculateSpeed();
            double car2Speed = car2.CalculateSpeed();

            if (car1Speed > car2Speed)
            {
                Console.WriteLine($"Car1 was faster.");
                Console.WriteLine($"The {car1.Model} won with speed of {car1Speed} driven by {car1.Driver.Name}");
            }
            else if (car2Speed > car1Speed)
            {
                Console.WriteLine($"Car2 was faster.");
                Console.WriteLine($"The {car2.Model} won with speed of {car2Speed} driven by {car2.Driver.Name}");
            }
            else
            {
                Console.WriteLine("Tie");
            }
        }
    }
}