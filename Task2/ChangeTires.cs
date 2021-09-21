using System;

namespace Task2
{
    public class ChangeTires : Car
    {
        private string _tires;
        public string Tires {
            get
            {
                return _tires;
            }
            set
            {
                if (value == "summer" || value == "winter")
                {
                    _tires = value;
                }
            }}

        public ChangeTires(string brand, string model, string tires) : base(brand, model)
        {
            Tires = tires;
        }

        public override void CleanZ()
        {
            Console.WriteLine("The mirrors were washed!");
        }

        public void ChangeT()
        { 
            if (Tires == "summer")
            {
                Tires = "winter";
                Console.WriteLine("The tires was replaced with winter tires!");
            }
            else
            {
                Tires = "summer";
                Console.WriteLine("The tires was replaced with summer tires!");
            }
        }
    }
}