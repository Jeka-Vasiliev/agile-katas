namespace AgileKatas
{
	public class X
	{
		private readonly int _x;

		public X(int x)
		{
			_x = x;
		}

		protected bool Equals(X other)
		{
			return _x == other._x;
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((X) obj);
		}

		public override int GetHashCode()
		{
			return _x;
		}
	}
}