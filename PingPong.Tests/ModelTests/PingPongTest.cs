using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongGame;

namespace PingPongGame.Tests
{
    [TestClass]
    public class PingPongTest
    {
      [TestMethod]
      public void IsPingPong_NumberDivisibleByThree_True()
      {
        PingPong testPingPong = new PingPong();
        Assert.AreEqual(true, testPingPong.IsPing(33));
      }
      [TestMethod]
      public void IsPingPong_NumberDivisibleByFive_True()
      {
        PingPong testPingPong = new PingPong();
        Assert.AreEqual(true, testPingPong.IsPong(50));
      }
      [TestMethod]
      public void IsPingPong_NumberDivisibleByThreeAndFive_True()
      {
        PingPong testPingPong = new PingPong();
        Assert.AreEqual(true, testPingPong.IsPingPong(15));
      }
    }
}
