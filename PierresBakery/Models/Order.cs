namespace PierresBakery.Models
{
  public class Order
  {
    public int Bread { get; set; }
    public int Pastry { get; set; }

    public Order(int bread, int pastry)
    {
      Bread = bread;
      Pastry = pastry;
    }
  }
}