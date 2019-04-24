using System;
using AgileKatas;
using FluentAssertions;
using Xunit;

namespace TestProject1
{
	public class UnitTest1
	{
		[Fact]
		public void ShouldConvertOneToString()
		{
			var result = FizzBuzzConverter.Convert(1);

			result.Should().Be("1");
		}

		[Fact]
		public void ShouldConvertTwoToString()
		{
			var result = FizzBuzzConverter.Convert(2);

			result.Should().Be("2");
		}
		
		
	}
}