using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingApp.Models.Tests
{
    [TestClass()]
    public class BowlingTests
    {
        [TestMethod()]
        public void _1から10のランダムな値が返るかテスト()
        {
            Bowling bowlingApp = new Bowling();
            Assert.AreEqual(5, bowlingApp.GetRandomNum(10), 5);
        }
    }
}