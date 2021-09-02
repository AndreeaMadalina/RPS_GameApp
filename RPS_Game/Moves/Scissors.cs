namespace RPS_Game.Moves
{
	class Scissors : IMove
	{
		public string MoveName => nameof(Scissors);
		public bool IsWinner(IMove oponentMove)
		{
			switch (oponentMove.MoveName)
			{
				case nameof(Paper):
					{
						return true;
					}
				case nameof(Rock):
					{
						return false;
					}
				default:
					return false;
			}
		}
	}
}
