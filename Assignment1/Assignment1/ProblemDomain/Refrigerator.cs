using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.ProblemDomain
{
    public class Refrigerator : Appliance
    {
        private int numberOfDoors;
        private double height;
        private double width;
        public Refrigerator(long itemNumber, string brand, int quantitive, double wattage, string color, double price,int numberOfDoors,double height,double width) : base(itemNumber, brand, quantitive, wattage, color, price)
        {
            this.NumberOfDoors = numberOfDoors;
            this.Height = height;
            this.Width = width;
        }

        public int NumberOfDoors { get => numberOfDoors; set => numberOfDoors = value; }
        public double Height { get => height; set => height = value; }
        public double Width { get => width; set => width = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
