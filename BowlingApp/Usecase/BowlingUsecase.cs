using BowlingApp.Models;
using System;

namespace BowlingApp.Usecase
{
    public class BowlingUsecase
    {
        private readonly IBowling bowling;
        
        public BowlingUsecase(IBowling bowling)
        {
            this.bowling = bowling;
        }
        /// <summary>
        /// 2回の合計値を計算するメソッド
        /// </summary>
        /// <returns></returns>
        public int CalcScore()
        {
            var maxNum = 11;
            int firstThrowResult = bowling.GetRandomNum(maxNum);
            int secondThrowResult;

            if (firstThrowResult == 10) 
            { 
                // ストライクとスペアを区別するためストライクの時に11を返す
                return firstThrowResult + 1;
            }
            else
            {
                secondThrowResult = bowling.GetRandomNum(maxNum - firstThrowResult);
            }
            return firstThrowResult + secondThrowResult;
        }

        /// <summary>CalcScoreの結果に合った文字列に変換して返却するメソッド</summary>
        /// <returns></returns>
        public string GetScore()
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

        public bool GetCulcResult()
        {
            return bowling.GetResult(10, 10);
            // var flag = bowling.GetResult(10, 10);
            //try
            //{
            //    if (flag == true)
            //    {
            //        return flag;
            //    }
            //}
            //catch(Exception e)
            //{
            //    throw new Exception(e.Message);
            //}

            //return flag;
        }
    }
}