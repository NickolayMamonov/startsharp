using System;

namespace Task2
{
    public class Repair : Wash
    {
        private bool Broken { get; set; }
        public Repair(string brand, string model, bool washed, bool broken ) : base(brand,model,washed)
        {
            Broken= broken;
        
        }
        public virtual void RepairCar()
        {
            if (Broken == true)
            {
                Broken = false;
                Console.WriteLine("The car was repaired!");
                
            }
            else
            {
                Console.WriteLine("The car is whole!");
            }
            
            
        }
    }
    
}