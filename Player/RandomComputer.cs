using RPS_Game.Moves;
using System;
using System.Collections.Generic;

namespace Player
{
	class RandomComputer : Player
	{
		public RandomComputer()
		{
			PlayerName = typeof(RandomComputer).Name;
		}

		public override void DisplaySelectedMove()
		{
			Console.WriteLine($"The opponent move is: {Move.MoveName}");
		}

		public override void SelectMove(List<IMove> moves)
		{
			Console.WriteLine($"Opponent's turn.");

			Random rnd = new Random();
			Move = moves[rnd.Next(0, moves.Count)];
		}
	}
}
