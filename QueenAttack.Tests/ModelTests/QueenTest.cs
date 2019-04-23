using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenSpace;

namespace QueenSpace.Tests
{
  [TestClass]
  public class QueenAttackTest
  {
    [TestMethod]
    public void IsCanAttack_XandYTheSame_True()
    {
      Queen testQueen = new Queen();
      Assert.AreEqual(true, testQueen.CanAttack(3,4));
    }

    [TestMethod]
    public void IsCanAttack_Diagonal_True()
    {
      Queen testQueen = new Queen();
      Assert.AreEqual(true, testQueen.CanAttack(2,6));
    }

  }
}
