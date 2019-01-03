using System;
using System.Collections.Generic;

namespace IronNinja
{
    public class Sensei : Human, IConsumable
    {
        public Sensei() : base(){}

        public override bool isFull
        {
            get{ return calorieIntake >= 1500; }
        }

        public void Eat(Food item)
        {
            if(!isFull)
            {
                Console.WriteLine($"Sensei quickly eats some delicious {item.Name}.");
                calorieIntake += item.Calories;
                foodHistory.Add(item);
            }
            else
            {
                Console.WriteLine($"Sensei is too full to eat anymore.");
            }
        }
    }
}