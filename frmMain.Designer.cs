namespace DoDTranslationTool
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.translationIDList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLanguages = new System.Windows.Forms.ComboBox();
            this.txtTranslation = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTranslationIdAdd = new System.Windows.Forms.Button();
            this.btnTranslationIdDel = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // translationIDList
            // 
            this.translationIDList.FormattingEnabled = true;
            this.translationIDList.ItemHeight = 12;
            this.translationIDList.Location = new System.Drawing.Point(12, 63);
            this.translationIDList.Name = "translationIDList";
            this.translationIDList.Size = new System.Drawing.Size(188, 496);
            this.translationIDList.TabIndex = 0;
            this.translationIDList.SelectedIndexChanged += new System.EventHandler(this.translationIDList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Language:";
            // 
            // cmbLanguages
            // 
            this.cmbLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguages.FormattingEnabled = true;
            this.cmbLanguages.Location = new System.Drawing.Point(276, 37);
            this.cmbLanguages.Name = "cmbLanguages";
            this.cmbLanguages.Size = new System.Drawing.Size(146, 20);
            this.cmbLanguages.TabIndex = 2;
            this.cmbLanguages.SelectedIndexChanged += new System.EventHandler(this.cmbLanguages_SelectedIndexChanged);
            // 
            // txtTranslation
            // 
            this.txtTranslation.Location = new System.Drawing.Point(207, 63);
            this.txtTranslation.Name = "txtTranslation";
            this.txtTranslation.Size = new System.Drawing.Size(594, 494);
            this.txtTranslation.TabIndex = 3;
            this.txtTranslation.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuSave,
            this.mnuSaveAll});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpen.Size = new System.Drawing.Size(199, 22);
            this.mnuOpen.Text = "Open";
            this.mnuOpen.Click += new System.EventHandler(this.MnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Enabled = false;
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSave.Size = new System.Drawing.Size(199, 22);
            this.mnuSave.Text = "Save";
            this.mnuSave.Click += new System.EventHandler(this.MnuSave_Click);
            // 
            // mnuSaveAll
            // 
            this.mnuSaveAll.Enabled = false;
            this.mnuSaveAll.Name = "mnuSaveAll";
            this.mnuSaveAll.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mnuSaveAll.Size = new System.Drawing.Size(199, 22);
            this.mnuSaveAll.Text = "Save All";
            this.mnuSaveAll.Click += new System.EventHandler(this.mnuSaveAll_Click);
            // 
            // btnTranslationIdAdd
            // 
            this.btnTranslationIdAdd.Enabled = false;
            this.btnTranslationIdAdd.Location = new System.Drawing.Point(12, 37);
            this.btnTranslationIdAdd.Name = "btnTranslationIdAdd";
            this.btnTranslationIdAdd.Size = new System.Drawing.Size(27, 20);
            this.btnTranslationIdAdd.TabIndex = 6;
            this.btnTranslationIdAdd.Text = "+";
            this.btnTranslationIdAdd.UseVisualStyleBackColor = true;
            this.btnTranslationIdAdd.Click += new System.EventHandler(this.btnTranslationIdAdd_Click);
            // 
            // btnTranslationIdDel
            // 
            this.btnTranslationIdDel.Enabled = false;
            this.btnTranslationIdDel.Location = new System.Drawing.Point(45, 37);
            this.btnTranslationIdDel.Name = "btnTranslationIdDel";
            this.btnTranslationIdDel.Size = new System.Drawing.Size(27, 21);
            this.btnTranslationIdDel.TabIndex = 7;
            this.btnTranslationIdDel.Text = "-";
            this.btnTranslationIdDel.UseVisualStyleBackColor = true;
            this.btnTranslationIdDel.Click += new System.EventHandler(this.btnTranslationIdDel_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 571);
            this.Controls.Add(this.btnTranslationIdDel);
            this.Controls.Add(this.btnTranslationIdAdd);
            this.Controls.Add(this.txtTranslation);
            this.Controls.Add(this.cmbLanguages);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.translationIDList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Darkest of Days Translation Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox translationIDList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLanguages;
        private System.Windows.Forms.RichTextBox txtTranslation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
		private System.Windows.Forms.ToolStripMenuItem mnuSaveAll;
		private System.Windows.Forms.Button btnTranslationIdAdd;
		private System.Windows.Forms.Button btnTranslationIdDel;
	}
}

