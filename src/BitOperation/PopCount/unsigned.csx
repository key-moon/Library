﻿///Title : PopCount(unsigned)
///Shortcut : popcountu
///Description : 符号なし整数のビットの立っている数
///Author : keymoon

using MethodImplOptions = System.Runtime.CompilerServices.MethodImplOptions;
using MethodImplAttribute = System.Runtime.CompilerServices.MethodImplAttribute;

#if !DECLARATIONS
/*
//型
@T = uint;
*/
using @T = System.UInt32;
#endif

[MethodImpl(MethodImplOptions.AggressiveInlining)]
static int PopCount(@T n)
{
    n = n - ((n >> 1) & 0x55555555);
    n = (n & 0x33333333) + ((n >> 2) & 0x33333333);
    return (int)(((n + (n >> 4) & 0xF0F0F0F) * 0x1010101) >> 24);
}