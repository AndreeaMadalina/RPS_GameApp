namespace RPS_Game.Moves
{
	public interface IMove
	{
		string MoveName { get; }
		bool IsWinner(IMove computerMove);
	}
}
