namespace RPS_Game.Moves
{
	class Rock : IMove
	{
		public string MoveName => nameof(Rock);
		public bool IsWinner(IMove oponentMove)
		{
			switch (oponentMove.MoveName)
			{
				case nameof(Scissors):
					{
						return true;
					}
				case nameof(Paper):
					{
						return false;
					}
				default:
					return false;
			}
		}
	}
}
