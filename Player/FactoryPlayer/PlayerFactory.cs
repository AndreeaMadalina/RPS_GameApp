using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Player.FactoryPlayer
{
	public abstract class PlayerFactory
	{
		public abstract Player FactoryMethod();

		public static List<Player> GeneratePlayers ()
		{
			List<Player> players = new List<Player>();

			List<PlayerFactory> creators = new List<PlayerFactory>();
			foreach (Type type in
				Assembly.GetAssembly(typeof(PlayerFactory)).GetTypes()
				.Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(PlayerFactory))))
			{
				creators.Add((PlayerFactory)Activator.CreateInstance(type));
			}

			foreach (var creator in creators)
			{
				players.Add(creator.FactoryMethod());
			}

			return players;
		}
	}
}
