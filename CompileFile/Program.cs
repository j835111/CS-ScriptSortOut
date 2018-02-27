using CSScriptLibrary;
using System;
using System.Diagnostics;

namespace CompileFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            string[] par = { "System" };
            //Compile

            stopwatch.Start();
            CSScript.CompileFile("Script.cs", @"assembly", false, par);
            Console.WriteLine("Compile time: " + stopwatch.Elapsed);

            //Loaded Assembly
            stopwatch.Restart();
            AsmHelper asmHelper = new AsmHelper(@"assembly", "test", false);
            Console.WriteLine("Assembly loaded time: " + stopwatch.Elapsed);

            stopwatch.Restart();
            asmHelper.Invoke("*.Test");
            Console.WriteLine("Function called time: " + stopwatch.Elapsed);

            Console.ReadLine();
        }
    }
}
