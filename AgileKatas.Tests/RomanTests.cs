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
		public void Should_convert_arabic_to_roman(int arabicNumber, string expectedRomanNumber)
		{
			var romanNumber = RomanConverter.Convert(arabicNumber);
			romanNumber.Should().Be(expectedRomanNumber);
		}
	}
}