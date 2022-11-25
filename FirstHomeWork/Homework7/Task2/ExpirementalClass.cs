// Note: Better not use this class, stuck in infinity loop is possible.
namespace Homework7.Task2
{
    public class ExpirementalClass
    {
        public int ValueFrom1To10
        {
            get => ValueFrom1To10;
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new OutOfBoundsCustomException();
                }
                else
                {
                    ValueFrom1To10 = value;
                }
            }
        }
    }
}
