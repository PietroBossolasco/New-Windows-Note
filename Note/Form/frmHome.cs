﻿using System;
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

        private void pnlNewDoc_Click(object sender, EventArgs e)
        {
            frmNewFile fnf = new frmNewFile();  
            fnf.Activate();
            fnf.Show();
            this.Visible = false;
        }
    }
}
