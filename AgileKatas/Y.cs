namespace AgileKatas
{
	public class Y
	{
		private readonly int _y;

		public Y(int y)
		{
			_y = y;
		}

		protected bool Equals(Y other)
		{
			return _y == other._y;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((Y) obj);
		}

		public override int GetHashCode()
		{
			return _y;
		}
	}
}