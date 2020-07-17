namespace PierresBakery.Models
{
  public class Order
  {
    public int BreadOrder { get; set; }
    public int PastryOrder { get; set; }

    public Order(int bread, int pastry)
    {
      BreadOrder = bread;
      PastryOrder = pastry;
    }

    public int TotalPrice()
    {
      return PriceOfBread() + PriceOfPastry();
    }

    private int PriceOfBread()
    {
      return Bread.TotalCost(BreadOrder);
    }

    private int PriceOfPastry()
    {
      return Pastry.TotalCost(PastryOrder);
    }
  }
}