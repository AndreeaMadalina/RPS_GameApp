using RPS_Game.Moves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RPS_Game.FactoryMoves
{
	public abstract class MoveFactory
	{
		public abstract IMove FactoryMethod();

		public static List<IMove> GenerateMoves()
		{
			List<IMove> moves = new List<IMove>();

			List<MoveFactory> creators = new List<MoveFactory>();
			foreach (Type type in
				Assembly.GetAssembly(typeof(MoveFactory)).GetTypes()
				.Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(MoveFactory))))
			{
				creators.Add((MoveFactory)Activator.CreateInstance(type));
			}

			foreach (var creator in creators)
			{
				moves.Add(creator.FactoryMethod());
			}

			return moves;
		}
	}
}
