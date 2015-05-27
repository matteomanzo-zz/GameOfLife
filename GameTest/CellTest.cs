using NUnit.Framework;
using System;

namespace GameOfLife
{
	[TestFixture ()]
	public class CellTest
	{
		Cell cell;
		Cell livecell;

		[SetUp]
		public void Init ()
		{
			cell = new Cell ();
			livecell = new Cell (1);
		}

		[Test ()]
		public void ShouldNotBeAliveByDefault ()
		{
			Assert.IsFalse (cell.isAlive());
		}

		[Test ()]
		public void SomeCellsWillBeAlive ()
		{
			Assert.IsTrue (livecell.isAlive() );
		}

		[Test ()]
		public void AnAliveCellCanDie ()
		{
			livecell.Die ();
			Assert.IsFalse (livecell.isAlive() );
		}

		[Test ()]
		public void ADeadCellCanRevive ()
		{
			cell.Revive ();
			Assert.IsTrue (cell.isAlive() );
		}
	}
}

