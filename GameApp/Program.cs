namespace GameApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Initialization.InitializeGame();
			GameBL.StartGame();


			//var players = PlayerFactory.GeneratePlayers();
			//var matchGames = MatchFactory.GenerateMatches();
			//var moves = MoveFactory.GenerateMoves();

			//var opponent = Initialization.SelectOpponent(players);
			//var match = Initialization.SelectMatch(matchGames);

			//Console.WriteLine("Are you ready? (y/n)");
			//var userResponse = Console.ReadLine();

			//if (userResponse != "y")
			//{
			//	return;
			//}
			//else
			//{
			//	Console.WriteLine("Start game!");

			//	for (int i = 0; i < match.NumberOfGames; i++)
			//	{
			//		Console.WriteLine($"Round {i+1}");

			//		var humanPlayer = players[0];
			//		humanPlayer.SelectMove(moves);
			//		opponent.SelectMove(moves);

			//		Console.WriteLine("========================||===================");
			//		Console.WriteLine("Let's see the moves!");

			//		humanPlayer.DisplaySelectedMove();
			//		opponent.DisplaySelectedMove();

			//		Console.WriteLine("========================||===================");


			//		if(humanPlayer.Move.MoveName == opponent.Move.MoveName)
			//		{
			//			Console.WriteLine("No winner this round!");
			//		}
			//		else if (humanPlayer.Move.IsWinner(opponent.Move))
			//		{
			//			match.Winners.Add(humanPlayer);
			//			Console.WriteLine("You won this round!");
			//		}
			//		else
			//		{
			//			match.Winners.Add(opponent);
			//			Console.WriteLine("You lost this round!");
			//		}
			//	}

			//	match.GetWinner();
			//}

		}
	}
}
