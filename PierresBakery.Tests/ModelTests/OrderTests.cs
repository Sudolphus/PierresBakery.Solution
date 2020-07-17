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
    public void TotalPrice_ShouldCalculateBreadPrice_Match(int bread, int expectedBreadPrice)
    {
      Order newOrder = new Order(bread, 0);
      int calculatedBreadPrice = newOrder.TotalPrice();
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
    public void TotalPrice_ShouldCalculatePastryPrice_Match(int pastry, int expectedPastryPrice)
    {
      Order newOrder = new Order(0, pastry);
      int calculatedPastryPrice = newOrder.TotalPrice();
      Assert.AreEqual(expectedPastryPrice, calculatedPastryPrice);
    }

    [DataRow(0, 0, 0)]
    [DataRow(3, 5, 19)]
    [DataRow(10, 20, 69)]
    [DataTestMethod]
    public void TotalPrice_ShouldCalculateTotalPrice_Match(int bread, int pastry, int expectedTotalPrice)
    {
      Order newOrder = new Order(bread, pastry);
      int calculatedTotalPrice = newOrder.TotalPrice();
      Assert.AreEqual(expectedTotalPrice, calculatedTotalPrice);
    }

    [TestMethod]
    public void AddBread_ShouldAddBreadToOrder_5()
    {
      Order newOrder = new Order(3, 5);
      newOrder.AddBread(2);
      Assert.AreEqual(5, newOrder.BreadOrder);
    }

    [TestMethod]
    public void AddBread_ShouldAlsoRemoveBreadFromOrder_1()
    {
      Order newOrder = new Order(3, 5);
      newOrder.AddBread(-1 * 2);
      Assert.AreEqual(1, newOrder.BreadOrder);
    }

    [TestMethod]
    public void AddPastry_ShouldAddPastriesToOrder_10()
    {
      Order newOrder = new Order(3, 5);
      newOrder.AddPastry(5);
      Assert.AreEqual(10, newOrder.PastryOrder);
    }

    [TestMethod]
    public void AddPastry_ShouldAlsoRemovePastriesFromOrder_3()
    {
      Order newOrder = new Order(3, 5);
      newOrder.AddPastry(-1 * 2);
      Assert.AreEqual(3, newOrder.PastryOrder);
    }
  }
}