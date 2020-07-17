using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadSalesDetector_CanCheckIfUserHasEarnedFreeBread_True()
    {
      Assert.IsTrue(Bread.BreadSalesDetector(2));
    }

    [DataRow(0)]
    [DataRow(1)]
    [DataRow(3)]
    [DataTestMethod]
    public void BreadSalesDetector_CanCheckIfUserHasNotEarnedFreeBread_False(int bread)
    {
      Assert.IsFalse(Bread.BreadSalesDetector(bread));
    }
  }
}