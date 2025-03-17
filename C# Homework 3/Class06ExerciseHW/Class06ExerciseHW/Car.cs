﻿using Class06ExerciseHW;
namespace CarRacing
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public double CalculateSpeed()
        {
            if (Driver == null)
                return 0;

            return Driver.Skill * Speed;
        }
    }
}