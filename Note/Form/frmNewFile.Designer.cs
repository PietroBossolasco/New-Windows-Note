
namespace Note
{
    partial class frmNewFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCambPerc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPerc = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlCont = new System.Windows.Forms.Panel();
            this.pnlGeneral = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.picShowHide = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlAdvance = new System.Windows.Forms.Panel();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCont.SuspendLayout();
            this.pnlGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShowHide)).BeginInit();
            this.pnlAdvance.SuspendLayout();
            this.flp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(144, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(140, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Nuovo documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome documento:";
            // 
            // txtFileName
            // 
            this.txtFileName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFileName.Location = new System.Drawing.Point(103, 58);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(243, 20);
            this.txtFileName.TabIndex = 2;
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = ".txt";
            // 
            // btnCambPerc
            // 
            this.btnCambPerc.Location = new System.Drawing.Point(103, 107);
            this.btnCambPerc.Name = "btnCambPerc";
            this.btnCambPerc.Size = new System.Drawing.Size(243, 23);
            this.btnCambPerc.TabIndex = 4;
            this.btnCambPerc.Text = "Cambia percorso";
            this.btnCambPerc.UseVisualStyleBackColor = true;
            this.btnCambPerc.Click += new System.EventHandler(this.btnCambPerc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Percorso: ";
            // 
            // lblPerc
            // 
            this.lblPerc.AutoSize = true;
            this.lblPerc.Location = new System.Drawing.Point(103, 84);
            this.lblPerc.Name = "lblPerc";
            this.lblPerc.Size = new System.Drawing.Size(22, 17);
            this.lblPerc.TabIndex = 6;
            this.lblPerc.Text = "C:\\\\";
            this.lblPerc.UseCompatibleTextRendering = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreate.Location = new System.Drawing.Point(119, 166);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(178, 23);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Crea file";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sicurezza";
            // 
            // pnlCont
            // 
            this.pnlCont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlCont.Controls.Add(this.pnlGeneral);
            this.pnlCont.Controls.Add(this.pnlAdvance);
            this.pnlCont.Location = new System.Drawing.Point(3, 3);
            this.pnlCont.MinimumSize = new System.Drawing.Size(400, 275);
            this.pnlCont.Name = "pnlCont";
            this.pnlCont.Size = new System.Drawing.Size(400, 275);
            this.pnlCont.TabIndex = 9;
            // 
            // pnlGeneral
            // 
            this.pnlGeneral.Controls.Add(this.lblTitle);
            this.pnlGeneral.Controls.Add(this.label6);
            this.pnlGeneral.Controls.Add(this.picShowHide);
            this.pnlGeneral.Controls.Add(this.label5);
            this.pnlGeneral.Controls.Add(this.label1);
            this.pnlGeneral.Controls.Add(this.txtFileName);
            this.pnlGeneral.Controls.Add(this.btnCambPerc);
            this.pnlGeneral.Controls.Add(this.label2);
            this.pnlGeneral.Controls.Add(this.lblPerc);
            this.pnlGeneral.Controls.Add(this.label3);
            this.pnlGeneral.Location = new System.Drawing.Point(7, 0);
            this.pnlGeneral.Name = "pnlGeneral";
            this.pnlGeneral.Size = new System.Drawing.Size(376, 159);
            this.pnlGeneral.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(159, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Avanzate";
            this.label6.Click += new System.EventHandler(this.picShowHide_Click);
            // 
            // picShowHide
            // 
            this.picShowHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picShowHide.Image = global::Note.Properties.Resources.unexpand_arrow;
            this.picShowHide.Location = new System.Drawing.Point(137, 134);
            this.picShowHide.Name = "picShowHide";
            this.picShowHide.Size = new System.Drawing.Size(21, 20);
            this.picShowHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShowHide.TabIndex = 12;
            this.picShowHide.TabStop = false;
            this.picShowHide.Click += new System.EventHandler(this.picShowHide_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(166, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Generali";
            // 
            // pnlAdvance
            // 
            this.pnlAdvance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlAdvance.Controls.Add(this.label4);
            this.pnlAdvance.Location = new System.Drawing.Point(11, 158);
            this.pnlAdvance.Name = "pnlAdvance";
            this.pnlAdvance.Size = new System.Drawing.Size(372, 200);
            this.pnlAdvance.TabIndex = 10;
            // 
            // flp
            // 
            this.flp.AutoScroll = true;
            this.flp.Controls.Add(this.pnlCont);
            this.flp.Location = new System.Drawing.Point(3, 1);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(423, 164);
            this.flp.TabIndex = 10;
            // 
            // frmNewFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 201);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.flp);
            this.MaximumSize = new System.Drawing.Size(443, 240);
            this.MinimumSize = new System.Drawing.Size(443, 240);
            this.Name = "frmNewFile";
            this.Text = "Nouvo documento";
            this.Load += new System.EventHandler(this.frmNewFile_Load);
            this.pnlCont.ResumeLayout(false);
            this.pnlGeneral.ResumeLayout(false);
            this.pnlGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShowHide)).EndInit();
            this.pnlAdvance.ResumeLayout(false);
            this.pnlAdvance.PerformLayout();
            this.flp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCambPerc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPerc;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlCont;
        private System.Windows.Forms.Panel pnlAdvance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flp;
        private System.Windows.Forms.PictureBox picShowHide;
        private System.Windows.Forms.Panel pnlGeneral;
    }
}