using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kommunicator
{
    public partial class Form1 : Form
    {
        #region attributes & init
        private static List<char> alphabet;
        private bool copyToClipboard;
        private bool idiotMode;

        public Form1()
        {
            InitializeComponent();
            alphabet = new List<char>() { 'a', 'b' , 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
            'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'é', 'à', 'è', 'ù', 'ô', 'ö', 'ü', 'û', 'â', 'ä'};
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            copyToClipboard = copyAuto.Checked;

        }

        #endregion
        #region buttons
        private void toStrange_Click(object sender, EventArgs e)
        {
            String translation;

            if (idiotMode)
            {
                translation = idiot_toStrange();
            }
            else
            {
                translation = elaborated_toStrange();
            }

            strangeText.Text = translation;

            if (copyToClipboard)
            {
                System.Windows.Forms.Clipboard.SetText(translation);
            }
        }

        private void toFrench_Click(object sender, EventArgs e)
        {
            String translation;

            if (idiotMode)
            {
                translation = idiot_toFrench();
            }else
            {
                translation = elaborated_toFrench();
            }

            frenchText.Text = translation;

            if (copyToClipboard)
            {
                System.Windows.Forms.Clipboard.SetText(translation);
            }
        }
        #endregion
        #region checks
        private void copyAuto_CheckedChanged(object sender, EventArgs e)
        {
            copyToClipboard = copyAuto.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            idiotMode = checkBox1.Checked;
        }
        #endregion
        #region traduction
        #region elaborated
        private String elaborated_toStrange()
        {
            String french = frenchText.Text;
            char[] translate = french.ToCharArray();

            String deguiton = "";
            Random r = new Random();

            foreach (char c in translate)
            {
                if (c <= 64)
                {
                    deguiton += c;
                }
                else
                {
                    deguiton += c;
                    deguiton += (alphabet[r.Next(alphabet.Count)]);
                }
            }

            return deguiton;
        }

        private String elaborated_toFrench()
        {
            String deguiton = strangeText.Text;
            char[] translate = deguiton.ToCharArray();

            String french = "";
            String temp = "";
            List<String> tempList = new List<string>();

            foreach (char c in translate)
            {
                if (c >= 65)
                {
                    temp += c;

                }
                else
                {
                    if (temp != "")
                    {
                        tempList.Add(temp);
                        temp = "";
                    }
                    if (c >= 33 && c <= 64)
                    {
                        tempList.Add(c.ToString());
                    }
                }
            }

            tempList.Add(temp);

            for (int j = 0; j < tempList.Count; j++)
            {
                String translated = "";

                for (int i = 0; i < tempList[j].Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        translated += tempList[j][i];
                    }
                }

                if (translated != "")
                {
                    if (translated[0] >= 33 && translated[0] <= 64)
                    {
                        try
                        {
                            if (tempList[j + 1][0] >= 33 && tempList[j + 1][0] <= 64)
                            {
                                french += translated;
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                            french += translated;
                        }

                    }
                    else
                    {
                        french += translated + " ";
                    }
                }
            }

            return french;
        }
        #endregion
        #region idiot

        private String idiot_toStrange()
        {
            Random r = new Random();
            String french = frenchText.Text;

            String idiot = "";

            foreach(char c in french.ToCharArray())
            {
                idiot += c;
                idiot += alphabet[r.Next(alphabet.Count)];
            }

            return idiot;
        }

        private String idiot_toFrench()
        {
            String idiot = strangeText.Text;
            String french = "";

            for(int i = 0;i< idiot.Length; i++)
            {
                if(i % 2 == 0)
                {
                    french += idiot[i];
                }
            }

            return french;
        }
        #endregion
        #endregion
    }
}
