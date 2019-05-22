using AgileKatas;
using FluentAssertions;
using Xunit;

namespace TestProject1
{
	public class TicTackTests
	{
		[Fact]
		public void Should_game_field_empty_when_game_start()
		{
			var game = new Game();
			
			var snapshot = game.Snapshot();
			
			snapshot.Should().Be(new Snapshot(new[]
			{
				"   ",
				"   ",
				"   ",
			}));
		}
		
		// TODO: arg tests
	}
}