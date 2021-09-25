
namespace Note
{
    partial class frmEdit
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
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSalva = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSalvaConNome = new System.Windows.Forms.ToolStripMenuItem();
            this.tsApriFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.impostazioniDiSicurezzaDelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferenzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impostazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vaiAlSitoWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbText
            // 
            this.rtbText.AcceptsTab = true;
            this.rtbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbText.Location = new System.Drawing.Point(4, 24);
            this.rtbText.Name = "rtbText";
            this.rtbText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbText.Size = new System.Drawing.Size(794, 423);
            this.rtbText.TabIndex = 1;
            this.rtbText.Text = "";
            this.rtbText.ZoomFactor = 1.3F;
            this.rtbText.TextChanged += new System.EventHandler(this.rtbText_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preferenzeToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvaToolStripMenuItem,
            this.tsApriFile,
            this.tsNewFile,
            this.impostazioniDiSicurezzaDelFileToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // salvaToolStripMenuItem
            // 
            this.salvaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSalva,
            this.tsSalvaConNome});
            this.salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            this.salvaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.salvaToolStripMenuItem.Text = "Salva";
            // 
            // tsSalva
            // 
            this.tsSalva.Name = "tsSalva";
            this.tsSalva.Size = new System.Drawing.Size(158, 22);
            this.tsSalva.Text = "Salva";
            this.tsSalva.Click += new System.EventHandler(this.tsSalva_Click);
            // 
            // tsSalvaConNome
            // 
            this.tsSalvaConNome.Name = "tsSalvaConNome";
            this.tsSalvaConNome.Size = new System.Drawing.Size(158, 22);
            this.tsSalvaConNome.Text = "Salva con nome";
            this.tsSalvaConNome.Click += new System.EventHandler(this.tsSalvaConNome_Click);
            // 
            // tsApriFile
            // 
            this.tsApriFile.Name = "tsApriFile";
            this.tsApriFile.Size = new System.Drawing.Size(160, 22);
            this.tsApriFile.Text = "Apri file";
            this.tsApriFile.Click += new System.EventHandler(this.tsApriFile_Click);
            // 
            // tsNewFile
            // 
            this.tsNewFile.Name = "tsNewFile";
            this.tsNewFile.Size = new System.Drawing.Size(160, 22);
            this.tsNewFile.Text = "Nuovo file";
            this.tsNewFile.Click += new System.EventHandler(this.tsNewFile_Click);
            // 
            // impostazioniDiSicurezzaDelFileToolStripMenuItem
            // 
            this.impostazioniDiSicurezzaDelFileToolStripMenuItem.Name = "impostazioniDiSicurezzaDelFileToolStripMenuItem";
            this.impostazioniDiSicurezzaDelFileToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.impostazioniDiSicurezzaDelFileToolStripMenuItem.Text = "Sicurezza del file";
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.esciToolStripMenuItem.Text = "Esci";
            // 
            // preferenzeToolStripMenuItem
            // 
            this.preferenzeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impostazioniToolStripMenuItem});
            this.preferenzeToolStripMenuItem.Name = "preferenzeToolStripMenuItem";
            this.preferenzeToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.preferenzeToolStripMenuItem.Text = "Preferenze";
            // 
            // impostazioniToolStripMenuItem
            // 
            this.impostazioniToolStripMenuItem.Name = "impostazioniToolStripMenuItem";
            this.impostazioniToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.impostazioniToolStripMenuItem.Text = "Impostazioni";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vaiAlSitoWebToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // vaiAlSitoWebToolStripMenuItem
            // 
            this.vaiAlSitoWebToolStripMenuItem.Name = "vaiAlSitoWebToolStripMenuItem";
            this.vaiAlSitoWebToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.vaiAlSitoWebToolStripMenuItem.Text = "Vai al sito web";
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEdit";
            this.Text = "Modifica file";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEdit_FormClosing);
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEdit_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsSalva;
        private System.Windows.Forms.ToolStripMenuItem tsSalvaConNome;
        private System.Windows.Forms.ToolStripMenuItem tsApriFile;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferenzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impostazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vaiAlSitoWebToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impostazioniDiSicurezzaDelFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsNewFile;
    }
}