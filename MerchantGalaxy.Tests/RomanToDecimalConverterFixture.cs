using System;
using Xunit;
using MerchantGalaxy;
using System.Text;
namespace MerchantGalaxy.Tests
{
    public class RomanToDecimalConverterFixture
    {
        [Fact]
        public void SingleRomanDigitTest()
        {
            int expectedValue=1;
            int actualValue=RomanToDecimalConverter.Convert("I");
            Assert.Equal(expectedValue,actualValue);
        }
    }
}
