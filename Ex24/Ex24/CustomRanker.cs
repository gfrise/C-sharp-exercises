using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex24
{
    internal class CustomRanker : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            int digitsInX = x.ToString().Length;
            int digitsInY = y.ToString().Length;

            return digitsInX.CompareTo(digitsInY);
        }
    }
}
