using System;

namespace IronNinja
{
    public class Drink : Food
    {
        public Drink(string name, int calories) : base(name, calories)
        {
            isSpicy = false;
            isSweet = true;
        }
    }
}