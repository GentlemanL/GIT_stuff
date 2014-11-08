using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IReSoft_priklad_v2
{
    public class Execute
    {

        public string /*void*/ runOperation(Operation op, string s)
        {
            //Thread thread = new Thread(() => op.Run(s));
            string v = op.Run(s);
            return v;
        }
    }
}
