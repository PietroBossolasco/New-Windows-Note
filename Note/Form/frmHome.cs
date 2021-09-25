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

namespace Note
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            clsSetting.inizializeSettings();
        }

        private void btnNewFile_Click(object sender, EventArgs e)
        {
            frmEdit ed = new frmEdit();
            ed.Activate();
            ed.Show();
            this.Visible = false;
        }

    }
}
