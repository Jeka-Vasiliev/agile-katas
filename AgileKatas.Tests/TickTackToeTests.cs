using AgileKatas;
using FluentAssertions;
using Xunit;

namespace TestProject1
{
	public class TickTackToeTests
	{
		[Fact]
		public void When_game_start_then_board_is_not_null()
		{
			var game = new Game();
			
			var board = game.Start();

			board.Should().NotBeNull();
		}
	}
}