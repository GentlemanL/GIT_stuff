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
                    if (i > 0) tmp = s[i - 1];
                }
                setProgres(sb[i], tmp);
            }
            return /*s =*/ sb.ToString();
        }


    }
}
