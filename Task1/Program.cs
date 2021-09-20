using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Auto-repair shop located at: " + Cars.Adress);
            Cars car = new Cars("BMW", "X5", "Blue",false);
            car.WashCar(car.Washed);
            Cars car2 = new Cars("BMW", "X5", "Blue","summer");
            car2.ChangeTires(car2.Tires);
            Cars car3 = new Cars("Auid", "A3", "White");
            Cars.WashCar();
            car3.ChangeColor();
            Cars car4 = new Cars("Auid", "A3", "White", false,true,"winter");
            car4.RepairCar();

        }
    }
}