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
        private bool enter = true;

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
                //osetrit pocitanie slov, neratam slova za ktorymi neni medzera
                // treba osetrit viac interpunkcnych znamienok po sebe 
                if (currentChar == '.' || currentChar == '?' || currentChar == '!')
                {
                    pr.numOfSentences++;
                    if (!flag)
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        pr.numOfWords++;
                    }
                }
                if (currentChar == '\n')
                {
                    pr.numOfLines++;
                    if (enter)
                    {
                        enter = false;

                        if (!flag)
                        {
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                            pr.numOfWords++;
                        }
                    }
                }
                if (currentChar == ' ' && !(previousChar == ' ')) // co ak mam 10 medzier za sebou!? osetrit, tato podmienka neni dobra -- mozno posielat posledne 2 cahraktery
                {
                    if (flag) { pr.numOfWords++; }
                    else { flag = true; }

                }
                update.update(pr);
            //}
            
        }
    }
}
