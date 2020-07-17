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
  }
}