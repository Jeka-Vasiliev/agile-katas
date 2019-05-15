using AgileKatas;
using FluentAssertions;
using Xunit;

namespace TestProject1
{
	public class RomanTests
	{
		[Fact]
		public void Should_convert_1_to_I()
		{
			var romanNumber = RomanConverter.Convert(1);
			romanNumber.Should().Be("I");
		}

		[Fact]
		public void Should_convert_2_to_II()
		{
			var romanNumber = RomanConverter.Convert(2);
			romanNumber.Should().Be("II");
		}
	}
}