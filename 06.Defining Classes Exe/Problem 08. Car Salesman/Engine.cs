
namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Engine
    {
        private const string DefaultValueString = "n/a";
        private const int DefaultValueInt = -1;

        private string model;
        private int power;
        private int displacement;
        private string efficiency;

        public Engine(string model, int power, int displacement, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement)
            : this(model, power, displacement, DefaultValueString)
        {
        }

        public Engine(string model, int power, string efficiency)
            : this(model, power, DefaultValueInt, efficiency)
        {
        }

        public Engine(string model, int power)
            :this(model, power, DefaultValueInt, DefaultValueString)
        {
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public int Power
        {
            get { return this.power; }
            set { this.power = value; }
        }

        public int Displacement
        {
            get { return this.displacement; }
            set { this.displacement = value; }
        }

        public string Efficiency
        {
            get { return this.efficiency; }
            set { this.efficiency = value; }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"  {Model}:");
            builder.AppendLine($"    Power: {Power}");
            builder.AppendLine($"    Displacement: {(Displacement == -1 ? "n/a" : Displacement.ToString())}");
            builder.AppendLine($"    Efficiency: {(Efficiency == null ? "n/a" : Efficiency.ToString())}");

            return builder.ToString();
        }
    }
}
