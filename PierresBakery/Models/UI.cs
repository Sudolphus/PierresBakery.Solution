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
      string userOption = Console.ReadLine();
      bool programExit = false;
      switch(userOption)
      {
        case "1":
          BreadOffer();
          AddBreadToOrder(userOrder);
          break;
        case "2":
          PastryOffer();
          AddPastryToOrder(userOrder);
          break;
        case "3":
          BreadOffer();
          PastryOffer();
          break;
        case "4":
          ShoppingCart(userOrder);
          break;
        case "5":
          Checkout(userOrder);
          programExit = true;
          break;
      }
      if (!programExit)
      {
        MainMenu(userOrder);
      }
    }

    private static void Checkout(Order userOrder)
    {
      Console.WriteLine($"You ordered {userOrder.BreadOrder} loaves of bread and {userOrder.PastryOrder} pastries.");
      Console.WriteLine($"Your total comes to ${userOrder.TotalPrice()}");
      Console.WriteLine("Thank you for shopping at Pierre's Bakery!");
    }

    private static void ShoppingCart(Order userOrder)
    {
      Console.WriteLine("Your Cart:");
      Console.WriteLine($"{userOrder.BreadOrder} Loaves of Bread, {userOrder.PastryOrder} Pastries");
      Console.WriteLine($"Total Price: ${userOrder.TotalPrice()}");
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

    private static void AddBreadToOrder(Order userOrder)
    {
      Console.WriteLine("How much bread would you like to add to your order?");
      int breadPlus = int.Parse(Console.ReadLine());
      userOrder.AddBread(breadPlus);
    }

    private static void AddPastryToOrder(Order userOrder)
    {
      Console.WriteLine("How many pastries would you like to add to your order?");
      int pastryPlus = int.Parse(Console.ReadLine());
      userOrder.AddPastry(pastryPlus);
    }
  }
}