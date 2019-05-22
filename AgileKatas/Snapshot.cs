using System.Linq;

namespace AgileKatas
{
	public sealed class Snapshot
	{
		private readonly string[] _strings;

		public Snapshot(string[] strings)
		{
			_strings = strings;
		}

		private bool Equals(Snapshot other)
		{
			return _strings.SequenceEqual(other._strings);
		}

		public override bool Equals(object obj)
		{
			return ReferenceEquals(this, obj) || obj is Snapshot other && Equals(other);
		}

		public override int GetHashCode()
		{
			return (_strings != null ? _strings.GetHashCode() : 0);
		}
	}
}