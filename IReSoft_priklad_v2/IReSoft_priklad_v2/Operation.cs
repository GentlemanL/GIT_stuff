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

        public abstract string Run(string s, IUpdater u);
       /* public Progress GetProgress()
        {
            lock (pr)
            {
                //pametat si do buducnosti - ACid
                return new Progress(pr);
            }
        }*/

        // mozno ju nechat normalne naimplementovanu a nepouzivat ani virtual
        protected /*virtual*/ void setProgres(char currentChar, char previousChar, IUpdater update)
        {
            //lock (pr)
            //{
                pr.numOfChars++;
                //SetControlPropertyThreadSafe(form.labelPocetZnakov, "Text", pr.numOfChars.ToString());
                if (currentChar == '.' || currentChar == '?' || currentChar == '!')
                {
                    pr.numOfSentences++;
                }
                if (currentChar == '\n')
                {
                    pr.numOfLines++;
                }
                if (currentChar == ' ' && !(previousChar == ' ')) // co ak mam 10 medzier za sebou!? osetrit, tato podmienka neni dobra -- mozno posielat posledne 2 cahraktery
                {
                    pr.numOfWords++;
                }
                update.update(pr);
            //}
        }
    }
}
