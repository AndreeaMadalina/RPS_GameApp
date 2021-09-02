namespace Match.FactoryMatch
{
	class BestOfThreeFactory : MatchFactory
	{
		public override IMatch FactoryMethod()
		{
			return new BestOfThree();
		}
	}
}
