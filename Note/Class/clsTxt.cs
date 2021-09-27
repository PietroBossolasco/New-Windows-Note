using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace clstxt
{
    class clsTxt
    {
        public static void saveText(RichTextBox rtb, string path)
        {
            StreamWriter sw = new StreamWriter(path);

            sw.WriteLine(rtb.Text);
            sw.Close();
        }

        public static void readFile(string path,ref string[] text)
        {
            StreamReader sr = new StreamReader(path);

            int i = 0;

            while (!sr.EndOfStream)
            {
                Array.Resize(ref text, text.Length + 1);
                text[i] += sr.ReadLine();
                i++;
            }

            sr.Close();
        }

        public static void printRtb(RichTextBox rtb, string[] text)
        {
            rtb.Text = "";

            foreach (string s in text)
            {
                rtb.Text += s + "\n";
            }
        }
    }
}
