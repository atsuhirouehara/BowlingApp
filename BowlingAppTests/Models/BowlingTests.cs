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

        [TestMethod()]
        public void GetResultの結果がTrueの場合()
        {
            // 準備
            Bowling bowlingApp = new Bowling();

            // 実行
            var target = bowlingApp.GetResult(1, 1);

            // 期待
            Assert.IsTrue(target);
        }
    }
}