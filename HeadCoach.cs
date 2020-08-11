using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamApp
{
	public class HeadCoach
	{

		public string coachName;
		public int coachAge;
		public string CatchPhrase;

		public void CoachIntro()
		{
			Console.WriteLine($"\nI'm {coachName}, I am {coachAge}, and {CatchPhrase}");
		}

		public void PassPlayCall()
		{
			Console.WriteLine("\n2-3 Jet Chip Wasp");
		}
		public void RunPlayCall()
		{
			Console.WriteLine("\nShift Rose Bowl Right Parade.");
		}

		public void CallTimeOut()
		{
			Console.WriteLine("\nTime out, time out, time out");
		}

	}
}
