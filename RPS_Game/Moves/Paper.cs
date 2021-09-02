namespace RPS_Game.Moves
{
	class Paper : IMove
	{
		public string MoveName => nameof(Paper);
		public bool IsWinner(IMove oponentMove)
		{
			switch (oponentMove.MoveName)
			{
				case nameof(Rock):
					{
						return true;
					}
				case nameof(Scissors):
					{ 
						return false; 
					}
				default:
					return false;
			}
		}
	}
}
