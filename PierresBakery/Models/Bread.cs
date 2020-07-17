namespace PierresBakery.Models
{
  public static class Bread
  {
    public static int TotalCost(int bread)
    {
      int breadCost = 0;
      while (bread >= 3)
      {
        breadCost += 10;
        bread -= 3;
      }
      breadCost += 5 * bread;
      return breadCost;
    }

    public static bool BreadSalesDetector(int bread)
    {
      if (bread % 3 == 2)
      {
        return true;
      }
      return false;
    }
  }
}