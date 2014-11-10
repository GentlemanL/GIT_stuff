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
        public override string Run(string s, IUpdater u, int numOfops, int opNum)
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
            }
            for (int j = 0; j < sb.Length; j++)
            {
                if (j == 0)
                {
                    setProgres(sb.ToString(), j, u, numOfops, opNum);
                }
                else
                {
                    setProgres(sb.ToString(), j, u, numOfops, opNum);
                }
            }
            return sb.ToString();
        }
    }
}
