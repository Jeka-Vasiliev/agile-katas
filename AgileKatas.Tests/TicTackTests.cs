using System.Collections.Generic;
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

		public static IEnumerable<object[]> Data => new List<object[]>
		{
			new object[]
			{
				0, 0, new Snapshot(new[]
				{
					"X  ",
					"   ",
					"   ",
				})
			},
			new object[]
			{
				1, 1, new Snapshot(new[]
				{
					"   ",
					" X ",
					"   ",
				})
			},
		};

		[Theory]
		[MemberData(nameof(Data))]
		public void Should_put_X_on_coordinates_when_first_player_move(int x, int y, Snapshot expected)
		{
			var game = new Game();

			game.Move(x, y);

			var snapshot = game.Snapshot();
			snapshot.Should().Be(expected);
		}
	}

}