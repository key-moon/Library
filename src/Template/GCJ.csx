﻿///Title : Template for Google Code Jam
///Shortcut : tmplgcj
///Description : gcjのアレ
///Author : keymoon

using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static System.Math;
using MethodImplOptions = System.Runtime.CompilerServices.MethodImplOptions;
using MethodImplAttribute = System.Runtime.CompilerServices.MethodImplAttribute;

public static class P
{
    public static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        StringBuilder builder = new StringBuilder();
        for (int i = 1; i <= k; i++) builder.AppendLine($"Case #{i}: {Solve()}");
        Console.WriteLine(builder.ToString());
    }

    static string Solve()
    {
        /*cursor*/
    }
}       