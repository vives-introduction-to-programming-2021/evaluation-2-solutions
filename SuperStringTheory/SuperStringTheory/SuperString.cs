using System;
using System.Collections.Generic;
using System.Text;

namespace SuperStringTheory
{
    public class SuperString
    {
        public string GetText()
        {
            return text;
        }

        public void SetText(string text)
        {
            this.text = text;
        }

        public void AppendText(string text)
        {
            // TODO - Append the local argument text behind the attribute text





        }

        public bool IsValidNumber()
        {
            // TODO - Check if text is a valid number. It can start with a `+` or `-` sign.




            // TODO - Return the result
            return false;
        }

        public void TrimStart()
        {
            // TODO - Remove any spaces at the beginning of text.



            // TODO - Save the resulting string to text
            


        }

        private string text = "";
    }
}
