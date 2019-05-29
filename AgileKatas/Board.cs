namespace AgileKatas
{
	public class Board
	{
		private readonly string _content;

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