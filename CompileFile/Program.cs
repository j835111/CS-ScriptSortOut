using CSScriptLibrary;
using System;
using System.Diagnostics;

namespace CompileFile
{
    class Program
    {
        static void Main(string[] args)
        {
            CompileMultipleScript();

            Console.ReadLine();
        }

        /// <summary>
        /// Meaure time of compiling and loading
        /// </summary>
        void TimeMeaure()
        {
            Stopwatch stopwatch = new Stopwatch();
            //Compile

            stopwatch.Start();
            CSScript.CompileFile("Script.cs", @"assembly", false, Par);
            Console.WriteLine("Compile time: " + stopwatch.Elapsed);

            //Loaded Assembly
            stopwatch.Restart();
            AsmHelper asmHelper = new AsmHelper(@"assembly", "test", false);
            Console.WriteLine("Assembly loaded time: " + stopwatch.Elapsed);

            stopwatch.Restart();
            asmHelper.Invoke("*.Test");
            Console.WriteLine("Function called time: " + stopwatch.Elapsed);
        }

        /// <summary>
        /// 
        /// </summary>
        static void CompileMultipleScript()
        {
            CSScript.CompileFile(@"..\..\Script1.cs", @"assembly1", false, Par);
            CSScript.CompileFile(@"..\..\Script2.cs", @"assembly2", false, Par);

            AsmHelper asmHelper1 = new AsmHelper(@"assembly1", "test", false);
            AsmHelper asmHelper2 = new AsmHelper(@"assembly2", "test", false);

            //asmHelper1.Invoke("*.Test1");
            //asmHelper2.Invoke("*.Test2");
        }

        public static String[] Par { get; set; } = {  };

    }
}
