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
		[InlineData(3, "fizz")]
		[InlineData(6, "fizz")]
		[InlineData(9, "fizz")]
		[InlineData(5, "buzz")]
		[InlineData(10, "buzz")]
		[InlineData(20, "buzz")]
		[InlineData(15, "fizzbuzz")]
		[InlineData(30, "fizzbuzz")]
		[InlineData(45, "fizzbuzz")]
		public void ShouldConvertNumberToString(int number, string expected)
		{
			var result = FizzBuzzConverter.Convert(number);

			result.Should().Be(expected);
		}
	}
}