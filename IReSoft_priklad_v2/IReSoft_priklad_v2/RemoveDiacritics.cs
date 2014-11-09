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
        public override string Run(string s)
        {
            s = s.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            char tmp = s[0];

            for (int i = 0; i < s.Length; i++)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(s[i]) != UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(s[i]);

                    // treba kvoli kontrole viacerych medzier
                    if (i > 1) tmp = s[i - 1];
                }
                if (i == 0)
                {
                    setProgres(sb[i], s[0]);
                }
                else
                {
                    setProgres(s[i], s[i-1]);
                }
            }
            return /*s =*/ sb.ToString();
        }
    }
}
