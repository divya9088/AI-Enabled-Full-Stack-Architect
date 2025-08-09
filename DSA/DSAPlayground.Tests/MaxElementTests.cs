using DSAPlayground.Problems;
using System.Xml.Linq;

namespace DSAPlayground.Tests
{
    public class MaxElementTests
    {
        [Fact]
        public void Find_Max_element()
        {
            int ans = Find_maximum_element_in_array.MaxElemant([6, 1, 9, 3, 0]);
            Assert.Equal(9, ans);
        }

        [Fact]
        public void Throws_On_Empty()
        {
            Assert.Throws<ArgumentException>(() => Find_maximum_element_in_array.MaxElemant(Array.Empty<int>()));
        }
    }
}
