using System.Collections.Generic;
using BowlingApp.Models;

namespace BowlingApp.Usecase
{
    public class BowlingUsecase
    {
        private readonly IBowling bowling;

        public BowlingUsecase(IBowling bowling)
        {
            this.bowling = bowling;
        }
        /// <summary>2回の合計値を計算するメソッド</summary>
        public int CalcScore()
        {
            var maxNum = 11;
            int firstThrowResult = this.bowling.GetRandomNum(maxNum);
            int secondThrowResult;

            if (firstThrowResult == 10)
            {
                // ストライクとスペアを区別するためストライクの時に11を返す
                return firstThrowResult + 1;
            }
            else
            {
                secondThrowResult = this.bowling.GetRandomNum(maxNum - firstThrowResult);
            }
            return firstThrowResult + secondThrowResult;
        }

        /// <summary>CalcScoreの結果に合った文字列に変換して返却するメソッド</summary>
        public string GetThrowResult()
        {
            var score = this.CalcScore().ToString();
            switch (score)
            {
                case "11":
                    return "〇";

                case "10":
                    return "▶";

                case "0":
                    return "✖";

                default:
                    return score;
            }
        }

        /// <summary>合計点を計算して返すメソッド</summary>
        public int GetScore(List<string> throwLists)
        {
            return 0;
        }

        /// <summary>テストの練習用メソッド</summary>
        public bool GetCulcResult()
        {
            return this.bowling.GetResult(10, 10);
        }
    }
}