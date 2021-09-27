using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Settings;
using ManageDoc;

namespace Note
{
    public partial class frmHome : Form
    {
        public string path;

        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            clsSetting.inizializeSettings();
            path = string.Empty;
        }

        private void pnlNewDoc_Click(object sender, EventArgs e)
        {
            frmNewFile fnf = new frmNewFile();  
            fnf.Activate();
            fnf.Show();
            this.Visible = false;
        }

        private void pnlOpenDoc_Click(object sender, EventArgs e)
        {
            this.path = clsManageDoc.chooseFile();
            frmEdit fe = new frmEdit();
            fe.Activate();
            fe.Show();
            this.Visible = false;
        }
    }
}
