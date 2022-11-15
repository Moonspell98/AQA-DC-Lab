using Homework6.Task3;

namespace AutomationCources.Lecture_7.Homework
{
    public class Polaroid : Device, IPrintable, IPhotographic
    {
        public Polaroid(int paperWidth, int paperHeight, double numberOfPixelsInCamera, string? modelName, decimal price)
        {
            PaperWidth = paperWidth;
            PaperHeight = paperHeight;
            NumberOfPixelsInCamera = numberOfPixelsInCamera;
            this.modelName = modelName;
            this.price = price;
        }

        public override string Description
        {
            get
            {
                return base.Description + $", number of pixels in camera {NumberOfPixelsInCamera}";
            }
        }

        public int PaperWidth { get; set; }
        public int PaperHeight { get; set; }
        public double NumberOfPixelsInCamera { get; set; }

        public void TakePhoto()
        {
            Console.WriteLine("Press black button at the top and photo is ready");
        }

        public void Print()
        {
            Console.WriteLine("Printing...");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Press right side button");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Press Turn Off button");
        }
    }
}
