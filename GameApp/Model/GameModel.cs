using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Model
{
	public static class GameModel
	{
		public static List<Player.Player> Players { get; set; }
		public static List<Match.IMatch> Matches { get; set; }
		public static List<RPS_Game.Moves.IMove> Moves { get; set; }
	}
}
