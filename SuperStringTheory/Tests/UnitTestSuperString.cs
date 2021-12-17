using SuperStringTheory;
using System;
using Xunit;

namespace Tests
{
    public class UnitTestSuperString
    {
        private SuperString myString = new SuperString();

        [Fact]
        public void TestAppendText()
        {
            myString.SetText("Hello");
            myString.AppendText(" World");
            Assert.Equal("Hello World", myString.GetText());

            myString.SetText("  I am");
            myString.AppendText("      Mister Roboto   ");
            Assert.Equal("  I am      Mister Roboto   ", myString.GetText());

            myString.SetText("C# is cool!");
            myString.AppendText("");
            Assert.Equal("C# is cool!", myString.GetText());
        }

        [Fact]
        public void TestIsValidNumber()
        {
            myString.SetText("1234");
            Assert.True(myString.IsValidNumber());

            myString.SetText("74-56");
            Assert.False(myString.IsValidNumber());

            myString.SetText("0");
            Assert.True(myString.IsValidNumber());

            myString.SetText("ewrqwwhquqrew");
            Assert.False(myString.IsValidNumber());

            myString.SetText("#0950534958");
            Assert.False(myString.IsValidNumber());

            myString.SetText("");
            Assert.False(myString.IsValidNumber());

            myString.SetText("     ");
            Assert.False(myString.IsValidNumber());

            myString.SetText("+1234");
            Assert.True(myString.IsValidNumber());

            myString.SetText("-1234");
            Assert.True(myString.IsValidNumber());

            myString.SetText("-12a34");
            Assert.False(myString.IsValidNumber());
        }

        [Fact]
        public void TestTrimStart()
        {
            myString.SetText("Hello World from C# and Unit Tests!");
            myString.TrimStart();
            Assert.Equal("Hello World from C# and Unit Tests!", myString.GetText());

            myString.SetText("                       ");
            myString.TrimStart();
            Assert.Equal("", myString.GetText());

            myString.SetText("   Only at the beginning!");
            myString.TrimStart();
            Assert.Equal("Only at the beginning!", myString.GetText());

            myString.SetText("Only at the end!       ");
            myString.TrimStart();
            Assert.Equal("Only at the end!       ", myString.GetText());

            myString.SetText("");
            myString.TrimStart();
            Assert.Equal("", myString.GetText());
        }
    }
}
