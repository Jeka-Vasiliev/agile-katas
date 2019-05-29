namespace AgileKatas
{
	public class Board
	{
		public Board()
		{
		}
		
		public Board(string content) : this()
		{
		}

		protected bool Equals(Board other)
		{
			return true;
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
			throw new System.NotImplementedException();
		}
	}
}