using AgileKatas;
using FluentAssertions;
using Xunit;

namespace TestProject1
{
	public class AnagramsTests
	{
		[Fact]
		void Should_return_empty_array_when_empty_string()
		{
			var textForTest = "";	
			
			var result = Anagrams.Get(textForTest);
			
			result.Should().BeEmpty();
		}

		[Theory]
		[InlineData("a")]
		[InlineData("b")]
		[InlineData("c")]
		public void Should_return_same_symbol_if_one_symbol(string textForTest)
		{
			var result = Anagrams.Get(textForTest);
			
			result.Should().ContainSingle().Which.Should().Be(textForTest);
		}
	}
}