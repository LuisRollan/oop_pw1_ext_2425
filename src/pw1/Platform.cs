using System;

namespace oop_pw1_ext
{
    public class Platform
    {
        protected string ID { get; set; }
        protected enum PlatformStatus { Free, Occupied }
        protected PlatformStatus Status { get; set; }

        protected int DockingTime { get; set; }

        protected Train CurrentTrain { get; set; }

        public Platform(string id, int dockingTime)
        {
            this.ID = id;
            this.DockingTime = dockingTime;
            Status = PlatformStatus.Free;
            this.CurrentTrain = null;
        }


    }
    
}