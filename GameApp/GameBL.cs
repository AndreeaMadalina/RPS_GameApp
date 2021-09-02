using GameApp.Model;
using System;

namespace GameApp
{
	public static class GameBL
	{
		public static void StartGame()
		{
			var opponent = Initialization.SelectOpponent(GameModel.Players);
			var match = Initialization.SelectMatch(GameModel.Matches);

			Console.WriteLine("Are you ready? (y/n)");
			var userResponse = Console.ReadLine();

			if (userResponse != "y")
			{
				return;
			}
			else
			{
				Console.WriteLine("Start game!");

				for (int i = 0; i < match.NumberOfGames; i++)
				{
					Console.WriteLine("\n\n");
					Console.WriteLine("===================================================");
					Console.WriteLine($"Round {i + 1}");

					var humanPlayer = GameModel.Players[0];
					humanPlayer.SelectMove(GameModel.Moves);
					opponent.SelectMove(GameModel.Moves);

					Console.WriteLine("\n");
					Console.WriteLine("Let's see the moves!");

					humanPlayer.DisplaySelectedMove();
					opponent.DisplaySelectedMove();

					Console.WriteLine("\n");


					if (humanPlayer.Move.MoveName == opponent.Move.MoveName)
					{
						Console.WriteLine("No winner this round!");
					}
					else if (humanPlayer.Move.IsWinner(opponent.Move))
					{
						match.Winners.Add(humanPlayer);
						Console.WriteLine("You won this round!");
					}
					else
					{
						match.Winners.Add(opponent);
						Console.WriteLine("You lost this round!");
					}
				}

				Console.WriteLine("\n\n");
				Console.WriteLine("===================================================");
				match.GetWinner();
			}
		}
	}
}
