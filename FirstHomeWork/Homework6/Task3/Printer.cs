using Homework6.Task3;

namespace AutomationCources.Lecture_7.Homework
{
    public class Printer : Device, IPrintable
    {
        private int paperWidth;
        private int paperHeight;

        public Printer(string? modelName, decimal price, int paperWidth, int paperHeight)
        {
            this.modelName = modelName;
            this.price = price;
            this.paperWidth = paperWidth;
            this.paperHeight = paperHeight;
        }

        public int PaperWidth { get; set; }
        public int PaperHeight { get; set; }

        public void Print()
        {
            Console.WriteLine("Printing...");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Press button at the top");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Press Turn Off button");
        }
    }
}
