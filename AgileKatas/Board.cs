using System.Text;

namespace AgileKatas
{
	public class Board
	{
		private readonly string _content;
		public override string ToString()
		{
			return _content;
		}

		public Board(): this(@"
⬜⬜⬜
⬜⬜⬜
⬜⬜⬜
")
		{
		}
		
		public Board(string content) 
		{
			_content = content;
		}

		public Board(Coordinate coordinate)
		{
			var stringBuilder = new StringBuilder();
			stringBuilder.AppendLine();
			FillColumns(coordinate, stringBuilder);

			_content = stringBuilder.ToString();
		}

		private static void FillColumns(Coordinate coordinate, StringBuilder stringBuilder)
		{
			for (var y = 0; y < 3; y++)
			{
				FillRows(coordinate, y, stringBuilder);
				stringBuilder.AppendLine();
			}
		}

		private static void FillRows(Coordinate coordinate, int y, StringBuilder stringBuilder)
		{
			for (var x = 0; x < 3; x++)
			{
				var sign = coordinate.MakeSign(new Coordinate(new X(x), new Y(y)));
				stringBuilder.Append(sign);
			}
		}

		protected bool Equals(Board other)
		{
			return string.Equals(_content, other._content);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((Board) obj);
		}

		public override int GetHashCode()
		{
			return (_content != null ? _content.GetHashCode() : 0);
		}
	}
}