using System;


namespace oop_pw1_ext
{
    public class Train
    {
        protected string ID { get; set; }
        protected enum TrainStatus { EnRoute, Waiting, Docking, Docked }

        protected int ArrivalTime { get; set; }

        protected string Type { get; set; }

        protected TrainStatus Status { get; set; }
        public Train(string id, string type, int ArrivalTime)
        {
            ID = id;
            Type = type;
            ArrivalTime = ArrivalTime;
            Status = TrainStatus.EnRoute;
        }




    }


}