using System;

namespace CSScriptEnvironmentTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CSScriptEvaluatorApi.HostApp.Test();
            CSScriptEvaluatorExtensions.HostApp.Test();
            CSScriptNativeApi.HostApp.Test();

            Console.Write("Press any key to contiune...");
            Console.Read();
        }
    }
}
