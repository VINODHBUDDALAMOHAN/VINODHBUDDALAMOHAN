using System;
using NasaRover;

namespace NasaRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rover position :");
            string roverPositionInput = Console.ReadLine();
            INasaRover nasaRover = new RoverMovementBao();
            RoverMovement roverMovement = new RoverMovement(roverPositionInput, nasaRover);
            Console.WriteLine("Rover command :");
            string roverNavigation = Console.ReadLine();
            string res = roverMovement.Navigate(roverNavigation);
            Console.WriteLine("expected output is:" + " " + res);
            Console.Write("Press <enter> to exit...");
            Console.ReadLine();
        }
    }
}
