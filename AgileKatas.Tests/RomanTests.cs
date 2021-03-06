using AgileKatas;
using FluentAssertions;
using Xunit;

namespace TestProject1
{
	public class RomanTests
	{
		[Theory]
		[InlineData(1, "I")]
		[InlineData(2, "II")]
		[InlineData(5, "V")]
		[InlineData(6, "VI")]
		[InlineData(8, "VIII")]
		[InlineData(4, "IV")]
		[InlineData(10, "X")]
		[InlineData(11, "XI")]
		[InlineData(33, "XXXIII")]
		[InlineData(50, "L")]
		[InlineData(83, "LXXXIII")]
		[InlineData(40, "XL")]
		[InlineData(100, "C")]
		[InlineData(90, "XC")]
		[InlineData(41, "XLI")]
		[InlineData(45, "XLV")]
		public void Should_convert_arabic_to_roman(int arabicNumber, string expectedRomanNumber)
		{
			var romanNumber = RomanConverter.Convert(arabicNumber);
			romanNumber.Should().Be(expectedRomanNumber);
		}
	}
}