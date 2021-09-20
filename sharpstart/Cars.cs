using System;
using System.Diagnostics;

namespace sharpstart
{
    public class Cars
    {
        // свойства
        protected int id;
        public static string Adress = "Moscow,Obraztsova street,9";
        public string Tyres;
        private string _model;
        private string _brand;
        public bool Washed { get; set; }
        public string Color { get; set; }
        private bool Broken { get; set; }
        
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
        public Cars(string brand, string model, string color, bool washed, bool broken,string tyres)
        {
            this.Brand = brand;
            this.Model = model;
            this.Washed = washed;
            this.Broken = broken;
            this.Color = color;
            this.Tyres = tyres;
        }
            
        public Cars(string brand, string model,string color,bool washed)
        {
            this.Brand = brand;
            this.Model = model;
            this.Washed = washed;
            this.Broken = true;
            this.Color= color;
            this.Tyres = "summer";
        }

        public Cars(string brand, string model, string color)
        {
            this.Brand = brand;
            this.Model = model;
            this.Washed = true;
            this.Broken = false;
            this.Color = color;
            this.Tyres = "summer";
        }
        public Cars(string brand, string model,string color, string tyres)
        {
            this.Brand = brand;
            this.Model = model;
            this.Washed = false;
            this.Broken = false;
            this.Color = color;
            this.Tyres = tyres;
        }
        // Методы
        public void ChangeColor()
        {
           
        }

        public void WashCar()
        {
            Washed = true;
        }

        public void RepairCar()
        {
            Broken = false;
        }

        public static void ChangeTyres(string Tyres)
        {
            if (Tyres == "summer")
            {
                Tyres = "winter";
            }

        }
        
        
        //Финализатор
        
    }
}

