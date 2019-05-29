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
			var content = new StringBuilder();
			content.AppendLine();
			for (int y = 0; y < 3; y++)
			{
				for (int x = 0; x < 3; x++)
				{
					var coord = new Coordinate(new X(x), new Y(y));

					if (coordinate.Equals(coord))
					{
						content.Append("✖");
						continue;
						
					}
					content.Append("⬜");
				}
				content.AppendLine();
			}

			_content = content.ToString();
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