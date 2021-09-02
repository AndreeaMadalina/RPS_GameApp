namespace Match.FactoryMatch
{
	class BestOfFiveFactory : MatchFactory
	{
		public override IMatch FactoryMethod()
		{
			return new BestOfFive();
		}
	}
}
