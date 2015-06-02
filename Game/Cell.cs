using System;

namespace GameOfLife
{
	public class Cell
	{
		private int _status = 0;

		public bool isAlive ()
		{
			if (_status == 1) {
				return true;
			}

			return false;
		}

		public void Die ()
		{
			_status = 0;
		}

		public void Live ()
		{
			_status = 1;
		}

		public string DisplaysStatus()
		{
			string display = isAlive () ? "*" : "_";
			return display;
		}

	}
}
