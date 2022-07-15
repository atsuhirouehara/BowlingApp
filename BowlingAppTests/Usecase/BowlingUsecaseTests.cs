using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingApp.Usecase.Tests
{
    [TestClass()]
    public class BowlingUsecaseTests
    {
        [TestMethod()]
        public void _2回の合計が0から11であるか確認するテスト()
        {
            BowlingUsecase bowlingUsecase = new BowlingUsecase();
            Assert.AreEqual(5, bowlingUsecase.CalcScore(), 6);
        }

        //[TestMethod()]
        //public void _1回目に10の場合に〇を返すか確認するテスト()
        //{
        //    BowlingUsecase bowlingUsecase = new BowlingUsecase();
        //    Assert.AreEqual("〇", bowlingUsecase.GetScore());
        //}

        //[TestMethod()]
        //public void _2回の合計が10の場合にさんかくを返すか確認するテスト()
        //{
        //    BowlingUsecase bowlingUsecase = new BowlingUsecase();
        //    Assert.AreEqual("▶", bowlingUsecase.GetScore());
        //}

        //[TestMethod()]
        //public void _2回の合計が0の場合にバツを返すか確認するテスト()
        //{
        //    BowlingUsecase bowlingUsecase = new BowlingUsecase();
        //    Assert.AreEqual("✖", bowlingUsecase.GetScore());
        //}

        //[TestMethod()]
        // string型で返却するためテストできない
        //public void _2回の合計が1から9を返すか確認するテスト()
        //{
        //    BowlingUsecase bowlingUsecase = new BowlingUsecase();
        //    Assert.AreEqual(5, bowlingUsecase.GetScore(), 4);
        //}

        //[DataTestMethod]
        //[DataRow("〇")]
        //[DataRow("▶")]
        //[DataRow("✖")]
        //public void GetScoreを実行した際に上記の値が返却されることを確認するテスト(string expected)
        //{
        //    BowlingUsecase bowlingUsecase = new BowlingUsecase();
        //    Assert.AreEqual(expected, bowlingUsecase.GetScore());
        //}
    }
}