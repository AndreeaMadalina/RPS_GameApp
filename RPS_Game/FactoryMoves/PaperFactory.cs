using RPS_Game.Moves;

namespace RPS_Game.FactoryMoves
{
	public class PaperFactory : MoveFactory
	{
		public override IMove FactoryMethod()
		{
			return new Paper();
		}
	}
}
