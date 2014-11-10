using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IReSoft_priklad_v2
{
    public class RemoveSpacesAndPunctuation : Operation
    {

        public override string Run(string s, IUpdater u, int numOfops, int opNum)
        {
            string returnString = string.Empty;
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            s = textInfo.ToTitleCase(s);

            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsPunctuation(s[i]) && !(s[i] == ' ')) //
                {
                    returnString += s[i];
                }
                setProgres(s, i, u, numOfops, opNum);
            }
            return returnString;
        }
    }
}
