﻿using System.Diagnostics;
using UELib;
using UELib.Core;
// using UELib.dll;

// using Memory;

// [DllImport(@"Build_x64\Memory.dll")]
// static extern void mpscExit();

// [DllImport(@"Eliot.UELib.dll")]
// static UnrealLoader loader()
// {
//     
// }

namespace chasrp;

class UEngineFilesText
{
    static void unrealFIles()
    {
        Process hmm = Process.GetProcessById(23792); //"MMH7Game-Win64-Shipping"
        Console.WriteLine(hmm);
    
        // mpscExit();
        // Mem m = new Mem();

        var package = UnrealLoader.LoadFullPackage( "<PATH_TO_PACKAGE>", System.IO.FileAccess.Read );
    
        foreach( UObject obj in package.Objects )
        {
            Console.WriteLine( "Name: {0}, Class: {1}, Outer: {2}", obj.Name, obj.Class.Name, obj.Outer.Name );
        }

    }
}