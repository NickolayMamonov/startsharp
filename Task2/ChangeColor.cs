using System;

namespace Task2
{
    public class ChangeColor : Car
    {
        private string[] colors =
        {
            "Black","White","Yellow","Blue","Green","Red"
        };
        public override void CleanZ()
        {
            Console.WriteLine("The mirrors were washed!");
        }
        public string Color { get; set; }
        public ChangeColor(string brand, string model, string color) : base( brand,model)
        {
            Color = color;
        }

        public void ChangeC()
        {
            int rndm = new Random().Next(colors.Length);
            Color = colors[rndm];
            
            Console.WriteLine("The new color is: " + colors[rndm]);
        }
    }
}