using RPS_Game.Moves;

namespace RPS_Game.FactoryMoves
{
	public class ScissorsFactory : MoveFactory
	{
		public override IMove FactoryMethod()
		{
			return new Scissors();
		}
	}
}
