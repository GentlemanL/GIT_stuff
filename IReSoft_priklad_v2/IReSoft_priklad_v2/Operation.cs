using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;

namespace IReSoft_priklad_v2
{
    public abstract class Operation : IOperation
    {
        #region properties
        protected Progress pr = new Progress();
        private char tmp;
        private HashSet<char> whiteSpaceChars = new HashSet<char> { '\n', '\r', ' ', '\t' };
        private HashSet<char> sentenceChars = new HashSet<char> { '.', '?', '!' };
        private HashSet<char> lineChars = new HashSet<char> { '\n' };
        #endregion

        /// <summary>
        /// checks if current character is word char (alphabet or number)
        /// </summary>
        /// <param name="c">character to be checked</param>
        /// <returns>return true on word character, false otherwise</returns>
        private bool isWord(char c)
        {
            if (whiteSpaceChars.Contains(c))
            {
                return false;
            }
            else if (sentenceChars.Contains(c))
            {
                return false;
            }
            else if (lineChars.Contains(c))
            {
                return false;
            }
            return true;
        }

        
        // bolo by lepsie keby sa numOfOps neposielal stale ael iba sa vedel z niekade dostat ked treba
        /// <summary>
        /// function used by operation to perfrom specific tasks
        /// </summary>
        /// <param name="s">input text</param>
        /// <param name="u">form updater</param>
        /// <param name="numOfOps">number of operations to be performed</param>
        /// <param name="opNum">number of curretn operation</param>
        /// <returns>returns string of edited text</returns>
        public abstract string Run(string s, IUpdater u, int numOfOps, int opNum);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s">input text</param>
        /// <param name="index">current index (position in string)</param>
        /// <param name="update">form updater</param>
        /// <param name="numOfOps">number of operations to be performed</param>
        /// <param name="opNum">number of curretn operation</param>
        protected void setProgres(string s, int index, IUpdater update, int numOfOps, int opNum)
        {
            pr.totalProgressValue = s.Length * numOfOps;

            pr.numOfChars++;
            if (index == 0)
            {
                tmp = s[0];
            }
            else tmp = s[index - 1];

            if (lineChars.Contains(s[index])) pr.numOfLines++;
            if (sentenceChars.Contains(s[index]) && !sentenceChars.Contains(tmp)) pr.numOfSentences++;
            if ((whiteSpaceChars.Contains(s[index]) || sentenceChars.Contains(s[index])) && isWord(tmp)) pr.numOfWords++;

            pr.progressBarValue = ((index + 1 + (s.Length * (opNum - 1))) * 100 / (s.Length * numOfOps));

            if (index % 100 == 0 || index == s.Length - 1)
            {
                update.update(pr);
            }
        }
    }
}
