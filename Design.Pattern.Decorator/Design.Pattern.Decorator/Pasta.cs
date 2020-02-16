using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Pattern.Decorator
{
    class Pasta : RestaurantDish
    {
        private string _pastaType;
        private string _sauce;

        public Pasta(string pastaType, string sauce)
        {
            _pastaType = pastaType;
            _sauce = sauce;
        }

        public override void Display()
        {
            Console.WriteLine("\nClassic Pasta:");
            Console.WriteLine($" Pasta:");
            Console.WriteLine($" Sauce:");
        }
    }
}
