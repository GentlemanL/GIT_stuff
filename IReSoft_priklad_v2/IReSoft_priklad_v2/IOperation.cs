using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace IReSoft_priklad_v2
{
    public interface IOperation
    {
        // run by asi mohol/mal byt void
        // idem to zmenit a uvidim
        string Run(string s);

        Progress GetProgress();
    }
}
