namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;
    
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private List<Tire> tires;

        public Car()
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;
        }

        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;
        }

        public string Model
        {
            get { return this.model; }
            private set { this.model = value; }
        }

        public Engine Engine
        {
            get { return this.engine; }
            private set { this.engine = value; }
        }

        public Cargo Cargo
        {
            get { return this.cargo; }
            private set { this.cargo = value; }
        }

        public List<Tire> Tires
        {
            get { return this.tires; }
            private set { this.tires = value; }
        }

        public void PrintingResult(string command, List<Car> cars)
        {
            if (command == "fragile")
            {
                cars.Where(x => x.Cargo.Type == "fragile")
                    .Where(y => y.Tires.Any(t => t.Pressure < 1))
                    .Select(m => m.Model)
                    .ToList()
                    .ForEach(Console.WriteLine);
            }
            else if (command == "flamable")
            {
                cars.Where(x => x.Cargo.Type == "flamable")
                    .Where(y => y.Engine.Power >= 250)
                    .Select(m => m.Model)
                    .ToList()
                    .ForEach(Console.WriteLine);
            }
        }
    }
}
