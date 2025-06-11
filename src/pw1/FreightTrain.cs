using System;

namespace oop_pw1_ext
{
    public class FreightTrain : Train
    {

        protected int MaxWeight { get; set; }

        protected string FreightType { get; set; }

        public FreightTrain(string id, string type, int ArrivalTime, int MaxWeight, string FreightType) : base(id, type, ArrivalTime)
        {
            this.MaxWeight = MaxWeight;
            this.FreightType = FreightType;

        }

        

    }
}