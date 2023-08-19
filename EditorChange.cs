using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoDTranslationTool
{
	public enum EditorChangeType
	{
		Add,
		Modify,
		Delete
	}

	public class EditorChangeData
	{
		public string DataObject { get; set; }
		public object DataBeforeChange { get; set; }
		public object DataAfterChange { get; set; }
	}

	public class EditorChange
	{
		public EditorChangeType ChangeType { get; set; }
		public List<EditorChangeData> ChangeDataList { get; set; }

		public EditorChange() 
		{
			ChangeDataList = new List<EditorChangeData>();
		}
	}
}
