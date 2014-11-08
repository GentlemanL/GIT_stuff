using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IReSoft_priklad_v2
{
    public class RemoveSpacesAndPunctuation : Operation
    {

        public override string Run(string s)
        {
            string x = string.Empty;
            char tmp = x[0];

            //iba jedna operacia - ais nepouzitelne
            //string x = new string(s.Where(c => !char.IsPunctuation(c) || char.IsWhiteSpace(c)).ToArray());
            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsPunctuation(s[i]) && !char.IsWhiteSpace(s[i]))
                {
                    x += s[i];
                    if (i > 1) { tmp = s[i - 1]; }
                }
                setProgres(s[i], tmp);
            }
            return x;
        }

        protected override void setProgres(char currChar, char prevChar)
        {
            //'\n' je white space treba osetrit aby sem prisiel a neodstranoval ho asi
            lock (pr)
            {
                pr.numOfChars++;
                if (currChar == '.' || currChar == '?' || currChar == '!')
                {
                    pr.numOfSentences++;
                }
                if (currChar == '\n')
                {
                    pr.numOfLines++;
                }
                if (currChar == ' ' && !(currChar == ' '))
                {
                    pr.numOfWords++;
                }
            }
        }

    }
}
