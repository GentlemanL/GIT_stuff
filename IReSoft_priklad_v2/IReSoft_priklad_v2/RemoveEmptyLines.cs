using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IReSoft_priklad_v2
{
    public class RemoveEmptyLines : Operation
    {
        public override string Run(string s, IUpdater u)
        {
            // odstranovanie nadbytocnych \n
            char tmp = s[0];
            string returnString = string.Empty; 
            for (int i = 0; i < s.Length; i++)
            {
                if (i > 1) { tmp = s[i - 1]; }
                if (s[i] == '\n' && tmp == '\n')
                {
                    continue;
                }
                else
                {
                    // ak je posledny znak '\n' tak ho to odstrani
                    if (!(i == s.Length - 1 && s[i] == '\n'))
                    {
                        returnString += s[i];
                    }
                }
                setProgres(s[i], tmp, u);
            }
            return returnString;
        }
    }
}
