using System;

namespace MyFirstGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Arnold = new Player("Arnold Schwarzenegger");
            Player Chuck = new Player("Chuck Norris");

            for (int i=0; i<3; i++)
            {
                Arnold.TakeDamage(Chuck.MakeDamage());
                Console.WriteLine(Arnold.HealthPoint);
                Chuck.TakeDamage(Arnold.MakeDamage());
                Console.WriteLine(Chuck.HealthPoint);

            }

            if (Arnold.HealthPoint>Chuck.HealthPoint)
            {
                Console.WriteLine($"Arnold you are winner! He has {Arnold.HealthPoint} points.");
            }
            else if (Chuck.HealthPoint>Arnold.HealthPoint)
            {
                Console.WriteLine($"Chuck you are winner! You have {Chuck.HealthPoint} points.");
            }
            else
            {
                Console.WriteLine("Its a tie");
            }

        }
    }
}

