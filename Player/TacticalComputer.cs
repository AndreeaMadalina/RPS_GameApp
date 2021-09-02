using RPS_Game.Moves;
using System;
using System.Collections.Generic;

namespace Player
{
	class TacticalComputer : Player
	{
		public TacticalComputer()
		{
			PlayerName = typeof(TacticalComputer).Name;
		}

		public override void DisplaySelectedMove()
		{
			Console.WriteLine($"The opponent move is: {Move.MoveName}");
		}

		public override void SelectMove(List<IMove> moves)
		{
			Console.WriteLine($"Opponent's turn.");

			if (Move == null)
			{
				Random rnd = new Random();
				Move = moves[rnd.Next(0, moves.Count)];
			}
			else
			{
				foreach (var move in moves)
				{
					if(move.MoveName != Move.MoveName && Move.IsWinner(move))
					{
						Move = move;
						break;
					}
				}				
			}
		}
	}
}
