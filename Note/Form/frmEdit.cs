using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using clstxt;
using ManageDoc;

namespace Note
{
    public partial class frmEdit : Form
    {
        //Indica il path del file su cui si stà lavorando
        private string path;
        //Indica se il file è stato salvato
        private bool saved;
        //Salva il testo allo stato dell'ultimo salvataggio
        private string txt;
        //Salva il nome del file
        private string fileName;
        //Indica se il file è appena stato creato
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

        private void tsNewFile_Click(object sender, EventArgs e)
        {
            //Apre la finestra per la configurazione di un nuovo file;
            frmNewFile fnf = new frmNewFile();
            fnf.Show();
        }

        private void frmEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Richide all'utente se è sicuro di chiudere il file senza salvare
            //TODO: Avviare questo processo solo quando il file non è già stato salvato
            var save = MessageBox.Show("Vuoi salvare prima di chiudere il progetto?", "Salva", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (save == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (save == DialogResult.No)
            {
                Application.Exit();
            }
            else if (save == DialogResult.Cancel)
                e.Cancel = true;
        }
    }
}