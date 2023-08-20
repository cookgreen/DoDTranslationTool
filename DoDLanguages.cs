using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoDTranslationTool
{
	public class DoDLanguages
	{
		private List<DoDLanguage> languages;

		public int LanguageNum
		{
			get { return languages.Count; }
		}

		public DoDLanguages(CSV languageCSVFile)
		{
			languages = new List<DoDLanguage>();
			readCSVLanguangeData(languageCSVFile);
		}

		public string GetTranslatedLanguage(string id, int langIndex)
		{
			return languages[langIndex].GetTranslationByID(id);
		}

		public void SetTranslationLanguage(string id, int langIndex, string translationText)
		{
			languages[langIndex].ModifyTranslation(id, translationText);
		}

		public List<string> GetAllTranslationID()
		{
			return languages[0].GetTranslationIDList();
		}

		public int GetLanguageNumber()
		{
			return languages.Count;
		}

		public void AddNewTranslation(string id, string transText)
		{
			for (int i = 0; i < languages.Count; i++)
			{
				languages[i].AddNewTranslation(id, transText);
			}
		}

		public void AddTranslationID(string id)
		{
			for (int i = 0; i < languages.Count; i++)
			{
				languages[i].AddNewTranslation(id, string.Empty);
			}
		}

		public void DeleteTranslationID(string id)
		{
			for (int i = 0; i < languages.Count; i++)
			{
				languages[i].DeleteTranslationByID(id);
			}
		}

		public CSV SaveToCSV()
		{
			CSV savedCSV = new CSV();
			List<string> temp = new List<string>();
			var keys = languages[0].GetTranslationIDList();

			foreach(string key in keys)
			{
				temp.Add(key);

				foreach (var lang in languages)
				{
					temp.Add(lang.GetTranslationByID(key));
				}
			}
			
			savedCSV.Data.Add(temp);
			return savedCSV;
		}

		private void readCSVLanguangeData(CSV csvFile)
		{
			foreach (var data in csvFile.Data)
			{
				DoDLanguage language = new DoDLanguage();
				for (int i = 1; i < data.Count; i++)
				{
					language.AddNewTranslation(data[0], data[i]);
				}
				languages.Add(language);
			}
		}
	}
}
