//css_imp Calculator, rename_namespace(CSScriptLoadFile, test);

using System;

namespace CSScriptLoadFile
{
    class Script
    {
        public static void Test()
        {
            Console.WriteLine("Function Call From Script: " + test.Calculator.Add(1, 2));
        }
    }
}
