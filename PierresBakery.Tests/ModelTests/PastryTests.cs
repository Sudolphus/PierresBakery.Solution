using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastrySalesDetector_ShouldDetectIfUserHasPossibleDiscount_True()
    {
      Assert.IsTrue(Pastry.PastrySalesDetector(2));
    }

    [DataRow(0)]
    [DataRow(1)]
    [DataRow(3)]
    [DataTestMethod]
    public void PastrySaleDetector_ShouldDetectIfUserDoesNotHavePossibleDiscount_False(int pastry)
    {
      Assert.IsFalse(Pastry.PastrySalesDetector(pastry));
    }
  }
}