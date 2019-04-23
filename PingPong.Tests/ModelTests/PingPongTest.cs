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
        Assert.AreEqual(true, testPingPong.IsPingPong(31));
      }
    }
}
