using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoDTranslationTool
{
	public class EditorChanges
	{
		public List<EditorChange> EditorChangeList { get; set; }

		public EditorChanges() 
		{
			EditorChangeList = new List<EditorChange>();
		}

		public bool FindChange(EditorChangeType changeType, object changeData)
		{
			var foundedChangesByType = EditorChangeList.Where(o => o.ChangeType == changeType).ToList();
			foreach(var foundedChange in foundedChangesByType)
			{
				return foundedChange.ChangeDataList.Where(o => o.Equals(changeData)).Any();
			}

			return false;
		}
	}
}
