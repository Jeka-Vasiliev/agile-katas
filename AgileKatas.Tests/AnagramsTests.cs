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

		[Theory]
		[InlineData("aa")]
		[InlineData("aaa")]
		public void Should_return_same_string_if_no_anagrams(string textForTest)
		{
			var result = Anagrams.Get(textForTest);

			result.Should().ContainSingle().Which.Should().Be(textForTest);
		}

		[Theory]
		[InlineData("ab", "ab", "ba")]
		[InlineData("ac", "ac", "ca")]
		public void Should_return_two_anagrams_when_text_contains_two_different_symbols(string textForTest, params string[] expected)
		{
			var result = Anagrams.Get(textForTest);

			result.Should().Contain(expected);
		}

		[Theory]
		[InlineData("aab", "aab", "aba", "baa")]
		public void Should_contains_three_values_when_one_of_three_symbols_different(string textForTest, params string[] expected)
		{
			var result = Anagrams.Get(textForTest);

			result.Should().HaveCount(expected.Length);
			result.Should().Contain(expected);
		}
	}
}