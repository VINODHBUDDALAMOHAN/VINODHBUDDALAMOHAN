using System;

namespace NasaRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rover position :");
            string roverPositionInput = Console.ReadLine();
            RoverMovement roverMovement = new RoverMovement(roverPositionInput);
            Console.WriteLine("Rover command :");
            string roverNavigation = Console.ReadLine();
            string res = roverMovement.Navigate(roverNavigation);
            Console.WriteLine("expected output is:" + " " + res);
            Console.Write("Press <enter> to exit...");
            Console.ReadLine();
        }
    }
}
