using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoDTranslationTool
{
	public class DoDLanguage
	{
		private Dictionary<string, string> localizedTexts;

		public DoDLanguage()
		{
			localizedTexts = new Dictionary<string, string>();
		}

		public List<string> GetTranslationIDList()
		{
			return localizedTexts.Keys.ToList();
		}

		public void AddNewTranslation(string id, string text)
		{
			localizedTexts[id] = text;
		}

		public string GetTranslationByID(string id)
		{
			if (localizedTexts.ContainsKey(id)) 
				return localizedTexts[id];

			return null;
		}

		public void DeleteTranslationByID(string id)
		{
			if (localizedTexts.ContainsKey(id))
				localizedTexts.Remove(id);
		}

		public void ModifyTranslation(string id, string newText)
		{
			if (localizedTexts.ContainsKey(id))
				localizedTexts[id] = newText;
		}
	}
}
