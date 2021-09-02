using System;
using System.Collections.Generic;
using System.Linq;

namespace Match
{
	public abstract class Game : IMatch
	{
		public virtual int NumberOfGames { get; }

		public List<Player.Player> Winners { get; }

		public Game()
		{
			Winners = new List<Player.Player>();
		}

		public void GetWinner()
		{
			var result = Winners.GroupBy(winner => new { winner.PlayerName })
						.Select(group => new {
							group.Key.PlayerName,
							Count = group.Count()
						}).ToList();

			if(result.Count == 0 || (result.Count == 2 && result[0].Count == result[1].Count))
			{
				Console.WriteLine($"Nobody won.");
			}

			var maxNo = result.Max(r => r.Count);
			var winner = result.FirstOrDefault(r => r.Count == maxNo);
			Console.WriteLine($"The winner is {winner?.PlayerName}.");
		}
	}
}
