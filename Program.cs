using System;
using System.Runtime.InteropServices;

namespace NETVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            string version = RuntimeInformation.FrameworkDescription;
            Console.WriteLine($"This is running in {version}");

            // This is required when using Visual Studio 2019 - VS Code redirects output, so this is not required there
            // Console.Write("Press any key to continue...");
            // Console.ReadKey();
        }
    }
}
