using System;

namespace Task2
{
    public class Wash : Car
    {
        private bool Washed { get; set; }

        public Wash(string brand, string model, bool washed) : base(brand, model)
        {
            Washed = washed;
        }

        public override void CleanZ()
        {
            Console.WriteLine("The mirrors were washed!");
        }

        public void Washe()
        {
            if (Washed == false)
            {
                Console.WriteLine("The car was washed!");
            }
            else
            {
                Console.WriteLine("The car is already clear!");
            }
        }
    }
}
