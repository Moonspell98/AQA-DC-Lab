namespace Homework7.Task2
{
    public class OutOfBoundsCustomException : Exception
    {
        public override string Message { get; } = $"You're {++TimesSomeoneWentOutOfBounds}th who went out of bounds";
        public static int TimesSomeoneWentOutOfBounds = 0;

        public OutOfBoundsCustomException()
        {
        }
        
        public OutOfBoundsCustomException(string? message) : base(message)
        {
        }
    }
}
