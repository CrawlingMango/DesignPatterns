using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Pattern.Decorator
{
    public abstract class RestaurantDish
    {
        public abstract void Display();
    }

    public abstract class Decorator : RestaurantDish
    {
        protected RestaurantDish _dish;

        public Decorator(RestaurantDish dish)
        {
            _dish = dish;
        }

        public override void Display()
        {
            _dish.Display();
        }
    }
}
