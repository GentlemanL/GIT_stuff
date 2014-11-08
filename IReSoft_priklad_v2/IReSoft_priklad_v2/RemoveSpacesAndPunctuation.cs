﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IReSoft_priklad_v2
{
    public class RemoveSpacesAndPunctuation : Operation
    {

        public override string Run(string s)
        {
            string returnString = string.Empty;
            char tmp = s[0];

            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            textInfo.ToTitleCase(s);

            //iba jedna operacia - asi nepouzitelne
            //string x = new string(s.Where(c => !char.IsPunctuation(c) || char.IsWhiteSpace(c)).ToArray());

            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsPunctuation(s[i]) && !(s[i] == ' '))
                {
                    returnString += s[i];
                    if (i > 1) { tmp = s[i - 1]; }
                }
                setProgres(s[i], tmp);
            }
            return returnString;
        }

        //protected override void setProgres(char currChar, char prevChar)
        //{
        //    lock (pr)
        //    {
        //        pr.numOfChars++;
        //        if (currChar == '.' || currChar == '?' || currChar == '!')
        //        {
        //            pr.numOfSentences++;
        //        }
        //        if (currChar == '\n')
        //        {
        //            pr.numOfLines++;
        //        }
        //    }
        //}

    }
}
