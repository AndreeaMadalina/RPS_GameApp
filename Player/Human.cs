using RPS_Game.Moves;
using System;
using System.Collections.Generic;

namespace Player
{
	class Human : Player
	{
		public Human()
		{
			PlayerName = typeof(Human).Name;
		}

		public override void DisplaySelectedMove()
		{
			Console.WriteLine($"Your selected move is: {Move.MoveName}");
		}

		public override void SelectMove(List<IMove> moves)
		{
			Console.WriteLine($"Select your move (type the move number): ");
			for (int i = 0; i < moves.Count; i++)
			{
				Console.WriteLine($"{i+1}: {moves[i].MoveName}");
			}

			
			string playerResponse = Console.ReadLine();
			int moveNo = -1;
			int.TryParse(playerResponse, out moveNo);

			while (moveNo - 1 == -1 || moveNo - 1 > moves.Count - 1)
			{
				Console.WriteLine("Please select a correct number!");
				playerResponse = Console.ReadLine();
				int.TryParse(playerResponse, out moveNo);
			}

			Move = moves[moveNo - 1];
		}
	}
}
