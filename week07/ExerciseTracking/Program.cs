using System;
using Road;
using SideWalk;
using Water;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        SwimmingLaps swimmingLaps = new SwimmingLaps();
        swimmingLaps.Swim();
        StationaryBikes stationaryBikes = new StationaryBikes();
        stationaryBikes.Ride();
        Running running = new Running();
        running.Run();
    }
}