using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Appliance
    {
        private long itemNumber;
        private string brand;
        private int quantitive;
        private double wattage;
        private string color;
        private double price;

        public long ItemNumber { get => itemNumber; set => itemNumber = value; }
        public string Brand { get => brand; set => brand = value; }
        public int Quantitive { get => quantitive; set => quantitive = value; }
        public double Wattage { get => wattage; set => wattage = value; }
        public string Color { get => color; set => color = value; }
        public double Price { get => price; set => price = value; }

        public Appliance(long itemNumber, string brand, int quantitive, double wattage, string color, double price)
        {
            this.itemNumber = itemNumber;
            this.brand = brand;
            this.quantitive = quantitive;
            this.wattage = wattage;
            this.color = color;
            this.price = price;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
