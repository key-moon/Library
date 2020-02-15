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
<script type="text/javascript" src="../../../assets/js/copy-button.js"></script>
<link rel="stylesheet" href="../../../assets/css/copy-button.css" />


# :warning: src/Misc/GridEdges.csx

<a href="../../../index.html">Back to top page</a>

* category: <a href="../../../index.html#eec951bcc9ce32cbbb047da637079723">src/Misc</a>
* <a href="{{ site.github.repository_url }}/blob/master/src/Misc/GridEdges.csx">View this file on GitHub</a>
    - Last commit date: 2019-11-23 16:54:05+09:00




## Code

<a id="unbundled"></a>
{% raw %}
```cpp
﻿///Title : Grid Graph Edges Generator
///Shortcut : gridedges
///Description : グリッドグラフの辺を生成する
///Author : keymoon

using System;
using System.Linq;
using System.Collections.Generic;

#if !DECLARATIONS
/*
//変数
@graph;
*/
//高さ
int @h;
//横幅
int @w;
#endif

List<int>[] @graph = Enumerable.Repeat(0, @h * @w).Select(_ => new List<int>()).ToArray();
for (int i = 0; i < @h - 1; i++)
    for (int j = 0; j < @w; j++)
    { var id = i * @w + j; graph[id].Add(id + @w); graph[id + @w].Add(id); }
for (int i = 0; i < @h; i++)
    for (int j = 0; j < @w - 1; j++)
    { var id = i * @w + j; graph[id].Add(id + 1); graph[id + 1].Add(id); }
```
{% endraw %}

<a id="bundled"></a>
{% raw %}
```cpp
Traceback (most recent call last):
  File "/opt/hostedtoolcache/Python/3.8.1/x64/lib/python3.8/site-packages/onlinejudge_verify/docs.py", line 347, in write_contents
    bundled_code = language.bundle(self.file_class.file_path, basedir=self.cpp_source_path)
  File "/opt/hostedtoolcache/Python/3.8.1/x64/lib/python3.8/site-packages/onlinejudge_verify/languages/csharpscript.py", line 108, in bundle
    raise NotImplementedError
NotImplementedError

```
{% endraw %}

<a href="../../../index.html">Back to top page</a>

