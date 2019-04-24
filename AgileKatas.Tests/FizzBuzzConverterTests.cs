using System;
using AgileKatas;
using FluentAssertions;
using Xunit;

namespace TestProject1
{
	public class UnitTest1
	{
		[Theory]
		[InlineData(1, "1")]
		[InlineData(2, "2")]
		[InlineData(4, "4")]
		public void ShouldConvertNumberToString(int number, string expected)
		{
			var result = FizzBuzzConverter.Convert(number);

			result.Should().Be(expected);
		}

		[Fact]
		public void ShouldConvertThreeToFizz()
		{
			var result = FizzBuzzConverter.Convert(3);

			result.Should().Be("fizz");
		}
	}
}