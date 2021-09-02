using System.Collections.Generic;

namespace Match
{
	public interface IMatch
	{
		int NumberOfGames { get; }

		List<Player.Player> Winners { get; }

		void GetWinner();
	}
}
