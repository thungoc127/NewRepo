using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.ProblemDomain
{
    public class Microwave : Appliance
    {
        private double capacity;
        private string roomType;

        public Microwave(long itemNumber, string brand, int quantitive, double wattage, string color, double price,double capacity, string roomType) : base(itemNumber, brand, quantitive, wattage, color, price)
        {
            this.Capacity = capacity;
            this.roomType = roomType;
        }

        public double Capacity { get => capacity; set => capacity = value; }
        public string RoomType { get => roomType; set => roomType = value; }
    }
}
