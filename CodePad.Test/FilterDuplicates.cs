 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePad.Test
{
    public class Solution
    {
        public static int[] FilterDuplicates(int[] data)
        {
            return data.Distinct().ToArray();
        }
    }
}


