using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clstxt;
using ManageDoc;

namespace Note
{
    public partial class frmEdit : Form
    {
        private string path;
        private bool saved;
        private string txt;
        private string fileName;
        public bool isNew;

        public frmEdit()
        {
            InitializeComponent();
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            path = "C:\\Users\\imink\\Desktop\\file.txt";
            saved = true;
            txt = rtbText.Text;
        }

        private void tsSalva_Click(object sender, EventArgs e)
        {
            if (!clsManageDoc.existFile(path))
            {
                clsManageDoc.createFile(path);
            }

            clsTxt.saveText(rtbText, path);
            saved = true;
            txt = rtbText.Text;
        }

        private void rtbText_TextChanged(object sender, EventArgs e)
        {
            if (rtbText.Text != txt)
            {
                saved = false;
            }
        }

        private void tsSalvaConNome_Click(object sender, EventArgs e)
        {
            path = clsManageDoc.chooseFile();
        }

        private void tsApriFile_Click(object sender, EventArgs e)
        {
            string[] text = new string[0];

            path = clsManageDoc.chooseFile();
            clsTxt.readFile(path, ref text);
            clsTxt.printRtb(rtbText, text);
        }

        private void frmEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if(Control.ModifierKeys == Keys.Control)
            {
                Console.WriteLine("a");
            }
        }

        private void rtbText_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control && Control.ModifierKeys == Keys.S)
            {
                Console.WriteLine("Saved");
            }
        }

        private void tsNewFile_Click(object sender, EventArgs e)
        {
            frmNewFile fnf = new frmNewFile();

            fnf.Show();
        }
    }
}
