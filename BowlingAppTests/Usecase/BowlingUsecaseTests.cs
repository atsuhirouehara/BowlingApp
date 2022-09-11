using BowlingApp.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace BowlingApp.Usecase.Tests
{
    [TestClass]
    public class BowlingUsecaseTests
    {
        //[TestMethod]
        //public void _2回の合計が0から11であるか確認するテスト()
        //{
        //    BowlingUsecase bowlingUsecase = new();
        //    Assert.AreEqual(5, bowlingUsecase.CalcScore(), 6);
        //}

        //[TestMethod]
        //[Ignore]
        //public void _1回目に10の場合に〇を返すか確認するテスト()
        //{
        //    BowlingUsecase bowlingUsecase = new();
        //    Assert.AreEqual("〇", bowlingUsecase.GetScore());
        //}

        //[TestMethod]
        //[Ignore]
        //public void _2回の合計が10の場合にさんかくを返すか確認するテスト()
        //{
        //    BowlingUsecase bowlingUsecase = new();
        //    Assert.AreEqual("▶", bowlingUsecase.GetScore());
        //}

        [TestMethod]
        [Ignore]
        public void _2回の合計が0の場合にバツを返す()
        {
            Mock<Bowling> bowlingMock = new Mock<Bowling>();
            bowlingMock.Setup(o => o.GetResult(1, 1)).Verifiable();
            BowlingUsecase bowlingUsecase = new(bowlingMock.Object);
            Assert.AreEqual("✖", bowlingUsecase.GetScore());
        }

        //[TestMethod()]
        //[Ignore]
        // string型で返却するためテストできない
        //public void _2回の合計が1から9を返すか確認するテスト()
        //{
        //    BowlingUsecase bowlingUsecase = new BowlingUsecase();
        //    Assert.AreEqual(5, bowlingUsecase.GetScore(), 4);
        //}

        //1~9,〇,▶,✖のどれかが返されていることが確認できるテストをしたい
        //[DataTestMethod]
        //[DataRow("〇")]
        //[DataRow("▶")]
        //[DataRow("✖")]
        //public void GetScoreを実行した際に上記の値が返却されることを確認するテスト(string expected)
        //{
        //    BowlingUsecase bowlingUsecase = new BowlingUsecase();
        //    Assert.AreEqual(expected, bowlingUsecase.GetScore());
        //}

        [TestMethod]
        public void BowlingのGetResultがTrueを返したらGetCucResultもTrueを返す()
        {
            // 準備
            Mock<IBowling> bowlingMock = new Mock<IBowling>();
            bowlingMock.Setup(o => o.GetResult(It.IsAny<int>(), It.IsAny<int>())).Returns(true).Verifiable();
            var bowlingUsecaseResult = new BowlingUsecase(bowlingMock.Object);

            // 実行
            // 期待
            Assert.IsTrue(bowlingUsecaseResult.GetCulcResult());
            bowlingMock.Verify(o => o.GetResult(It.IsAny<int>(), It.IsAny<int>()), Times.Once);
        }

        // GetResult=true→GetCucResultもTrueを返すはず
        // Usecase実行したら、Getresultが呼び出されるはず(80行目に内包されている)
        // Bowlingで異常系がでたら、Usecaseでも異常系になる

        //[TestMethod]
        //public void GetCulcResultの例外発生の()
        //{
        //    // 準備
        //    Mock<IBowling> bowlingMock = new Mock<IBowling>();
        //    bowlingMock.Setup(o => o.GetResult(It.IsAny<int>(), It.IsAny<int>())).Throws<Exception>();

        //    // 実行
        //    var target = bowlingMock.Object.GetResult(1, 2);

        //    // 期待
        //    Assert.IsTrue(target);
        //    // bowlingMock.Verify(o => o.GetResult(1, 1), Times.Once);
        //}
    }
}