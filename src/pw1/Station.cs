using System;
using System.Diagnostics.Contracts;

namespace oop_pw1_ext
{
    public class Station
    {
        public List<Platform> Platforms { get; set; }
        public List<Train> Trains { get; set; }

        public Station()
        {
            Platforms = new List<Platform>();
            Trains = new List<Train>();
        }

        public void AddPlatform(Platform platform)
        {
            Platforms.Add(platform);
        }

        public void AddTrain(Train train)
        {
            Trains.Add(train);
        }

        public void DisplayStatus()
        {
            Console.WriteLine("--- Platforms ---");
            foreach (var platform in Platforms)
            {
                Console.WriteLine($"Platform {platform.ID}: Status = {platform.Status}, CurrentTrin = {(platform.CurrentTrain != null ? platform.CurrentTrain.ID : "None")}");
            }
        }
    }
}