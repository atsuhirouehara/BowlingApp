using System;

namespace BowlingApp.Models
{
    public class Bowling : IBowling
    {
        /// <summary>ランダムな値を返すメソッド</summary>
        /// <param name="maxNum"></param>
        /// <returns>ランダムな値</returns>
        public int GetRandomNum(int maxNum)
        {
            Random random = new Random();
            var throwResult = random.Next(0, maxNum);
            return throwResult;
        }

        /// <summary>2つの引数の足し算結果を返す</summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>true/false</returns>
        public bool GetResult(int a, int b)
        {
            bool flug = false;
            int result = a + b;

            if (result%2 == 0)
            {
                flug = true;
                return flug;
            }
            else
            {
                throw new Exception("計算結果が偶数ではありません");
            }
        }
    }
}