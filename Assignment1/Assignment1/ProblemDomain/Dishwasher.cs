using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.ProblemDomain
{
    public class Dishwasher : Appliance
    {
        private double sound;
        private double rating;
        private string feature;
        public Dishwasher(long itemNumber, string brand, int quantitive, double wattage, string color, double price,double sound,double rating, string feature) : base(itemNumber, brand, quantitive, wattage, color, price)
        {
            this.Sound = sound;
            this.Rating = rating;
            this.Feature = feature;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public double Sound { get => sound; set => sound = value; }
        public double Rating { get => rating; set => rating = value; }
        public string Feature { get => feature; set => feature = value; }
    }
}
