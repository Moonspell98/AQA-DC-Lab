using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7.Task2
{
    public class InfinityLoopException : Exception
    {
        public override string Message { get; } = "Congratulations you're stuck in an endless loop." +
            $"You're {++TimesSomeoneGotIntoInfinityLoop}th who stuck into endless loop";
        public static int TimesSomeoneGotIntoInfinityLoop = 0;

        public InfinityLoopException()
        {
        }
        public InfinityLoopException(string? message) : base(message)
        {
        }
    }
}
