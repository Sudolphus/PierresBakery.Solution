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
      Assert.AreEqual(3, newUserOrder.Bread);
      Assert.AreEqual(5, newUserOrder.Pastry);
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
  }
}