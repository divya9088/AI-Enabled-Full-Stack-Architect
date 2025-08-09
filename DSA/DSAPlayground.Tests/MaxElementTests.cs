using DSAPlayground.Problems;
using System.Xml.Linq;

namespace DSAPlayground.Tests
{
    public class MaxElementTests
    {
        [Fact]
        public void Find_Max_element()
        {
            int ans = MaxElement.MaxElement([6, 1, 9, 3, 0]);
            Assert.Equal(9, ans);
        }

        [Fact]
        public void Throws_On_Empty()
        {
            Assert.Throws<ArgumentException>(() => MaxElement.MaxElement(Array.Empty<int>()));
        }
    }
}
