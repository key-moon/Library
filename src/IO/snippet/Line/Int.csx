﻿///Title : ReadLineInt
///Shortcut : rlint
///Description : 複数行単一データの読み込み(int型)
///Author : keymoon

using System;
using System.Linq;

#if !DECLARATIONS
int height;
/*
//行数
height = h
*/
#endif


Enumerable.Repeat(0, height).Select(_ => int.Parse(Console.ReadLine())).ToArray()