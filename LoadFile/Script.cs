//css_imp Calculator, rename_namespace(LoadFile, test);

using System;

namespace LoadFile
{
    class Script
    {
        public static void Test()
        {
            Console.WriteLine("Function Call From Script: " + test.Calculator.Add(1, 2));
        }
    }
}
