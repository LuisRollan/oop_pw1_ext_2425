using System;

namespace oop_pw1_ext
{
    public class PassengerTrain : Train
    {
        
        protected int NumberOfCarriages { get; set; }

        protected int Capacity { get; set; }
        public PassengerTrain(string id, string type, int arrivalTime, int numberOfCarriages, int capacity) : base(id, type, arrivalTime)
        {

            this.NumberOfCarriages = numberOfCarriages;
            this.Capacity = capacity;

        }
        
    }
}