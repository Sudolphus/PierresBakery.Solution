using System;

namespace PierresBakery.Models
{
  public static class UserInterface
  {
    public static void UI()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("---------------------------");
      Console.WriteLine("Pierre's offers the finest in Bread & Pastries!");
      Console.WriteLine("Today we have the following offers: ");
      BreadOffer();
      PastryOffer();
      Order userOrder = new Order(0, 0);
      MainMenu(userOrder);
      Console.WriteLine("How many loaves of bread would you like?");
      string stringBreadOrder = Console.ReadLine();
      int breadOrder = int.Parse(stringBreadOrder);
      Console.WriteLine("How many pastries would you like?");
      string stringPastryOrder = Console.ReadLine();
      int pastryOrder = int.Parse(stringPastryOrder);
      int totalPrice = userOrder.TotalPrice();
      Console.WriteLine($"Your order for {userOrder.BreadOrder} loaves and {userOrder.PastryOrder} pastries comes to ${totalPrice}!");
      Console.WriteLine("Thank you for shopping at Pierre's Bakery!");
    }

    private static void MainMenu(Order userOrder)
    {
      Console.WriteLine("Please choose one of the following options: ");
      Console.WriteLine("1: Add Bread To Order");
      Console.WriteLine("2: Add Pastries To Order");
      Console.WriteLine("3: View Special Offers");
      Console.WriteLine("4: View Shopping Cart");
      Console.WriteLine("5: Checkout");
    }

    private static void ShoppingCart(Order userOrder)
    {
      Console.WriteLine("Your Cart:");
      Console.WriteLine($"{userOrder.BreadOrder} Loaves of Bread, {userOrder.PastryOrder} Pastries");
      Console.WriteLine($"Total Price: {userOrder.TotalPrice()}");
    }

    private static void BreadOffer()
    {
      Console.WriteLine("Bread: $5 per loaf");
      Console.WriteLine("All bread is buy 2, get 1 free!");
    }

    private static void PastryOffer()
    {
      Console.WriteLine("Pastries: $2 each");
      Console.WriteLine("All Pastries are 3 for $5!");
    }

    private static void AddBreadToOrder()
    {

    }
  }
}