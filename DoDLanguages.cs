using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoDTranslationTool
{
	public class DoDLanguages
	{
		private Dictionary<string, List<string>> dic;
		public DoDLanguages(CSV languageCSVObject)
		{
			dic = new Dictionary<string, List<string>>();
			Process(languageCSVObject);
		}

		public string GetLocalizedLanguage(string strID, int langIndex)
		{
			if (dic.ContainsKey(strID) && dic[strID].Count > langIndex)
			{
				return dic[strID][langIndex];
			}
			else
			{
				return null;
			}
		}

		public void SetLocalizedLanguageStr(string strID, int langIndex, string localizedStr)
		{
			if (dic.ContainsKey(strID) && dic[strID].Count > langIndex)
			{
				dic[strID][langIndex] = localizedStr;
			}
		}

		public List<string> GetAllStrID()
		{
			return dic.Keys.ToList();
		}

		public int GetLanguageNumber()
		{
			var values = dic.Values.ToList();
			if (values.Count > 0)
			{
				return values[0].Count;
			}
			else
			{
				return 0;
			}
		}

		private void Process(CSV csvObject)
		{
			foreach (var data in csvObject.Data)
			{
				if (dic.ContainsKey(data[0]))
					continue;

				List<string> exculdeData = new List<string>();
				for (int i = 0; i < data.Count; i++)
				{
					if (i != 0)
					{
						exculdeData.Add(data[i]);
					}
				}
				dic.Add(data[0], exculdeData);
			}
		}

		public CSV ToCSV()
		{
			CSV newCSV = new CSV();

			foreach (var kpl in dic)
			{
				List<string> temp = new List<string>();
				temp.Add(kpl.Key);
				foreach (var data in kpl.Value)
				{
					temp.Add(data);
				}
				newCSV.Data.Add(temp);
			}

			return newCSV;
		}
	}
}
