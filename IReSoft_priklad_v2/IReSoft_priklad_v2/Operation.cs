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
        protected Progress pr = new Progress();
        //protected Form1 form;


        private bool flag = true;
        private bool consecutiveEnter = false;
        //private static char[] arrayWordChars = Enumerable.Range('a', 'z' - 'a' + 1).SelectMany(i => new char[] {(char)i, Char.ToUpper((char)i)}).ToArray();
        private HashSet<char> whiteSpaceChars = new HashSet<char> {'\n', '\r', ' ', '\t' };
        private HashSet<char> sentenceChars = new HashSet<char> { '.', '?', '!' };
        private HashSet<char> lineChars = new HashSet<char> { '\n'};

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

        public abstract string Run(string s, IUpdater u);

        /* public Progress GetProgress()
         {
             lock (pr)
             {
                 //pametat si do buducnosti - ACid
                 return new Progress(pr);
             }
         }*/

        protected void setProgres(char currentChar, char previousChar, IUpdater update)
        {
            pr.numOfChars++;
            if (lineChars.Contains(currentChar)) pr.numOfLines++;
            if (sentenceChars.Contains(currentChar) && !sentenceChars.Contains(previousChar)) pr.numOfSentences++;
            if (whiteSpaceChars.Contains(currentChar) && !whiteSpaceChars.Contains(previousChar)) pr.numOfWords++;

            update.update(pr);
        }

        //protected void setProgres(char currentChar, char previousChar, IUpdater update)
        //{
        //    pr.numOfChars++;
        //    //osetrit pocitanie slov, neratam slova za ktorymi neni medzera
        //    // treba osetrit viac interpunkcnych znamienok po sebe 
        //    if (currentChar == '.' || currentChar == '?' || currentChar == '!')
        //    {
        //        pr.numOfSentences++;
        //        if (!flag)
        //        {
        //            flag = true;
        //        }
        //        else
        //        {
        //            flag = false;
        //            pr.numOfWords++;
        //        }
        //    }
        //    if (currentChar == '\n')
        //    {
        //        pr.numOfLines++;
        //        if (!consecutiveEnter)
        //        {
        //            consecutiveEnter = false;

        //            if (!flag)
        //            {
        //                flag = true;
        //            }
        //            else
        //            {
        //                flag = false;
        //                pr.numOfWords++;
        //            }
        //        }
        //    }
        //    if (currentChar == ' ' && !(previousChar == ' ')) // co ak mam 10 medzier za sebou!? osetrit, tato podmienka neni dobra -- mozno posielat posledne 2 cahraktery
        //    {
        //        if (flag) { pr.numOfWords++; }
        //        else { flag = true; }

        //    }

        //    if (pr.numOfLines == 0)
        //    {
        //        pr.numOfLines = 1;
        //    }
        //    update.update(pr);
        //}
    }
}
