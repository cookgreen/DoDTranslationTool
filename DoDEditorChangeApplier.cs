using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoDTranslationTool
{
	public class DoDEditorChangeApplier
	{
		private List<EditorChange> pendingChanges;
		private DoDLanguages dodLanguages;

		public DoDEditorChangeApplier(
			List<EditorChange> pendingChanges, 
			DoDLanguages dodLanguages)
		{
			this.pendingChanges = pendingChanges;
			this.dodLanguages = dodLanguages;
		}

		public void ApplyChanges()
		{
			foreach (EditorChange change in pendingChanges) 
			{
				switch(change.ChangeType)
				{
					case EditorChangeType.Add:
						applyChangeAdd(change);
						break;
					case EditorChangeType.Delete:
						applyChangeDelete(change);
						break;
					case EditorChangeType.Modify:
						applyChangeModify(change);
						break;
				}
			}
		}

		private void applyChangeAdd(EditorChange change)
		{
			EditorChangeData data = change.ChangeDataList[0];
			Tuple<string, string> addedTranslation = data.DataAfterChange as Tuple<string, string>;
			dodLanguages.AddNewTranslation(addedTranslation.Item1, addedTranslation.Item2);
		}

		private void applyChangeModify(EditorChange change)
		{
			EditorChangeData data = change.ChangeDataList[0];
			Tuple<string, int, string> modifiedData = data.DataAfterChange as Tuple<string, int, string>;
			dodLanguages.SetLocalizedLanguageStr(modifiedData.Item1, modifiedData.Item2, modifiedData.Item3);
		}

		private void applyChangeDelete(EditorChange change)
		{
			EditorChangeData data = change.ChangeDataList[0];
			string deletedData = data.DataBeforeChange as string;
			dodLanguages.DeleteTranslationID(deletedData);
		}
	}
}
