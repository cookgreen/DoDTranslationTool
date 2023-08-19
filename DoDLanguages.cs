using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoDTranslationTool
{
	public class DoDLanguages
	{
		private CSV languageCSVObject;
		private List<DoDLanguage> dic;

		public int LanguageNum
		{
			get { return languageCSVObject.ColNum - 1; }
		}

		public DoDLanguages(CSV languageCSVObject)
		{
			dic = new List<DoDLanguage>();
			this.languageCSVObject = languageCSVObject;
			readCSVLanguangeData(languageCSVObject);
		}

		public string GetLocalizedLanguage(string strID, int langIndex)
		{
			return dic[langIndex].GetTranslationByID(strID);
		}

		public void SetLocalizedLanguageStr(string strID, int langIndex, string localizedStr)
		{
			dic[langIndex].ModifyTranslation(strID, localizedStr);
		}

		public List<string> GetAllStrID()
		{
			return dic[0].GetTranslationIDList();
		}

		public int GetLanguageNumber()
		{
			return dic.Count;
		}

		public void AddTranslationID(string value)
		{
			for (int i = 0; i < dic.Count; i++)
			{
				dic[i].AddNewTranslation(value, string.Empty);
			}
		}

		public void AddNewTranslation(string id, string transText)
		{
			for (int i = 0; i < dic.Count; i++)
			{
				dic[i].AddNewTranslation(id, transText);
			}
		}

		public void DeleteTranslationID(string id)
		{
			for (int i = 0; i < dic.Count; i++)
			{
				dic[i].DeleteTranslationByID(id);
			}
		}

		private void readCSVLanguangeData(CSV csvObject)
		{
			foreach (var data in csvObject.Data)
			{
				DoDLanguage language = new DoDLanguage();
				for (int i = 1; i < data.Count; i++)
				{
					language.AddNewTranslation(data[0], data[i]);
				}
				dic.Add(language);
			}
		}

		public CSV SaveToCSV()
		{
			CSV newCSV = new CSV();
			List<string> temp = new List<string>();
			var keys = dic[0].GetTranslationIDList();

			foreach(string key in keys)
			{
				temp.Add(key);

				foreach (var lang in dic)
				{
					temp.Add(lang.GetTranslationByID(key));
				}
			}
			
			newCSV.Data.Add(temp);
			return newCSV;
		}
	}
}
