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
        string Run(string s, IUpdater u, int numOfOps, int opNum);

       // Progress GetProgress();
    }
}
