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
		public void Should_convert_arabic_to_roman(int arabicNumber, string expectedRomanNumber)
		{
			var romanNumber = RomanConverter.Convert(arabicNumber);
			romanNumber.Should().Be(expectedRomanNumber);
		}
	}
}