using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void NewOrder_ShouldCreateAnObject_Match()
    {
      Order newUserOrder = new Order(3, 5);
      Assert.AreEqual(typeof(Order), newUserOrder.GetType());
    }

    [TestMethod]
    public void NewOrder_ShouldStoreLoavesAndPastries_Match()
    {
      Order newUserOrder = new Order(3, 5);
      Assert.AreEqual(3, newUserOrder.BreadOrder);
      Assert.AreEqual(5, newUserOrder.PastryOrder);
    }

    [DataRow(0, 0)]
    [DataRow(1, 5)]
    [DataRow(2, 10)]
    [DataRow(3, 10)]
    [DataRow(4, 15)]
    [DataRow(20, 70)]
    [DataRow(90, 300)]
    [DataTestMethod]
    public void PriceOfBread_ShouldCalculateBreadPrice_Match(int bread, int expectedBreadPrice)
    {
      Order newOrder = new Order(bread, 5);
      int calculatedBreadPrice = newOrder.PriceOfBread();
      Assert.AreEqual(expectedBreadPrice, calculatedBreadPrice);
    }

    [DataRow(0, 0)]
    [DataRow(1, 2)]
    [DataRow(2, 4)]
    [DataRow(3, 5)]
    [DataRow(4, 7)]
    [DataRow(20, 34)]
    [DataRow(90, 150)]
    [DataTestMethod]
    public void PriceOfPastry_ShouldCalculatePastryPrice_Match(int pastry, int expectedPastryPrice)
    {
      Order newOrder = new Order(0, pastry);
      int calculatedPastryPrice = newOrder.PriceOfPastry();
      Assert.AreEqual(expectedPastryPrice, calculatedPastryPrice);
    }
  }
}