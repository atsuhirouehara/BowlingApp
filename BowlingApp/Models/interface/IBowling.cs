using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingApp.Models
{
    public interface IBowling
    {
        public int GetRandomNum(int maxNum);

        public bool GetResult(int a, int b);
    }
}
