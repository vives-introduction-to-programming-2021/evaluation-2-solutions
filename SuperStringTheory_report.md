
# Test Report SuperStringTheory
### Run Summary

<p>
<strong>Overall Result:</strong> ❌ Fail <br />
<strong>Pass Rate:</strong> 0% <br />
<strong>Run Duration:</strong> 1s 848ms <br />
<strong>Date:</strong> 2021-12-14 14:48:55 - 2021-12-14 14:48:56 <br />
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
<td>Tests.UnitTestSuperString.TestIsValidNumber<blockquote><details>
<summary>Error</summary>
<strong>Message:</strong>
<pre><code>Assert.True() Failure
Expected: True
Actual:   False</code></pre>
<strong>Stack Trace:</strong>
<pre><code>   at Tests.UnitTestSuperString.TestIsValidNumber() in /home/runner/work/csharp-evaluation-2-2021-BioBoost/csharp-evaluation-2-2021-BioBoost/SuperStringTheory/Tests/UnitTestSuperString.cs:line 33</code></pre>
</details></blockquote>
</td>
<td>3ms</td>
</tr>
<tr>
<td> ❌ Failed </td>
<td>Tests.UnitTestSuperString.TestAppendText<blockquote><details>
<summary>Error</summary>
<strong>Message:</strong>
<pre><code>Assert.Equal() Failure
               ↓ (pos 5)
Expected: Hello World
Actual:   Hello
               ↑ (pos 5)</code></pre>
<strong>Stack Trace:</strong>
<pre><code>   at Tests.UnitTestSuperString.TestAppendText() in /home/runner/work/csharp-evaluation-2-2021-BioBoost/csharp-evaluation-2-2021-BioBoost/SuperStringTheory/Tests/UnitTestSuperString.cs:line 18</code></pre>
</details></blockquote>
</td>
<td>1ms</td>
</tr>
<tr>
<td> ❌ Failed </td>
<td>Tests.UnitTestSuperString.TestTrimStart<blockquote><details>
<summary>Error</summary>
<strong>Message:</strong>
<pre><code>Assert.Equal() Failure
          ↓ (pos 0)
Expected: 
Actual:                          
          ↑ (pos 0)</code></pre>
<strong>Stack Trace:</strong>
<pre><code>   at Tests.UnitTestSuperString.TestTrimStart() in /home/runner/work/csharp-evaluation-2-2021-BioBoost/csharp-evaluation-2-2021-BioBoost/SuperStringTheory/Tests/UnitTestSuperString.cs:line 63</code></pre>
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
[xUnit.net 00:00:00.32]   Discovering: Tests
[xUnit.net 00:00:00.38]   Discovered:  Tests
[xUnit.net 00:00:00.38]   Starting:    Tests
[xUnit.net 00:00:00.46]       Assert.True() Failure
[xUnit.net 00:00:00.46]       Expected: True
[xUnit.net 00:00:00.46]       Actual:   False
[xUnit.net 00:00:00.46]       Stack Trace:
[xUnit.net 00:00:00.46]         /home/runner/work/csharp-evaluation-2-2021-BioBoost/csharp-evaluation-2-2021-BioBoost/SuperStringTheory/Tests/UnitTestSuperString.cs(33,0): at Tests.UnitTestSuperString.TestIsValidNumber()
[xUnit.net 00:00:00.47]       Assert.Equal() Failure
[xUnit.net 00:00:00.47]                      ↓ (pos 5)
[xUnit.net 00:00:00.47]       Expected: Hello World
[xUnit.net 00:00:00.47]       Actual:   Hello
[xUnit.net 00:00:00.47]                      ↑ (pos 5)
[xUnit.net 00:00:00.47]       Stack Trace:
[xUnit.net 00:00:00.47]         /home/runner/work/csharp-evaluation-2-2021-BioBoost/csharp-evaluation-2-2021-BioBoost/SuperStringTheory/Tests/UnitTestSuperString.cs(18,0): at Tests.UnitTestSuperString.TestAppendText()
[xUnit.net 00:00:00.47]       Assert.Equal() Failure
[xUnit.net 00:00:00.47]                 ↓ (pos 0)
[xUnit.net 00:00:00.47]       Expected: 
[xUnit.net 00:00:00.47]       Actual:                          
[xUnit.net 00:00:00.47]                 ↑ (pos 0)
[xUnit.net 00:00:00.47]       Stack Trace:
[xUnit.net 00:00:00.47]         /home/runner/work/csharp-evaluation-2-2021-BioBoost/csharp-evaluation-2-2021-BioBoost/SuperStringTheory/Tests/UnitTestSuperString.cs(63,0): at Tests.UnitTestSuperString.TestTrimStart()
[xUnit.net 00:00:00.47]   Finished:    Tests
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
[xUnit.net 00:00:00.46]     Tests.UnitTestSuperString.TestIsValidNumber [FAIL]
[xUnit.net 00:00:00.47]     Tests.UnitTestSuperString.TestAppendText [FAIL]
[xUnit.net 00:00:00.47]     Tests.UnitTestSuperString.TestTrimStart [FAIL]
</code></pre>
</details>



----

[Created using Liquid Test Reports](https://github.com/kurtmkurtm/LiquidTestReports)