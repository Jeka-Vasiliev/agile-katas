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

		[Fact]
		public void Should_put_X_on_0_0_when_first_player_move()
		{
			var game = new Game();

			game.Move(0, 0);
			
			var snapshot = game.Snapshot();
			snapshot.Should().Be(new Snapshot(new[]
			{
				"X  ",
				"   ",
				"   ",
			}));
		}
	}
}