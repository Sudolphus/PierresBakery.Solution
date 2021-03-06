using System;

namespace PierresBakery.Models
{
  public static class UserInterface
  {
    public static void UI()
    {
      ConsoleColor currentBackground = Console.BackgroundColor;
      ConsoleColor currentForeground = Console.ForegroundColor;
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.BackgroundColor = ConsoleColor.Black;
      Console.Beep();
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("---------------------------");
      Console.WriteLine("Pierre's offers the finest in Bread & Pastries!");
      Console.WriteLine("Today we have the following offers: ");
      BreadOffer();
      PastryOffer();
      Order userOrder = new Order(0, 0);
      MainMenu(userOrder, currentBackground, currentForeground);
    }

    private static void MainMenu(Order userOrder, ConsoleColor background, ConsoleColor foreground)
    {
      Console.Beep();
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.BackgroundColor = ConsoleColor.Black;
      Console.WriteLine("--------------------------------------------");
      Console.WriteLine("Please choose one of the following options: ");
      Console.WriteLine("1: Add Bread To Order");
      Console.WriteLine("2: Add Pastries To Order");
      Console.WriteLine("3: View Special Offers");
      Console.WriteLine("4: View Shopping Cart");
      Console.WriteLine("5: Clear Shopping Cart");
      Console.WriteLine("6: Checkout");
      Console.WriteLine("--------------------------------------------");
      string userOption = Console.ReadLine();
      bool programExit = false;
      Console.Beep();
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
          userOrder.BreadOrder = 0;
          userOrder.PastryOrder = 0;
          ShoppingCart(userOrder);
          break;
        case "6":
          Checkout(userOrder);
          programExit = true;
          break;
        default:
          Console.WriteLine("That is not a valid selection");
          break;
      }
      if (programExit)
      {
        Console.ForegroundColor = foreground;
        Console.BackgroundColor = background;
      }
      else
      {
        MainMenu(userOrder, background, foreground);
      }
    }

    private static void Checkout(Order userOrder)
    {
      Console.ForegroundColor = ConsoleColor.Green;
      bool exitFlag = true;
      Console.WriteLine(CheckoutTextBuilder(userOrder));
      if (Bread.BreadSalesDetector(userOrder.BreadOrder))
      {
        Console.WriteLine("All bread is buy 2, get 1 free! Would you like to add a free loaf of bread to your cart? [Y/N]");
        string userResponse = Console.ReadLine();
        Console.Beep();
        if (userResponse == "Y" || userResponse == "y")
        {
          userOrder.AddBread(1);
          exitFlag = false;
          Checkout(userOrder);
        }
      }
      if (Pastry.PastrySalesDetector(userOrder.PastryOrder))
      {
        Console.WriteLine("All pastries are 3 for $5! Would you like to add a pastry for only $1? [Y/N]");
        string userResponse = Console.ReadLine();
        Console.Beep();
        if (userResponse == "Y" || userResponse == "y")
        {
          userOrder.AddPastry(1);
          exitFlag = false;
          Checkout(userOrder);
        }
      }
      if (exitFlag)
      {
        Console.WriteLine($"Your total comes to ${userOrder.TotalPrice()}");
        Console.WriteLine("Thank you for shopping at Pierre's Bakery!");
      }
    }

    private static string CheckoutTextBuilder(Order userOrder)
    {
      string orderText;
      if (userOrder.BreadOrder > 0 && userOrder.PastryOrder > 0)
      {
        orderText = $"You've ordered {userOrder.BreadOrder} loaves of bread and {userOrder.PastryOrder} pastries.";
      }
      else if (userOrder.BreadOrder > 0)
      {
        orderText = $"You've ordered {userOrder.BreadOrder} loaves of bread";
      }
      else if (userOrder.PastryOrder > 0)
      {
        orderText = $"You've ordered {userOrder.PastryOrder} pastries";
      }
      else{
        orderText = "Your shopping cart is empty!";
      }
      return orderText;
    }

    private static void ShoppingCart(Order userOrder)
    {
      Console.ForegroundColor = ConsoleColor.DarkGreen;
      Console.WriteLine("Your Cart:");
      Console.WriteLine(CheckoutTextBuilder(userOrder));
      Console.WriteLine($"Total Price: ${userOrder.TotalPrice()}");
    }

    private static void BreadOffer()
    {
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("Bread: $5 per loaf");
      Console.WriteLine("All bread is buy 2, get 1 free!");
    }

    private static void PastryOffer()
    {
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("Pastries: $2 each");
      Console.WriteLine("All Pastries are 3 for $5!");
    }

    private static void AddBreadToOrder(Order userOrder)
    {
      Console.ForegroundColor = ConsoleColor.DarkGreen;
      Console.WriteLine("How much bread would you like to add to your order?");
      try{
        int breadPlus = int.Parse(Console.ReadLine());
        Console.Beep();
        userOrder.AddBread(breadPlus);
      }
      catch
      {
        Console.WriteLine("That input is not valid");
        AddBreadToOrder(userOrder);
      }
    }

    private static void AddPastryToOrder(Order userOrder)
    {
      Console.ForegroundColor = ConsoleColor.DarkGreen;
      Console.WriteLine("How many pastries would you like to add to your order?");
      try
      {
        int pastryPlus = int.Parse(Console.ReadLine());
        Console.Beep();
        userOrder.AddPastry(pastryPlus);
      }
      catch
      {
        Console.WriteLine("That input is not valid");
        AddPastryToOrder(userOrder);
      }
    }
  }
}