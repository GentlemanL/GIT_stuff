using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IReSoft_priklad_v2
{
    // tato trieda sluzi len ako udrzovanie premenych o stave
    public class Progress
    {
        public Progress(Progress pr)
        {
            numOfLines = pr.numOfLines;
            numOfSentences = pr.numOfSentences;
            numOfWords = pr.numOfWords;
            numOfChars = pr.numOfChars;
            progressBarValue = pr.progressBarValue;
            totalProgressValue = pr.totalProgressValue;
            numOfLinesAfterRemove = pr.numOfLinesAfterRemove;
        }

        public Progress() { }

        public int numOfLines { get; set; }
        public int numOfSentences { get; set; }
        public int numOfWords { get; set; }
        public int numOfChars { get; set; }
        public int progressBarValue { get; set; }
        public int totalProgressValue { get; set; }
        public int numOfLinesAfterRemove { get; set; }
    }
}
