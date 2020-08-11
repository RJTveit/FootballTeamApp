using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamApp
{
	public class Quarterback
	{
		public string Name;
		public int Age;
		public string School;

		public int dropBack;
		public string direction;
		public string passComplete;

		public void GameIntro()
		{
			Console.WriteLine($"\nHey everyone, I am {Name} I am {Age} years old, and I attended {School}");
		}

		public void PassPlay()
		{
			Console.WriteLine($"\n{Name} makes a {dropBack} step drop, looks {direction}, throws, the pass is {passComplete}");
		}

		public void ThrowPass()
		{
			Console.WriteLine($"\n{Name} throws the ball");
		}

		public void HandOff()
		{
			Console.WriteLine($"\n{Name} hands the ball off to the running back");
		}
	}
}
