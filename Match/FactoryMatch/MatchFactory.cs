using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Match.FactoryMatch
{
	public abstract class MatchFactory
	{
		public abstract IMatch FactoryMethod();

		public static List<IMatch> GenerateMatches()
		{
			List<IMatch> matchGames = new List<IMatch>();

			List<MatchFactory> creators = new List<MatchFactory>();
			foreach (Type type in
				Assembly.GetAssembly(typeof(MatchFactory)).GetTypes()
				.Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(MatchFactory))))
			{
				creators.Add((MatchFactory)Activator.CreateInstance(type));
			}

			foreach (var creator in creators)
			{
				matchGames.Add(creator.FactoryMethod());
			}

			return matchGames;
		}
	}
}
