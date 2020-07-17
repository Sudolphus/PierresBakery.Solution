namespace PierresBakery.Models
{
  public class Order
  {
    public int BreadOrder { get; set; }
    public int PastryOrder { get; set; }

    public Order(int bread, int pastry)
    {
      if (bread > 0)
      {
        BreadOrder = bread;
      }
      else
      {
        BreadOrder = 0;
      }
      if (pastry > 0)
      {
        PastryOrder = pastry;
      }
      else
      {
        PastryOrder = 0;
      }
    }

    public int TotalPrice()
    {
      return PriceOfBread() + PriceOfPastry();
    }

    public void AddBread(int breadPlus)
    {
      if (BreadOrder + breadPlus > 0)
      {
        BreadOrder += breadPlus;
      }
      else
      {
        BreadOrder = 0;
      }
    }

    public void AddPastry(int pastryPlus)
    {
      if (PastryOrder + pastryPlus > 0)
      {
        PastryOrder += pastryPlus;
      }
      else
      {
        PastryOrder = 0;
      }
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