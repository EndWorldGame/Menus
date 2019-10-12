using System;
using System.Collections.Generic;
using System.Text;
using MenuLibrary.src.RunService;

namespace MenuSandbox
{
    class TestRunService : IRunService
    {
        public void Run()
        {
            Console.WriteLine("Enter a string");
            var textString = Console.ReadLine();
            Console.WriteLine(String.Format("Why did you type {0}?", textString));
        }
    }
}
