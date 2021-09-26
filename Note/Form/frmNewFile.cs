using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageDoc;

namespace Note
{
    public partial class frmNewFile : Form
    {
        string folder;
        string path;
        string fileName;

        bool advancedOpen;

        public frmNewFile()
        {
            InitializeComponent();
        }

        private void frmNewFile_Load(object sender, EventArgs e)
        {
            advancedOpen = false;
            pnlAdvance.Visible = false;
        }

        private void btnCambPerc_Click(object sender, EventArgs e)
        {
            folder = clsManageDoc.chooseFolder();
            path = folder + "\\" + fileName;
            lblPerc.Text = path;
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {
            fileName = txtFileName.Text + ".txt";
            path = folder + "\\" + fileName;
            lblPerc.Text = path;
        }

        private void picShowHide_Click(object sender, EventArgs e)
        {
            if (!advancedOpen)
            {
                picShowHide.Image = Properties.Resources.expand_arrow;
                advancedOpen = true;
                pnlAdvance.Visible = true;
                flp.Height = pnlGeneral.Height;
            }
            else if (advancedOpen)
            {
                picShowHide.Image = Properties.Resources.unexpand_arrow;
                advancedOpen = false;
                pnlAdvance.Visible = false;
                flp.Height = pnlGeneral.Height + pnlAdvance.Height;
            }
        }
    }
}
