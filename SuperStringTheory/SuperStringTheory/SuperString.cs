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

            this.text += text;

        }

        public bool IsValidNumber()
        {
            // TODO - Check if text is a valid number.
            // It can start with a `+` or `-` sign.

            if (text == "")
            {
                return false;
            }

            int iStart = 0;
            if (text[0] == '+' || text[0] == '-')
            {
                iStart = 1;
            }

            for (int i = iStart; i < text.Length; i++)
            {
                if (text[i] < '0' || text[i] > '9')
                {
                    return false;
                }
            }


            // TODO - Return the result
            return true;
        }

        public void TrimStart()
        {
            // TODO - Remove any spaces at the beginning of text.
            string trimmedText = "";
            bool spacesToBeYanked = true;

            for (int i = 0; i < text.Length; i++)
            {
                if (spacesToBeYanked)
                {
                    if (text[i] != ' ')
                    {
                        spacesToBeYanked = false;
                    }
                }

                if (!spacesToBeYanked)
                {
                    trimmedText += text[i];
                }
            }


            // TODO - Save the resulting string to text
            text = trimmedText;


        }

        private string text = "";
    }
}
