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
      Console.WriteLine("How many loaves of bread would you like?");
      string stringBreadOrder = Console.ReadLine();
      int breadOrder = int.Parse(stringBreadOrder);
      Console.WriteLine("How many pastries would you like?");
      string stringPastryOrder = Console.ReadLine();
      int pastryOrder = int.Parse(stringPastryOrder);
      Order userOrder = new Order(breadOrder, pastryOrder);
      int totalPrice = userOrder.TotalPrice();
      Console.WriteLine($"Your order for {userOrder.BreadOrder} loaves and {userOrder.PastryOrder} pastries comes to ${totalPrice}!");
      Console.WriteLine("Thank you for shopping at Pierre's Bakery!");
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
  }
}