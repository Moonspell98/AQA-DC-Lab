using Homework6.Task3;

namespace AutomationCources.Lecture_7.Homework
{
    public class MobilePhone : Device, IPhotographic
    {

        public MobilePhone(double numberOfPixelsInCamera, string? modelName, decimal price)
        {
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
        public double NumberOfPixelsInCamera { get; set; }

        public void TakePhoto()
        {
            Console.WriteLine("Press button on the screen and photo is ready");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Press left side button");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Press Turn Off button");
        }
    }
}
