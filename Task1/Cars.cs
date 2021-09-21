using System;
using System.Diagnostics;

namespace Task1
{
    public class Cars
    {
        // свойства
        public static readonly string Adress = "Moscow,Obraztsova street,9";
        private string _model;
        private string _brand;
        private string _tires;

        public string Color { get; set; }
        public bool Washed { get; set; }

        private string[] colors =
        {
            "Black","White","Yellow","Blue","Green","Red"
        };
        private bool Broken { get; set; }

        public string Tires
        {
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
            }
        }

        public string Brand
       
        {
            get
            {
                return _brand;
            }
            set
            {
                if (value != "")
                    _brand = value;
                else _brand = "Invalid car brand!";
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                if (value != "")
                    _model = value;
                else _model = "Invalid car brand model!";
            }
        }
        
        // Конструкторы
        public Cars(string brand, string model, string color, bool washed, bool broken,string tires)
        {
            this.Brand = brand;
            this.Model = model;
            this.Washed = washed;
            this.Broken = broken;
            this.Color = color;
            this.Tires = tires;
        }
            
        public Cars(string brand, string model,string color,bool washed)
        {
            this.Brand = brand;
            this.Model = model;
            this.Washed = washed;
            this.Broken = true;
            this.Color= color;
            this.Tires = "summer";
        }

        public Cars(string brand, string model, string color)
        {
            this.Brand = brand;
            this.Model = model;
            this.Washed = true;
            this.Broken = false;
            this.Color = color;
            this.Tires = "summer";
        }
        public Cars(string brand, string model,string color, string tires)
        {
            this.Brand = brand;
            this.Model = model;
            this.Washed = false;
            this.Broken = false;
            this.Color = color;
            this.Tires = tires;
        }
        // Методы
        public void ChangeColor()
        {
            int rndm = new Random().Next(colors.Length);
            Color = colors[rndm];
            
            Console.WriteLine("The new color is: " + colors[rndm]);
        }

        public void WashCar(bool washed)
        {
            if (washed == false)
            {
                Console.WriteLine("The car was washed!");
                Washed = true;
            }
            else
            {
                Console.WriteLine("The car is clear!");
            }
        }

        public static void WashCar()
        {
            Console.WriteLine("The car was washed!");
        }

        public void RepairCar()
        {
            Broken = false;
            Console.WriteLine("The car was repaired!");
        }

        public void ChangeTires(string tires)
        {
            if (tires == "summer")
            {
                tires = "winter";
                Console.WriteLine("The tires was replaced with winter tires!");
            }
            else
            {
                tires = "summer";
                Console.WriteLine("The tires was replaced with summer tires!");
            }

        }
        
        
        //Финализатор
        ~Cars()
        {
            Console.WriteLine("All works is done!");
        }
    }
}

