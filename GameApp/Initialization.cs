using GameApp.Model;
using Match;
using Match.FactoryMatch;
using Player.FactoryPlayer;
using RPS_Game.FactoryMoves;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp
{
	public static class Initialization
	{
		public static void InitializeGame()
		{

			GameModel.Players = PlayerFactory.GeneratePlayers();
			GameModel.Matches = MatchFactory.GenerateMatches();
			GameModel.Moves = MoveFactory.GenerateMoves();
		}

		public static IMatch SelectMatch(List<IMatch> matchGames)
		{
			Console.WriteLine($"Select your match (type the match number): ");
			for (int i = 0; i < matchGames.Count; i++)
			{
				Console.WriteLine($"{i+1}: Number of games {matchGames[i].NumberOfGames}");
			}

			string playerResponse = Console.ReadLine();
			int matchNo = -1;
			int.TryParse(playerResponse, out matchNo);

			while (matchNo - 1 == -1 || matchNo - 1 > matchGames.Count - 1)
			{
				Console.WriteLine("Please select a correct number!");
				playerResponse = Console.ReadLine();
				int.TryParse(playerResponse, out matchNo);
			}

			return matchGames[matchNo - 1];
		}

		public static Player.Player SelectOpponent(List<Player.Player> players)
		{
			Console.WriteLine($"Select your oponent (type the oponent number): ");
			for (int i = 1; i < players.Count; i++)
			{
				Console.WriteLine($"{i}: {players[i].PlayerName}");
			}

			string playerResponse = Console.ReadLine();
			int opponentNo;
			int.TryParse(playerResponse, out opponentNo);

			while (opponentNo == 0 || opponentNo > players.Count - 1)
			{
				Console.WriteLine("Please select a correct number!");
				playerResponse = Console.ReadLine();
				int.TryParse(playerResponse, out opponentNo);
			}

			return players[opponentNo];
		}
	}
}
