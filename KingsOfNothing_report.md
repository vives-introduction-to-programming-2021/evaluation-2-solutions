
# Test Report KingsOfNothing
### Run Summary

<p>
<strong>Overall Result:</strong> ❌ Fail <br />
<strong>Pass Rate:</strong> 0% <br />
<strong>Run Duration:</strong> 1s 954ms <br />
<strong>Date:</strong> 2021-12-14 14:00:03 - 2021-12-14 14:00:04 <br />
<strong>Framework:</strong> .NETCoreApp,Version=v3.1 <br />
<strong>Total Tests:</strong> 4 <br />
</p>

<table>
<thead>
<tr>
<th>✔️ Passed</th>
<th>❌ Failed</th>
<th>⚠️ Skipped</th>
</tr>
</thead>
<tbody>
<tr>
<td>0</td>
<td>4</td>
<td>0</td>
</tr>
<tr>
<td>0%</td>
<td>100%</td>
<td>0%</td>
</tr>
</tbody>
</table>

### Result Sets
#### Tests.dll - 0%
<details>
<summary>Full Results</summary>
<table>
<thead>
<tr>
<th>Result</th>
<th>Test</th>
<th>Duration</th>
</tr>
</thead>
<tr>
<td> ❌ Failed </td>
<td>Tests.UnitTestPlayer.TestMove<blockquote><details>
<summary>Error</summary>
<strong>Message:</strong>
<pre><code>Assert.Equal() Failure
Expected: 15
Actual:   0</code></pre>
<strong>Stack Trace:</strong>
<pre><code>   at Tests.UnitTestPlayer.TestMove() in /home/runner/work/csharp-evaluation-2-2021/csharp-evaluation-2-2021/KingsOfNothing/Tests/UnitTestPlayer.cs:line 19</code></pre>
</details></blockquote>
</td>
<td>5ms</td>
</tr>
<tr>
<td> ❌ Failed </td>
<td>Tests.UnitTestPlayer.TestHeal<blockquote><details>
<summary>Error</summary>
<strong>Message:</strong>
<pre><code>Assert.Equal() Failure
Expected: 40
Actual:   30</code></pre>
<strong>Stack Trace:</strong>
<pre><code>   at Tests.UnitTestPlayer.TestHeal() in /home/runner/work/csharp-evaluation-2-2021/csharp-evaluation-2-2021/KingsOfNothing/Tests/UnitTestPlayer.cs:line 76</code></pre>
</details></blockquote>
</td>
<td>< 1ms</td>
</tr>
<tr>
<td> ❌ Failed </td>
<td>Tests.UnitTestPlayer.TestDamage<blockquote><details>
<summary>Error</summary>
<strong>Message:</strong>
<pre><code>Assert.Equal() Failure
Expected: 95
Actual:   100</code></pre>
<strong>Stack Trace:</strong>
<pre><code>   at Tests.UnitTestPlayer.TestDamage() in /home/runner/work/csharp-evaluation-2-2021/csharp-evaluation-2-2021/KingsOfNothing/Tests/UnitTestPlayer.cs:line 38</code></pre>
</details></blockquote>
</td>
<td>< 1ms</td>
</tr>
<tr>
<td> ❌ Failed </td>
<td>Tests.UnitTestPlayer.TestAlive<blockquote><details>
<summary>Error</summary>
<strong>Message:</strong>
<pre><code>Assert.True() Failure
Expected: True
Actual:   False</code></pre>
<strong>Stack Trace:</strong>
<pre><code>   at Tests.UnitTestPlayer.TestAlive() in /home/runner/work/csharp-evaluation-2-2021/csharp-evaluation-2-2021/KingsOfNothing/Tests/UnitTestPlayer.cs:line 57</code></pre>
</details></blockquote>
</td>
<td>< 1ms</td>
</tr>
</tbody>
</table>
</details>

### Run Messages
<details>
<summary>Informational</summary>
<pre><code>
[xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v2.4.3+1b45f5407b (64-bit .NET Core 3.1.1)
[xUnit.net 00:00:00.37]   Discovering: Tests
[xUnit.net 00:00:00.43]   Discovered:  Tests
[xUnit.net 00:00:00.43]   Starting:    Tests
[xUnit.net 00:00:00.52]       Assert.Equal() Failure
[xUnit.net 00:00:00.52]       Expected: 15
[xUnit.net 00:00:00.52]       Actual:   0
[xUnit.net 00:00:00.52]       Stack Trace:
[xUnit.net 00:00:00.53]         /home/runner/work/csharp-evaluation-2-2021/csharp-evaluation-2-2021/KingsOfNothing/Tests/UnitTestPlayer.cs(19,0): at Tests.UnitTestPlayer.TestMove()
[xUnit.net 00:00:00.53]       Assert.Equal() Failure
[xUnit.net 00:00:00.53]       Expected: 40
[xUnit.net 00:00:00.53]       Actual:   30
[xUnit.net 00:00:00.53]       Stack Trace:
[xUnit.net 00:00:00.53]         /home/runner/work/csharp-evaluation-2-2021/csharp-evaluation-2-2021/KingsOfNothing/Tests/UnitTestPlayer.cs(76,0): at Tests.UnitTestPlayer.TestHeal()
[xUnit.net 00:00:00.53]       Assert.Equal() Failure
[xUnit.net 00:00:00.53]       Expected: 95
[xUnit.net 00:00:00.53]       Actual:   100
[xUnit.net 00:00:00.54]       Stack Trace:
[xUnit.net 00:00:00.54]         /home/runner/work/csharp-evaluation-2-2021/csharp-evaluation-2-2021/KingsOfNothing/Tests/UnitTestPlayer.cs(38,0): at Tests.UnitTestPlayer.TestDamage()
[xUnit.net 00:00:00.54]       Assert.True() Failure
[xUnit.net 00:00:00.54]       Expected: True
[xUnit.net 00:00:00.54]       Actual:   False
[xUnit.net 00:00:00.54]       Stack Trace:
[xUnit.net 00:00:00.54]         /home/runner/work/csharp-evaluation-2-2021/csharp-evaluation-2-2021/KingsOfNothing/Tests/UnitTestPlayer.cs(57,0): at Tests.UnitTestPlayer.TestAlive()
[xUnit.net 00:00:00.54]   Finished:    Tests
</code></pre>
</details>

<details>
<summary>Warning</summary>
<pre><code>
</code></pre>
</details>

<details>
<summary>Error</summary>
<pre><code>
[xUnit.net 00:00:00.52]     Tests.UnitTestPlayer.TestMove [FAIL]
[xUnit.net 00:00:00.53]     Tests.UnitTestPlayer.TestHeal [FAIL]
[xUnit.net 00:00:00.53]     Tests.UnitTestPlayer.TestDamage [FAIL]
[xUnit.net 00:00:00.54]     Tests.UnitTestPlayer.TestAlive [FAIL]
</code></pre>
</details>



----

[Created using Liquid Test Reports](https://github.com/kurtmkurtm/LiquidTestReports)