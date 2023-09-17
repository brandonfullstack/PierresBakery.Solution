using System;
using PierresBakery.Models;
using PierresBakery.UserInterfaceModels;

namespace PierresBakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to");
      Console.WriteLine(WelcomeBanner.Welcome);
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
    
      // Print the prices and specials for bread and pastry
      Console.WriteLine("Bread:  $5 each | Buy 2, get 1 free!");
      Console.WriteLine("Pastry: $2 each | Buy 3, get 1 free!");

      // Prompt the user to enter the quantity of bread and pastry they want
      Console.WriteLine("How many loaves of bread would you like?");
      int breadQuantity = int.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries would you like?");
      int pastryQuantity = int.Parse(Console.ReadLine());

      // Create bread and pastry objects
      Bread bread = new Bread(breadQuantity);
      Pastry pastry = new Pastry(pastryQuantity);

      // Calculate the total price of the order
      decimal totalPrice = bread.GetBreadPrice() + pastry.GetPastryPrice();

      // Display the total price to the user
      Console.WriteLine("Your total price is $" + totalPrice);
      Console.WriteLine("Thank you for shopping at Pierre's Bakery! Please come again soon!");
    }
  }
}