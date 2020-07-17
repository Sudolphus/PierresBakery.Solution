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
      Order newUserOrder = new Order();
      Assert.AreEqual(typeof(Order), newUserOrder.GetType());
    }
  }
}