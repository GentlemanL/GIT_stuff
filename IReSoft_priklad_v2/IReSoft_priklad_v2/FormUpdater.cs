﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IReSoft_priklad_v2
{
    class FormUpdater : IUpdater
    {
        private Form1 form;

        public FormUpdater(Form1 form)
        {
            this.form = form;
        }

        public void update(Progress p)
        {
            updateContorlProperty(form.labelPocetRiadkov, "Text", "Pocet riadkov: " + p.numOfLines);
            updateContorlProperty(form.labelNumberOfWords, "Text", "Pocet slov: " + p.numOfWords);
            updateContorlProperty(form.labelPocetZnakov, "Text", "Pocet znakov: " + p.numOfChars);
            updateContorlProperty(form.labelPocetViet, "Text", "Pocet viet: " + p.numOfSentences);

            //progress bar ide hned
            if (!(p.progressBarValue == 100))
                updateContorlProperty(form.progressBar1, "Value", p.progressBarValue + 1);
            updateContorlProperty(form.progressBar1, "Value", p.progressBarValue);
            updateContorlProperty(form.labelPercent, "Text", p.progressBarValue + " %");
            
            if (p.progressBarValue == 100)
            {
                MethodInvoker action = () => form.panel1.Enabled = true;
                form.panel1.BeginInvoke(action);

                p.progressBarValue = 0;
                
                // mozno spravit inak aby to nebola zbytocan skoro duplicita kodu
                updateContorlProperty(form.labelOutputWords, "Text", "Pocet slov: " + p.numOfWords);
                updateContorlProperty(form.labelOutputCharacters, "Text", "Pocet znakov: " + p.numOfChars);
                updateContorlProperty(form.labelOutputSentences, "Text", "Pocet viet: " + p.numOfSentences);

                //p.numOfLinesAfterRemove = s.text.Split('\n').Length;
                //p.numOfLinesAfterRemove = CountLines(s);
                //updateContorlProperty(form.labelOutputLines, "Text", "Pocet riadkov: " + CountLines(s));
            }
        }
        /*
        private static int CountLines(string s)
        {
            int n = 0;
            foreach (var c in s)
            {
                if (c == '\n') n++;
            }
            return n + 1;
        }*/

        private void updateContorlProperty(Control control, string propertyName, object propertyValue)
        {
                control.Invoke(new SetControlPropertyDelegate(SetControlProperty), new object[] { control, propertyName, propertyValue });
        }

        private delegate void SetControlPropertyDelegate(Control control, string propertyName, object propertyValue);
        private static void SetControlProperty(Control control, string propertyName, object propertyValue)
        {
            control.GetType().InvokeMember(propertyName, BindingFlags.SetProperty, null, control, new object[] { propertyValue });
        }
    }
}
