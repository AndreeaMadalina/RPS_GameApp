namespace Player.FactoryPlayer
{
	class RandomComputerFactory : PlayerFactory
	{
		public override Player FactoryMethod()
		{
			return new RandomComputer();
		}
	}
}
