using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace IReSoft_priklad_v2
{
    public class RemoveDiacritics : Operation
    {
        public override string Run(string s, IUpdater u)
        {
            // normalizacia sposobi ze mekcene a ciarky sa rataju ako dalsi znak - treba doriesit!!!
            s = s.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(s[i]) != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(s[i]);
                }
                if (i == 0)
                {
                    setProgres(s, i, u);
                }
                else
                {
                    //sb vs s
                    setProgres(s, i, u);
                }
            }
            return sb.ToString();
        }
    }
}
