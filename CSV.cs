using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DoDTranslationTool
{
	public class CSV
	{
		private int colNum;
		private int rowNum;
		private List<List<string>> data;
		private string filePath;

		public List<List<string>> Data
		{
			get { return data; }
		}

		public int ColNum
		{
			get { return colNum; }
		}

		public int RowNum
		{
			get { return rowNum; }
		}

		public CSV()
		{
			data = new List<List<string>>();
		}

		public CSV(string filePath)
		{
			data = new List<List<string>>();
			this.filePath = filePath;
			rowNum = -1;
			colNum = -1;
			Read();
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
					if (colNum == -1)
					{
						colNum = tokens.Length;
					}
					List<string> temp = new List<string>();
					foreach (var token in tokens)
					{
						if (!string.IsNullOrEmpty(token))
						{
                            int length = token.Trim().Length - 2;
                            if (length > 0)
                            {
                                string afterExtractedStr = token.Trim().Substring(1, length);
                                temp.Add(afterExtractedStr);
                            }
                            else
                            {
                                temp.Add(string.Empty);
                            }
						}
						else
						{
							temp.Add(string.Empty);
						}
					}
					data.Add(temp);
				}
				rowNum = data.Count;
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
						if (string.IsNullOrEmpty(d))
						{
							if (i != temp.Count - 1)
							{
								line += ",";
							}
							else
							{
								line += string.Empty;
							}
						}
						else
						{
							if (i != temp.Count - 1)
							{
								line += "\"" + d + "\"" + ",";
							}
							else
							{
								line += "\"" + d + "\"";
							}
						}
					}
					writer.WriteLine(line);
				}
			}
		}
	}
}
