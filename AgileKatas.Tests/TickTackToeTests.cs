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

		[Fact]
		public void When_first_move_on_0_0_board_should_contains_X_on_0_0()
		{
			var expected = new Board(@"
✖⬜⬜
⬜⬜⬜
⬜⬜⬜
");
			var game = new Game();
			game.Start();
			var actual = game.Move(new Coordinate(new X(0), new Y(0)));

			actual.Should().Be(expected);
		}
		[Fact]

		public void When_first_move_on_1_0_board_should_contains_X_on_1_0()
		{
			var expected = new Board(@"
⬜✖⬜
⬜⬜⬜
⬜⬜⬜
");
			var game = new Game();
			game.Start();
			var actual = game.Move(new Coordinate(new X(1), new Y(0)));

			actual.Should().Be(expected);
		}

		[Fact(Skip = "WIP")]
		public void Ignored()
		{
			var emptyBoard = new Board(@"
⬜⬜⬜
⬜⬜⬜
⬜⬜⬜
");
			var notEmptyBoard = new Board(@"
⬜✖⬜
⬜⬜⬜
⬜⬜⬜
");

			var isSame = emptyBoard.Equals(notEmptyBoard);

			isSame.Should().BeFalse();
		}

		[Fact]
		public void Should_X_Equals_Work_Correctly()
		{
			var expectedX = new X(0);
			var x = new X(0);
			
			x.Should().Be(expectedX);
		}
	}
}