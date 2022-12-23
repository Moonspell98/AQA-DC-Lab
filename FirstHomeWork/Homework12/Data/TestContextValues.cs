using NUnit.Framework;

namespace Homework12
{
    public class TestContextValues
    {
        public static string ExecutableClassName => TestContext.CurrentContext.Test.ClassName;
    }
}
