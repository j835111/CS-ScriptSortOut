﻿using CSScriptLibrary;
using System;

namespace CS_ScriptSortOut
{
    class Program
    {
        static void Main(string[] args)
        {
            
            AsmHelper helper = new AsmHelper(CSScript.LoadFile("Script.cs"));
            helper.Invoke("*.Test");

            Console.ReadLine();
        }
    }
}
