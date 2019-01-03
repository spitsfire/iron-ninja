using System;
using System.Collections.Generic;

namespace IronNinja
{
    public class Ninja : Human, IConsumable
    {
        public Ninja() : base(){}

        public override bool isFull
        {
            get{ return calorieIntake >= 1200; }
        }
        public void Eat(Food item)
        {
            if(!isFull && !foodHistory[foodHistory.Count-1].isSpicy)
            {
                if(item.isSweet && !item.isSpicy)
                {
                    Console.WriteLine($"Yum! Ninja digs in to some sweet {item.Name}.");
                    calorieIntake += Convert.ToInt32(item.Calories * .25);
                }
                else if(item.isSpicy)
                {
                    Console.WriteLine($"Woah, that {item.Name} is spicy. Ninja needs something to drink next!");
                    calorieIntake += item.Calories;
                }
                else
                {
                    Console.WriteLine($"Ninja digs in to some delicious {item.Name}.");
                    calorieIntake += item.Calories;
                }
                foodHistory.Add(item);
            }
            else if(!isFull && foodHistory[foodHistory.Count-1].isSpicy)
            {
                if(item is Drink)
                {
                    Console.WriteLine($"Ninja gulps down that soothing {item.Name}.");
                    calorieIntake += item.Calories;
                    foodHistory.Add(item);
                }
                else
                {
                    Console.WriteLine($"That's not a drink! Ninja needs a drink in order to continue.");
                }
            }
            else
            {
                Console.WriteLine("Ninja is too full to eat anymore!");
            }
        }

    }
}