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

		[Fact]
		public void When_game_start_then_board_should_be_empty()
		{
			var emptyBoard = new Board(@"
⬜⬜⬜
⬜⬜⬜
⬜⬜⬜
");
			var game = new Game();

			var board = game.Start();

			board.Should().Be(emptyBoard);
		}

//		[Fact]
//		public void MethodName()
//		{
//			var board = new Board();
//			
//			board.
//		}
	}
}