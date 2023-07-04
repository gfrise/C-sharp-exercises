using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex23
{
    public class Filter
    {
        public static IEnumerable<int> GetOdds(IEnumerable<int> nums)
        {
            return nums.Where(i => i % 2 != 0).OrderBy(i => i);
        }
        public static IEnumerable<int> GetOddsReversed(IEnumerable<int> nums)
        {
            return nums.Where(i => i % 2 != 0).OrderByDescending(i => i);
        }
    }
}
