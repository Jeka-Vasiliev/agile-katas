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

		[Theory]
		[InlineData(0, 0, @"
✖⬜⬜
⬜⬜⬜
⬜⬜⬜
")]
		[InlineData(1, 0, @"
⬜✖⬜
⬜⬜⬜
⬜⬜⬜
")]
		[InlineData(1, 1, @"
⬜⬜⬜
⬜✖⬜
⬜⬜⬜
")]
		public void When_first_move_on_x_y_board_should_contains_X_on_x_y(int x, int y, string boardContent)
		{
			var expected = new Board(boardContent);
			var game = new Game();
			game.Start();
			var actual = game.Move(new Coordinate(new X(x), new Y(y)));

			actual.Should().Be(expected);
		}

		[Fact]
		public void When_compare_two_different_board_they_should_not_be_equal()
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
		public void When_Compare_Two_Same_X_Then_Should_Be_Equals()
		{
			var expectedX = new X(0);
			var x = new X(0);

			x.Should().Be(expectedX);
		}

		[Fact]
		public void When_Compare_Two_Same_Y_Then_Should_Be_Equals()
		{
			var expectedX = new Y(0);
			var x = new Y(0);

			x.Should().Be(expectedX);
		}

		[Fact]
		public void When_Compare_Two_Same_Coordinates_Then_Should_Be_Equals()
		{
			var actual = new Coordinate(new X(1), new Y(2));
			var expected = new Coordinate(new X(1), new Y(2));

			actual.Should().Be(expected);
		}
	}
}