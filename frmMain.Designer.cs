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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.translationIDList = new System.Windows.Forms.ListBox();
			this.lbLanguage = new System.Windows.Forms.Label();
			this.cmbLanguages = new System.Windows.Forms.ComboBox();
			this.txtTranslation = new System.Windows.Forms.RichTextBox();
			this.main_menu = new System.Windows.Forms.MenuStrip();
			this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSaveAll = new System.Windows.Forms.ToolStripMenuItem();
			this.btnTranslationIdAdd = new System.Windows.Forms.Button();
			this.btnTranslationIdDel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.main_menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// translationIDList
			// 
			this.translationIDList.FormattingEnabled = true;
			this.translationIDList.ItemHeight = 15;
			this.translationIDList.Location = new System.Drawing.Point(16, 79);
			this.translationIDList.Margin = new System.Windows.Forms.Padding(4);
			this.translationIDList.Name = "translationIDList";
			this.translationIDList.Size = new System.Drawing.Size(249, 619);
			this.translationIDList.TabIndex = 0;
			this.translationIDList.SelectedIndexChanged += new System.EventHandler(this.translationIDList_SelectedIndexChanged);
			// 
			// lbLanguage
			// 
			this.lbLanguage.AutoSize = true;
			this.lbLanguage.Location = new System.Drawing.Point(281, 50);
			this.lbLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbLanguage.Name = "lbLanguage";
			this.lbLanguage.Size = new System.Drawing.Size(79, 15);
			this.lbLanguage.TabIndex = 1;
			this.lbLanguage.Text = "Language:";
			// 
			// cmbLanguages
			// 
			this.cmbLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbLanguages.Enabled = false;
			this.cmbLanguages.FormattingEnabled = true;
			this.cmbLanguages.Location = new System.Drawing.Point(368, 46);
			this.cmbLanguages.Margin = new System.Windows.Forms.Padding(4);
			this.cmbLanguages.Name = "cmbLanguages";
			this.cmbLanguages.Size = new System.Drawing.Size(193, 23);
			this.cmbLanguages.TabIndex = 2;
			this.cmbLanguages.SelectedIndexChanged += new System.EventHandler(this.cmbLanguages_SelectedIndexChanged);
			// 
			// txtTranslation
			// 
			this.txtTranslation.Enabled = false;
			this.txtTranslation.Location = new System.Drawing.Point(276, 79);
			this.txtTranslation.Margin = new System.Windows.Forms.Padding(4);
			this.txtTranslation.Name = "txtTranslation";
			this.txtTranslation.Size = new System.Drawing.Size(791, 548);
			this.txtTranslation.TabIndex = 3;
			this.txtTranslation.Text = "";
			this.txtTranslation.TextChanged += new System.EventHandler(this.txtTranslation_TextChanged);
			// 
			// main_menu
			// 
			this.main_menu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
			this.main_menu.Location = new System.Drawing.Point(0, 0);
			this.main_menu.Name = "main_menu";
			this.main_menu.Size = new System.Drawing.Size(1084, 28);
			this.main_menu.TabIndex = 5;
			this.main_menu.Text = "menuStrip1";
			// 
			// mnuFile
			// 
			this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuSave,
            this.mnuSaveAll});
			this.mnuFile.Name = "mnuFile";
			this.mnuFile.Size = new System.Drawing.Size(48, 24);
			this.mnuFile.Text = "File";
			// 
			// mnuOpen
			// 
			this.mnuOpen.Name = "mnuOpen";
			this.mnuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.mnuOpen.Size = new System.Drawing.Size(248, 26);
			this.mnuOpen.Text = "Open";
			this.mnuOpen.Click += new System.EventHandler(this.MnuOpen_Click);
			// 
			// mnuSave
			// 
			this.mnuSave.Enabled = false;
			this.mnuSave.Name = "mnuSave";
			this.mnuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.mnuSave.Size = new System.Drawing.Size(248, 26);
			this.mnuSave.Text = "Save";
			this.mnuSave.Click += new System.EventHandler(this.MnuSave_Click);
			// 
			// mnuSaveAll
			// 
			this.mnuSaveAll.Enabled = false;
			this.mnuSaveAll.Name = "mnuSaveAll";
			this.mnuSaveAll.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.mnuSaveAll.Size = new System.Drawing.Size(248, 26);
			this.mnuSaveAll.Text = "Save All";
			this.mnuSaveAll.Click += new System.EventHandler(this.mnuSaveAll_Click);
			// 
			// btnTranslationIdAdd
			// 
			this.btnTranslationIdAdd.Enabled = false;
			this.btnTranslationIdAdd.Location = new System.Drawing.Point(16, 46);
			this.btnTranslationIdAdd.Margin = new System.Windows.Forms.Padding(4);
			this.btnTranslationIdAdd.Name = "btnTranslationIdAdd";
			this.btnTranslationIdAdd.Size = new System.Drawing.Size(36, 25);
			this.btnTranslationIdAdd.TabIndex = 6;
			this.btnTranslationIdAdd.Text = "+";
			this.btnTranslationIdAdd.UseVisualStyleBackColor = true;
			this.btnTranslationIdAdd.Click += new System.EventHandler(this.btnTranslationIdAdd_Click);
			// 
			// btnTranslationIdDel
			// 
			this.btnTranslationIdDel.Enabled = false;
			this.btnTranslationIdDel.Location = new System.Drawing.Point(60, 46);
			this.btnTranslationIdDel.Margin = new System.Windows.Forms.Padding(4);
			this.btnTranslationIdDel.Name = "btnTranslationIdDel";
			this.btnTranslationIdDel.Size = new System.Drawing.Size(36, 26);
			this.btnTranslationIdDel.TabIndex = 7;
			this.btnTranslationIdDel.Text = "-";
			this.btnTranslationIdDel.UseVisualStyleBackColor = true;
			this.btnTranslationIdDel.Click += new System.EventHandler(this.btnTranslationIdDel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Enabled = false;
			this.btnSave.Location = new System.Drawing.Point(937, 634);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(130, 64);
			this.btnSave.TabIndex = 8;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1084, 714);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnTranslationIdDel);
			this.Controls.Add(this.btnTranslationIdAdd);
			this.Controls.Add(this.txtTranslation);
			this.Controls.Add(this.cmbLanguages);
			this.Controls.Add(this.lbLanguage);
			this.Controls.Add(this.translationIDList);
			this.Controls.Add(this.main_menu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.main_menu;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Darkest of Days Translation Tool";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosed);
			this.main_menu.ResumeLayout(false);
			this.main_menu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox translationIDList;
        private System.Windows.Forms.Label lbLanguage;
        private System.Windows.Forms.ComboBox cmbLanguages;
        private System.Windows.Forms.RichTextBox txtTranslation;
        private System.Windows.Forms.MenuStrip main_menu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
		private System.Windows.Forms.ToolStripMenuItem mnuSaveAll;
		private System.Windows.Forms.Button btnTranslationIdAdd;
		private System.Windows.Forms.Button btnTranslationIdDel;
		private System.Windows.Forms.Button btnSave;
	}
}

