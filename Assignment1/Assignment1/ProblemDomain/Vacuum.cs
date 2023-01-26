using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.ProblemDomain
{
    public class Vacuum : Appliance
    {
        private double grade;
        private double batteryVoltage;

        public Vacuum(long itemNumber, string brand, int quantitive, double wattage, string color, double price, double grade,double batteryVoltage) : base(itemNumber, brand, quantitive, wattage, color, price)
        {
            this.Grade = grade;
            this.BatteryVoltage = batteryVoltage;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public double Grade { get => grade; set => grade = value; }
        public double BatteryVoltage { get => batteryVoltage; set => batteryVoltage = value; }
    }
}
