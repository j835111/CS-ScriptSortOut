using CSScriptLibrary;

namespace CompileFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] par = { "System" };
            //Compile
            CSScript.CompileFile("Script.cs", @"C:\Users\j8351\Desktop\assembly", false, par);

            //Loaded Assembly
            AsmHelper asmHelper = new AsmHelper(@"C:\Users\j8351\Desktop\assembly", "test", false);
            asmHelper.Invoke("*.Test");
        }
    }
}
