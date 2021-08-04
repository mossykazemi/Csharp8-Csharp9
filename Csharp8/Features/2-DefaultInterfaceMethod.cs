using System;

namespace CSharp8.Features
{
    public interface IShoppingCart
    {
        public static void SetDefaultName(string name)
        {
            defaultName = name;
        }

        private static string defaultName = "default";


        void CalculateTotalPrice();

        void CalculateTotalPriceWithTax()
        {
            Console.WriteLine($"this is {defaultName} calculated total price with tax");
        }
    }

    public class ShoppingCart : IShoppingCart
    {
        public void CalculateTotalPrice()
        {
            Console.WriteLine("this is default calculated total price");
        }
    }

    public class BetterShoppingCart : IShoppingCart
    {
        public BetterShoppingCart()
        {
            IShoppingCart.SetDefaultName("better shopping cart name");
        }


        public void CalculateTotalPrice()
        {
            Console.WriteLine("this is calculated total price");
        }

        /*public void CalculateTotalPriceWithTax()
        {
            Console.WriteLine("this is default calculated total price with tax, override");
        }*/
    }
}
