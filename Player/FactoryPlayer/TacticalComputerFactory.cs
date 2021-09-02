namespace Player.FactoryPlayer
{
	class TacticalComputerFactory : PlayerFactory
	{
		public override Player FactoryMethod()
		{
			return new TacticalComputer();
		}
	}
}
