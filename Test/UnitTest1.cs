using extension_method;
using extended_func;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        Class1 class1 = new Class1();
        [Fact]
        public void Test_for_num()
        {
            Assert.Equal("$123", class1.Tocurrency("123"));
        }
        [Fact]
        public void Test_for_string()
        {
            var ex = Assert.Throws<ArgumentException>(() => class1.Tocurrency("abc"));
            Assert.Equal("string should be a number", ex.Message);
        }
        [Fact]
        public void Test_for_combination()
        {
            var ex = Assert.Throws<ArgumentException>(() => class1.Tocurrency("123abc"));
            Assert.Equal("string should be a number", ex.Message);
        }
    }
}