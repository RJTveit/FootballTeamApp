using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamApp
{
	public class RunningBack
	{
		public string RBName;
		public int RBAge;
		public int RBNumber;
		public void RBIntro()
		{
			Console.WriteLine($"\nI'm {RBName}, {RBAge} years old, and I wear the number {RBNumber}");
		}

		public static string PlayAction(string playAction)
		{
			playAction = "\nThe back fakes the handoff and runs towards the line";

			return playAction;
		}

		public static string InsideRun(string insideRun)
		{
			insideRun = "\nThe back gets the ball and runs up the middle";

			return insideRun;
		}

		public static string OutsideRun(string outsideRun)
		{
			outsideRun = "\nThe back takes the ball and runs to the outside";

			return outsideRun;
		}

	}
}
