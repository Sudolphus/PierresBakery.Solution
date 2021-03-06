namespace PierresBakery.Models
{
  public static class Pastry
  {
    public static int TotalCost(int pastry)
    {
      int pastryPrice = 0;
      while (pastry >= 3)
      {
        pastryPrice += 5;
        pastry -= 3;
      }
      pastryPrice += 2 * pastry;
      return pastryPrice;
    }

    public static bool PastrySalesDetector(int pastry)
    {
      if (pastry % 3 == 2)
      {
        return true;
      }
      return false;
    }
  }
}