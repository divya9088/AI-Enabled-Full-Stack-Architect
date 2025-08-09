using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPlayground.Problems
{
    public class Find_maximum_element_in_array
    {
        public static int MaxElemant(int[] arr)
        {
            if (arr is null || arr.Length == 0) throw new Exception("Empty array");
            int max = arr[0];
            foreach(int num in arr)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }
    }
}
