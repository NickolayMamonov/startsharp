namespace Task2
{
    
    public abstract class Car
    {
        private string _brand;
        private string _model;
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

        public abstract void CleanZ();
        public Car(string brand, string model)
        {
            this.Brand = brand;
            this.Model = model;
        }
        
    }
}