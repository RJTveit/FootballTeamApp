using System;

namespace FootballTeamApp
{
    class FootballGame
    {
        static void Main(string[] args)
        {
            Quarterback PatrickMahomes = new Quarterback();
            PatrickMahomes.Name = "Patrick Mahomes";
            PatrickMahomes.Age = 25;
            PatrickMahomes.School = "Texas Tech";

            PatrickMahomes.dropBack = 5;
            PatrickMahomes.direction = "left";
            PatrickMahomes.passComplete = "complete";

            HeadCoach AndyReid = new HeadCoach();
            AndyReid.coachName = "Andy Reid";
            AndyReid.coachAge = 65;
            AndyReid.CatchPhrase = "How bout them Chiefs";

            RunningBack DWilliams = new RunningBack();
            DWilliams.RBName = "Damien Williams";
            DWilliams.RBAge = 23;
            DWilliams.RBNumber = 25;

            WideReceiver THill = new WideReceiver();
            THill.WRName = "Tyreek Hill";
            THill.WRAge = 27;
            THill.WRNumber = 10;
            THill.WRSchool = "SMU";

            Console.WriteLine("Welcome to Arrowhead Stadium, please press any key to continue");
            Console.ReadKey();
            Console.WriteLine("\n*****CROWD NOISE*****");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.WriteLine("\nNow introducing your Kansas City Chiefs.....");

            AndyReid.CoachIntro();
            Console.ReadKey();

            PatrickMahomes.GameIntro();
            Console.ReadKey();

            THill.WRIntro();
            Console.ReadKey();

            DWilliams.RBIntro();
            Console.ReadKey();

            Console.WriteLine("\n*****CROWD NOISE*****");
            Console.WriteLine("\nPress any key to begin the game");
            Console.ReadKey();

            PatrickMahomes.PassPlay();

        }

    }

}
