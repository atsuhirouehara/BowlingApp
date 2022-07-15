using System;

namespace BowlingApp.Models
{
    public class Bowling
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
    }
}