﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IReSoft_priklad_v2
{
    public class RemoveEmptyLines : Operation
    {
        private HashSet<char> whiteSpaceChars = new HashSet<char> { '\n', '\r', ' ', '\t' };
        public override string Run(string s, IUpdater u, int numOfOps, int opNum)
        {
            string returnString = string.Empty;
            char tmp1 = s[0];
            char tmp2 = s[0];
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '\r' && tmp1 == '\r')
                {
                    setProgres(s, i, u, numOfOps, opNum); continue;
                }
                else if (s[i] == '\n' && tmp1 == '\n')
                {
                    setProgres(s, i, u, numOfOps, opNum); continue;
                }
                if (i > 1) { tmp1 = s[i - 1]; }
                if (i > 2) { tmp2 = s[i - 2]; }
                //if (s[i] == '\r' && tmp1 == '\n' && tmp2 == '\n') { setProgres(s, i, u, numOfOps, opNum); continue; }
                //else if (s[i] == '\n' && tmp1 == '\r' && tmp2 == '\n') { setProgres(s, i, u, numOfOps, opNum); continue; }
                if (whiteSpaceChars.Contains(s[i]) && whiteSpaceChars.Contains(tmp1) && whiteSpaceChars.Contains(tmp2))
                {
                    setProgres(s, i, u, numOfOps, opNum); continue;
                }
                else
                {
                    returnString += s[i];
                }

                if (i == s.Length - 2 && (s[i - 1] == '\r'))
                {
                    returnString.TrimEnd('\r', '\n');
                }
                setProgres(s, i, u, numOfOps, opNum);
            }
            return returnString;
        }
    }
}
