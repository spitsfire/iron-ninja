using System;
using System.Collections.Generic;

namespace IronNinja
{
    public abstract class Human
    {
        public int calorieIntake;
        public List<Food> foodHistory;

        public Human()
        {
            calorieIntake = 0;
            foodHistory = new List<Food>();
        }
        public abstract bool isFull;
    }
}