using FluentAssertions;
using Xunit;

namespace TestProject1
{
	public class RomanTests
	{
		[Fact]
		public void Should_Convert_1_to_I()
		{
			var romanNumber = RomanConverter.Convert(1);
			romanNumber.Should().Be("I");
		}
	}

	public class RomanConverter
	{
		public static string Convert(int i)
		{
			return "I";
		}
	}
}