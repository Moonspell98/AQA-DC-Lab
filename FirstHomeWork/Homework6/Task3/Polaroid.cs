namespace AutomationCources.Lecture_7.Homework
{
    public class Polaroid
    {
        private int paperWidth;
        private int paperHeight;
        private double numberOfPixelsInCamera;
        private string? modelName;
        private decimal price;

        public Polaroid(int paperWidth, int paperHeight, double numberOfPixelsInCamera, string? modelName, decimal price)
        {
            this.paperWidth = paperWidth;
            this.paperHeight = paperHeight;
            this.numberOfPixelsInCamera = numberOfPixelsInCamera;
            this.modelName = modelName;
            this.price = price;
        }

        public string Description
        {
            get
            {
                return $"Price: {price}, model:{modelName}, number of pixels in camera: {numberOfPixelsInCamera}";
            }
        }

        public void TakePhoto()
        {
            Console.WriteLine("Press black button at the top and photo is ready");
        }

        public void Print()
        {
            Console.WriteLine("Printing...");
        }

        public void TurnOn()
        {
            Console.WriteLine("Press right side button");
        }

        public void TunrnOff()
        {
            Console.WriteLine("Press Turn Off button");
        }
    }
}
