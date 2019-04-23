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
        Assert.AreEqual("ping", testPingPong.IsPing(15));
      }
      [TestMethod]
      public void IsPingPong_NumberDivisibleByFive_True()
      {
        PingPong testPingPong = new PingPong();
        Assert.AreEqual("pong", testPingPong.IsPong(15));
      }
      [TestMethod]
      public void IsPingPong_NumberDivisibleByThreeAndFive_True()
      {
        PingPong testPingPong = new PingPong();
        Assert.AreEqual("ping pong", testPingPong.IsPingPong(15));
      }
      [TestMethod]
      public void IsPingPong_WillOutputAList_True()
      {
        PingPong testPingPong = new PingPong();
        Assert.AreEqual("ping pong",  testPingPong.PingPongList(15)[14]);
      }
    }
}
