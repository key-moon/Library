---
layout: default
---

<!-- mathjax config similar to math.stackexchange -->
<script type="text/javascript" async
  src="https://cdnjs.cloudflare.com/ajax/libs/mathjax/2.7.5/MathJax.js?config=TeX-MML-AM_CHTML">
</script>
<script type="text/x-mathjax-config">
  MathJax.Hub.Config({
    TeX: { equationNumbers: { autoNumber: "AMS" }},
    tex2jax: {
      inlineMath: [ ['$','$'] ],
      processEscapes: true
    },
    "HTML-CSS": { matchFontHeight: false },
    displayAlign: "left",
    displayIndent: "2em"
  });
</script>

<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
<script src="https://cdn.jsdelivr.net/npm/jquery-balloon-js@1.1.2/jquery.balloon.min.js" integrity="sha256-ZEYs9VrgAeNuPvs15E39OsyOJaIkXEEt10fzxJ20+2I=" crossorigin="anonymous"></script>
<script type="text/javascript" src="../../../../assets/js/copy-button.js"></script>
<link rel="stylesheet" href="../../../../assets/css/copy-button.css" />


# :warning: src/DataStructure/UnionFind/PartialPersistentUnionFind.csx

<a href="../../../../index.html">Back to top page</a>

* category: <a href="../../../../index.html#657c57e2fafbaee71dc36bfd3721bb15">src/DataStructure/UnionFind</a>
* <a href="{{ site.github.repository_url }}/blob/master/src/DataStructure/UnionFind/PartialPersistentUnionFind.csx">View this file on GitHub</a>
    - Last commit date: 2019-09-23 15:24:39+09:00




## Code

<a id="unbundled"></a>
{% raw %}
```cpp
﻿///Title : PartialPersistentUnionFind
///Shortcut : ppuf
///Description : 部分永続Union-Find
///Author : keymoon

using System;
using System.Collections.Generic;
using System.Linq;
using MethodImplOptions = System.Runtime.CompilerServices.MethodImplOptions;
using MethodImplAttribute = System.Runtime.CompilerServices.MethodImplAttribute;

class PartialPersistentUnionFind
{
    const int MAX = 1 << 30;
    public readonly int Size;
    public int Now { get; private set; }
    public IEnumerable<int> AllRepresents => Parents.Where((x, y) => x == y);
    int[] Parents;
    int[] Time;
    int[] Sizes;
    List<int>[] SizeHistories;
    List<int>[] TimeStamps;

    public PartialPersistentUnionFind(int size)
    {
        Size = size;
        Parents = new int[size];
        Time = new int[size];
        Sizes = new int[size];
        SizeHistories = new List<int>[size];
        TimeStamps = new List<int>[size];
        for (int i = 0; i < Size; i++)
        {
            Time[i] = MAX;
            Sizes[i] = 1;
            SizeHistories[i] = new List<int>() { 1 };
            TimeStamps[i] = new List<int>() { 0 };
        }
    }

    public bool TryUnite(int x, int y)
    {
        Now++;
        x = Find(x);
        y = Find(y);
        if (x == y) return false;
        if (Sizes[x] < Sizes[y]) { var tmp = x; x = y; y = tmp; }
        Time[y] = Now;
        Parents[y] = x;
        Sizes[x] += Sizes[y];
        TimeStamps[x].Add(Now << 1);
        SizeHistories[x].Add(Sizes[x]);
        return true;
    }
    public int Find(int i, int t = MAX)
    {
        while (Time[i] <= t) i = Parents[i];
        return i;
    }
    public int GetSize(int i, int t = MAX)
    {
        var root = Find(i, t);
        return SizeHistories[root][~TimeStamps[root].BinarySearch(t << 1 | 1) - 1];
    }
}
```
{% endraw %}

<a id="bundled"></a>
{% raw %}
```cpp
Traceback (most recent call last):
  File "/opt/hostedtoolcache/Python/3.8.2/x64/lib/python3.8/site-packages/onlinejudge_verify/docs.py", line 340, in write_contents
    bundled_code = language.bundle(self.file_class.file_path, basedir=pathlib.Path.cwd())
  File "/opt/hostedtoolcache/Python/3.8.2/x64/lib/python3.8/site-packages/onlinejudge_verify/languages/csharpscript.py", line 110, in bundle
    raise NotImplementedError
NotImplementedError

```
{% endraw %}

<a href="../../../../index.html">Back to top page</a>
