using RPS_Game.Moves;
using System.Collections.Generic;

namespace Player
{
	public abstract class Player
	{
		public string PlayerName { get; set; }
		public IMove Move { get; set; }

		public virtual void SelectMove(List<IMove> moves) { }

		public virtual void DisplaySelectedMove() { }
	}
}
