using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DoDTranslationTool
{
	public class CSV
	{
		private List<List<string>> data;
		private string filePath;

		public CSV()
		{
			data = new List<List<string>>();
		}

		public CSV(string filePath)
		{
			data = new List<List<string>>();
			this.filePath = filePath;
			Read();
		}

		public List<List<string>> Data 
		{
			get { return data; } 
		}

		private void Read(string filePath)
		{
			this.filePath = filePath;
			Read();
		}

		private void Read()
		{
			using (StreamReader reader = new StreamReader(filePath))
			{
				while (reader.Peek() > -1)
				{
					string line = reader.ReadLine();
					string[] tokens = line.Split(',');
					List<string> temp = new List<string>();
					foreach (var token in tokens)
					{
						temp.Add(token.Trim().Substring(1, token.Trim().Length - 2));
					}
					data.Add(temp);
				}
			}
		}

		public void Save(string destFilePath)
		{
			using (StreamWriter writer = new StreamWriter(destFilePath))
			{
				foreach (var temp in data)
				{
					string line = null;
					for (int i = 0; i < temp.Count; i++)
					{
						string d = temp[i];
						if (i != temp.Count - 1)
						{
							line += "\"" + d + "\"" + ",";
						}
						else
						{
							line += "\"" + d + "\"";
						}
					}
					writer.WriteLine(line);
				}
			}
		}
	}
}
