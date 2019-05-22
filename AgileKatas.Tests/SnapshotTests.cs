using System;
using AgileKatas;
using FluentAssertions;
using Xunit;

namespace TestProject1
{
	public class SnapshotTests
	{
		[Fact]
		public void Should_throw_exception_when_equals_with_null()
		{
			Action act = () => new Snapshot(Array.Empty<string>()).Equals(null);
			act.Should().Throw<ArgumentNullException>();
		}
	}
}