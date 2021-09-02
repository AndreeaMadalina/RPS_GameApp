using RPS_Game.Moves;

namespace RPS_Game.FactoryMoves
{
	public class RockFactory : MoveFactory
	{
		public override IMove FactoryMethod()
		{
			return new Rock();
		}
	}
}
