using System;
using GameOfLife;

namespace GameOfLife
{
	public class Program
	{
		static Grid<Cell> grid;
		static EcoSystem ecosystem;

		static void Main (string[] args)
		{
			grid = MakeGrid (3, 3, new Cell());
			ecosystem = new EcoSystem(grid);
		}

		static Grid<Cell> MakeGrid (int length, int width, Cell cell)
		{
			grid = new Grid<Cell> (length, width, cell);
			return grid;
		}
//
//		public void DisplayGrid()
//		{
//		}
//
//		public void AnimateGrid()
//		{
//		}

	}
}

