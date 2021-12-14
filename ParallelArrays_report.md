
# Test Report ParallelArrays
### Run Summary

<p>
<strong>Overall Result:</strong> ❌ Fail <br />
<strong>Pass Rate:</strong> 0% <br />
<strong>Run Duration:</strong> 1s 865ms <br />
<strong>Date:</strong> 2021-12-14 13:59:26 - 2021-12-14 13:59:28 <br />
<strong>Framework:</strong> .NETCoreApp,Version=v3.1 <br />
<strong>Total Tests:</strong> 3 <br />
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
<td>3</td>
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
<td>Tests.UnitTestArrayHelper.TestSumByElements<blockquote><details>
<summary>Error</summary>
<strong>Message:</strong>
<pre><code>Assert.Equal() Failure
Expected: Int32[] [1, 2, 3, 4]
Actual:   (null)</code></pre>
<strong>Stack Trace:</strong>
<pre><code>   at Tests.UnitTestArrayHelper.TestSumByElements() in /home/runner/work/csharp-evaluation-2-2021/csharp-evaluation-2-2021/ParallelArrays/Tests/UnitTestArrayHelper.cs:line 26</code></pre>
</details></blockquote>
</td>
<td>6ms</td>
</tr>
<tr>
<td> ❌ Failed </td>
<td>Tests.UnitTestArrayHelper.TestCountDifferentFrom<blockquote><details>
<summary>Error</summary>
<strong>Message:</strong>
<pre><code>Assert.Equal() Failure
Expected: 3
Actual:   -1</code></pre>
<strong>Stack Trace:</strong>
<pre><code>   at Tests.UnitTestArrayHelper.TestCountDifferentFrom() in /home/runner/work/csharp-evaluation-2-2021/csharp-evaluation-2-2021/ParallelArrays/Tests/UnitTestArrayHelper.cs:line 13</code></pre>
</details></blockquote>
</td>
<td>2ms</td>
</tr>
<tr>
<td> ❌ Failed </td>
<td>Tests.UnitTestArrayHelper.TestDoubleInSize<blockquote><details>
<summary>Error</summary>
<strong>Message:</strong>
<pre><code>System.NullReferenceException : Object reference not set to an instance of an object.</code></pre>
<strong>Stack Trace:</strong>
<pre><code>   at Tests.UnitTestArrayHelper.TestDoubleInSize() in /home/runner/work/csharp-evaluation-2-2021/csharp-evaluation-2-2021/ParallelArrays/Tests/UnitTestArrayHelper.cs:line 45</code></pre>
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
[xUnit.net 00:00:00.33]   Discovering: Tests
[xUnit.net 00:00:00.38]   Discovered:  Tests
[xUnit.net 00:00:00.39]   Starting:    Tests
[xUnit.net 00:00:00.48]       Assert.Equal() Failure
[xUnit.net 00:00:00.48]       Expected: Int32[] [1, 2, 3, 4]
[xUnit.net 00:00:00.48]       Actual:   (null)
[xUnit.net 00:00:00.48]       Stack Trace:
[xUnit.net 00:00:00.48]         /home/runner/work/csharp-evaluation-2-2021/csharp-evaluation-2-2021/ParallelArrays/Tests/UnitTestArrayHelper.cs(26,0): at Tests.UnitTestArrayHelper.TestSumByElements()
[xUnit.net 00:00:00.48]       Assert.Equal() Failure
[xUnit.net 00:00:00.49]       Expected: 3
[xUnit.net 00:00:00.49]       Actual:   -1
[xUnit.net 00:00:00.49]       Stack Trace:
[xUnit.net 00:00:00.49]         /home/runner/work/csharp-evaluation-2-2021/csharp-evaluation-2-2021/ParallelArrays/Tests/UnitTestArrayHelper.cs(13,0): at Tests.UnitTestArrayHelper.TestCountDifferentFrom()
[xUnit.net 00:00:00.49]       System.NullReferenceException : Object reference not set to an instance of an object.
[xUnit.net 00:00:00.49]       Stack Trace:
[xUnit.net 00:00:00.49]         /home/runner/work/csharp-evaluation-2-2021/csharp-evaluation-2-2021/ParallelArrays/Tests/UnitTestArrayHelper.cs(45,0): at Tests.UnitTestArrayHelper.TestDoubleInSize()
[xUnit.net 00:00:00.49]   Finished:    Tests
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
[xUnit.net 00:00:00.48]     Tests.UnitTestArrayHelper.TestSumByElements [FAIL]
[xUnit.net 00:00:00.48]     Tests.UnitTestArrayHelper.TestCountDifferentFrom [FAIL]
[xUnit.net 00:00:00.49]     Tests.UnitTestArrayHelper.TestDoubleInSize [FAIL]
</code></pre>
</details>



----

[Created using Liquid Test Reports](https://github.com/kurtmkurtm/LiquidTestReports)