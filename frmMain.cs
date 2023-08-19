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
        private EditorChanges editorChanges;


        public frmMain()
        {
            InitializeComponent();
            editorChanges = new EditorChanges();
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
            if(translationIDList.SelectedIndex == -1)
            {
                btnTranslationIdDel.Enabled = false;
            }
            else
            {
                btnTranslationIdDel.Enabled = true;
            }

            if (translationIDList.SelectedIndex != -1 && cmbLanguages.SelectedIndex != -1)
            {
                if (translationIDList.SelectedIndex != 0)
                {
                    //Check last translation
                    int lastIndex = translationIDList.SelectedIndex - 1;
                    string lastSelectedID = translationIDList.Items[lastIndex].ToString();
					var cachedTranslationText = dodLanguages.GetLocalizedLanguage(
							lastSelectedID,
							cmbLanguages.SelectedIndex
						);
					if (cachedTranslationText != txtTranslation.Text) //Modified
					{
                        EditorChange editorChange = new EditorChange();
                        editorChange.ChangeType = EditorChangeType.Modify;
                        editorChange.ChangeDataList.Add(new EditorChangeData()
                        {
                            DataAfterChange = new Tuple<string, int, string>(
                                translationIDList.SelectedItem.ToString(),
                                cmbLanguages.SelectedIndex,
                                txtTranslation.Text)
                        });
                        editorChanges.EditorChangeList.Add(editorChange);
					}

					cachedTranslationText = dodLanguages.GetLocalizedLanguage(
							translationIDList.SelectedItem.ToString(),
							cmbLanguages.SelectedIndex
						);
                    txtTranslation.Text = cachedTranslationText;
				}
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
                txtTranslation.Text = cachedTranslationText;
            }
        }

        private void MnuSave_Click(object sender, EventArgs e)
        {
            if (translationIDList.SelectedIndex != -1 && cmbLanguages.SelectedIndex != -1)
			{
				EditorChange editorChange = new EditorChange();
				editorChange.ChangeType = EditorChangeType.Modify;
				editorChange.ChangeDataList.Add(new EditorChangeData()
				{
					DataAfterChange = new Tuple<string, int, string>(
						translationIDList.SelectedItem.ToString(),
						cmbLanguages.SelectedIndex,
						txtTranslation.Text)
				});
				editorChanges.EditorChangeList.Add(editorChange);

				mnuSave.Enabled = false;
			}
        }

        private void mnuSaveAll_Click(object sender, EventArgs e)
        {
            DoDEditorChangeApplier applier = new 
                DoDEditorChangeApplier(editorChanges.EditorChangeList, dodLanguages);
            applier.ApplyChanges();

			dodLanguages.SaveToCSV().Save(languageCSVFilePath);
            MessageBox.Show("Save File Successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmMain_FormClosed(object sender, FormClosingEventArgs e)
        {
            if (editorChanges.EditorChangeList.Count > 0)
            {
                mnuSaveAll_Click(sender, e);
            }
        }

        private void btnTranslationIdAdd_Click(object sender, EventArgs e)
        {
            frmNewTranslation createNewTranslationWin = new frmNewTranslation();
            if (createNewTranslationWin.ShowDialog() == DialogResult.OK)
            {
                EditorChange editorChange = new EditorChange();
                editorChange.ChangeType = EditorChangeType.Add;
                editorChange.ChangeDataList.Add(new EditorChangeData()
                {
                    DataObject = "obj_DoDLanguage",
                    DataBeforeChange = null,
                    DataAfterChange = new Tuple<string, string>(
                        createNewTranslationWin.ID,
                        createNewTranslationWin.TranslationText)
                });
                editorChanges.EditorChangeList.Add(editorChange);

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
                EditorChange editorChange = new EditorChange();
                editorChange.ChangeType = EditorChangeType.Delete;
                editorChange.ChangeDataList.Add(new EditorChangeData()
                {
                    DataObject = "obj_DoDLanguage",
                    DataBeforeChange = translationIDList.SelectedItem.ToString(),
                    DataAfterChange = null
				});
                editorChanges.EditorChangeList.Add(editorChange);

                txtTranslation.Text = null;
                translationIDList.SelectedIndex = -1;
            }
        }

		private void btnSave_Click(object sender, EventArgs e)
		{
            MnuSave_Click(sender, e);
            btnSave.Enabled = false;
		}

		private void txtTranslation_TextChanged(object sender, EventArgs e)
		{
			var cachedTranslationText = dodLanguages.GetLocalizedLanguage(
					translationIDList.SelectedItem.ToString(),
					cmbLanguages.SelectedIndex
				);
            if(cachedTranslationText != txtTranslation.Text && editorChanges.FindChange
                (EditorChangeType.Modify, new Tuple<string, int, string>(
                    translationIDList.SelectedItem.ToString(),
					cmbLanguages.SelectedIndex, txtTranslation.Text)))
			{
				mnuSave.Enabled = true;
				btnSave.Enabled = true;
            }
            else
			{
				mnuSave.Enabled = true;
				btnSave.Enabled = false;
            }
		}
	}
}
