namespace AgileKatas
{
	public class Coordinate
	{
		private readonly X _x;
		private readonly Y _y;

		public Coordinate(X x, Y y)
		{
			_x = x;
			_y = y;
		}

		protected bool Equals(Coordinate other)
		{
			return Equals(_x, other._x) && Equals(_y, other._y);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((Coordinate) obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return ((_x != null ? _x.GetHashCode() : 0) * 397) ^ (_y != null ? _y.GetHashCode() : 0);
			}
		}
	}
}