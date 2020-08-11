using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamApp
{
	public class WideReceiver
	{
		public string WRName;
		public int WRAge;
		public int WRNumber;
		public string WRSchool;

		public void WRIntro()
		{
			Console.WriteLine($"\nMy name is {WRName}, {WRAge} years old, number {WRNumber} and I attended {WRSchool}");
		}

		public static string DeepRoute(string deepRoute)
		{
			deepRoute = "\nThe receiver runs a deep route";

			return deepRoute;
		}

		public static string QuickRoute(string quickRoute)
		{
			quickRoute = "\nThe receiver runs a quick slant route";

			return quickRoute;
		}

		public static string CatchPass(string catchPass)
		{
			catchPass = "\nThe receiver catches the pass";

			return catchPass;
		}
	}
}
