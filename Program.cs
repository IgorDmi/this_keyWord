using System;

namespace this_keyWord
{
    class Aircraft
    {
        public string Manufacturer;
        public string Model;

        public Aircraft(string Manufacturer, string Model)
        {
            this.Manufacturer = Manufacturer;
            this.Model = Model;
        }

        public string GetName()
        {
            return ($"{Manufacturer}, {Model}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Aircraft plane1 = new Aircraft("Comac", "C919");

            Console.WriteLine(plane1.GetName());
        }
    }
}
