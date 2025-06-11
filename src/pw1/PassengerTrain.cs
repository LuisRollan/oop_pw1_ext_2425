using System;

namespace oop_pw1_ext
{
    public class PassengerTrain : Train
    {
        
        protected int NumberOfCarriages { get; set; }

        protected int Capacity { get; set; }
        public PassengerTrain(string id, string type, int ArrivalTime, int NumberOfCarriages, int Capacity) : base(id, type, ArrivalTime)
        {

            NumberOfCarriages = NumberOfCarriages;
            Capacity = Capacity;

        }
        
    }
}