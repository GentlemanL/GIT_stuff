using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IReSoft_priklad_v2
{
    public class Progress
    {
        //private Progress pr;

        public Progress(Progress pr)
        {
            //this a bez this kvoli pokusu ci sa neico zmeni
            this.numOfLines = pr.numOfLines;
            this.numOfSentences = pr.numOfSentences;
            numOfWords = pr.numOfWords;
            numOfChars = pr.numOfChars;
        }

        public Progress()
        {
            // TODO: Complete member initialization
        }

        public int numOfLines { get; set; }
        public int numOfSentences { get; set; }
        public int numOfWords { get; set; }
        public int numOfChars { get; set; }
    }
}
