using System;

namespace GameOfLife
{
	public class Cell
	{
		private int _status = 0;
		public int _nextStatus = 0;

		public bool isAlive ()
		{
			return _status == 1 ? true : false;
		}

		public bool IsAliveNextCycle()
		{
			return _nextStatus == 1 ? true : false;
		}

		public void Die ()
		{
			_status = 0;
		}

		public void Live ()
		{
			_status = 1;
		}

		public void KillNextCycle()
		{
			_nextStatus = 0;
		}

		public void ReviveNextCycle()
		{
			_nextStatus = 1;
		}

	}
}
