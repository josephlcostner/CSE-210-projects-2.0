using System;
using System.Reflection.Metadata.Ecma335;

namespace Road
{
    class StationaryBikes
    {
        public void Ride()
        {
            int laps, time;
            DateTime currentDateTime = DateTime.Now;
            
            Console.Write("Please enter how many laps you biked today: ");
            laps = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("How long did you bike for in minutes: ");
            time = Convert.ToInt32(Console.ReadLine());

            int Distance = laps * 50 / 1000;
            int Speed = (Distance / time) * 60;
            int Pace = time / Distance;
                
            Console.Write($"{currentDateTime}, Running({time}, Distance({laps}), Speed({Speed}), Pace({Pace}))");
        }
    }
}