using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Pattern.Decorator
{
    class FreshSalad : RestaurantDish
    {
        private string _greens;
        private string _cheese;
        private string _dressing;

        public FreshSalad(string greens, string cheese, string dressing)
        {
            _greens = greens;
            _cheese = cheese;
            _dressing = dressing;
        }

        public override void Display()
        {
            Console.WriteLine("\nFresh Salad:");
            Console.WriteLine($" Greens: {_greens}");
            Console.WriteLine($" Cheese: {_cheese}");
            Console.WriteLine($" Dressing: {_dressing}");
        }
    }
}
