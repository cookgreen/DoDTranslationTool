using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoDTranslationTool
{
    public partial class frmMain : Form
    {
        private string languageCSVFilePath;
        private DoDLanguages dodLanguages;
        private Stack<Tuple<string, int, string>> changes;
        private bool isFirstlyLanguageSelected = true;


        public frmMain()
        {
            InitializeComponent();
            changes = new Stack<Tuple<string, int, string>>();
        }

        private void MnuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Darkest of Days Language File|language.csv";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                languageCSVFilePath = dialog.FileName;
                ReadLanguageCSV();
                mnuSave.Enabled = true;
                mnuSaveAll.Enabled = true;
                btnTranslationIdAdd.Enabled = true;
            }
        }

        private void ReadLanguageCSV()
        {
            dodLanguages = new DoDLanguages(new CSV(languageCSVFilePath));
            List<string> ids = dodLanguages.GetAllStrID();
            int num = dodLanguages.LanguageNum;
            translationIDList.Items.Clear();
            cmbLanguages.Items.Clear();
            foreach (var id in ids)
            {
                translationIDList.Items.Add(id);
            }
            for (int i = 0; i < num; i++)
            {
                cmbLanguages.Items.Add(i);
            }
            if (translationIDList.Items.Count > 0)
            {
                translationIDList.SelectedIndex = 0;
            }
            if (cmbLanguages.Items.Count > 0)
            {
                cmbLanguages.SelectedIndex = 0;
            }
        }

        private void translationIDList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (translationIDList.SelectedIndex != -1 && cmbLanguages.SelectedIndex != -1)
            {
                if (translationIDList.SelectedIndex != -1)
                {
                    btnTranslationIdDel.Enabled = true;
                }
                var cachedTranslationText = dodLanguages.GetLocalizedLanguage(
                        translationIDList.SelectedItem.ToString(),
                        cmbLanguages.SelectedIndex
                    );
                if (cachedTranslationText != txtTranslation.Text)
                {
                    changes.Push(new Tuple<string, int, string>(
                        translationIDList.SelectedItem.ToString(),
                        cmbLanguages.SelectedIndex,
                        txtTranslation.Text)
                    );
                }
                txtTranslation.Text = cachedTranslationText;
            }
        }

        private void cmbLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (translationIDList.SelectedIndex != -1 && cmbLanguages.SelectedIndex != -1)
            {
                var cachedTranslationText = dodLanguages.GetLocalizedLanguage(
                        translationIDList.SelectedItem.ToString(),
                        cmbLanguages.SelectedIndex
                    );
                if (isFirstlyLanguageSelected)
                {
                    isFirstlyLanguageSelected = false;
                }
                else
                {
                    if (cachedTranslationText != txtTranslation.Text)
                    {
                        changes.Push(new Tuple<string, int, string>(
                            translationIDList.SelectedItem.ToString(),
                            cmbLanguages.SelectedIndex,
                            txtTranslation.Text)
                        );
                    }
                }
                txtTranslation.Text = cachedTranslationText;
            }
        }

        private void MnuSave_Click(object sender, EventArgs e)
        {
            if (translationIDList.SelectedIndex != -1 && cmbLanguages.SelectedIndex != -1)
            {
                changes.Push(new Tuple<string, int, string>(
                    translationIDList.SelectedItem.ToString(),
                    cmbLanguages.SelectedIndex,
                    txtTranslation.Text)
                );
            }
        }

        private void mnuSaveAll_Click(object sender, EventArgs e)
        {
            while (changes.Count > 0)
            {
                var change = changes.Pop();
                dodLanguages.SetLocalizedLanguageStr(
                    change.Item1,
                    change.Item2,
                    change.Item3
                );
            }
            dodLanguages.SaveToCSV().Save(languageCSVFilePath);
            MessageBox.Show("Save File Successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmMain_FormClosed(object sender, FormClosingEventArgs e)
        {
            if (changes.Count > 0)
            {
                if (MessageBox.Show("There are unsaved changes, do you want to save them?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    mnuSaveAll_Click(sender, new EventArgs());
                }
            }
        }

        private void btnTranslationIdAdd_Click(object sender, EventArgs e)
        {
            frmNewTranslation createNewTranslationWin = new frmNewTranslation();
            if (createNewTranslationWin.ShowDialog() == DialogResult.OK)
            {
                dodLanguages.AddTranslationID(createNewTranslationWin.ID);
                int idx = translationIDList.Items.Add(createNewTranslationWin.ID);
                translationIDList.SelectedIndex = idx;
                txtTranslation.Text = createNewTranslationWin.ID;
            }
        }

        private void btnTranslationIdDel_Click(object sender, EventArgs e)
        {
            if (translationIDList.SelectedIndex == -1)
            {
                return;
            }
            if (MessageBox.Show("Are you sure to delete this ID?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dodLanguages.DeleteTranslationID(translationIDList.SelectedItem.ToString());
                txtTranslation.Text = null;
                translationIDList.SelectedIndex = -1;
            }
        }

		private void btnSave_Click(object sender, EventArgs e)
		{

		}
	}
}
