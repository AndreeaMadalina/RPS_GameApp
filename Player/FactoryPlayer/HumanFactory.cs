namespace Player.FactoryPlayer
{
	class HumanFactory : PlayerFactory
	{
		public override Player FactoryMethod()
		{
			return new Human();
		}
	}
}
