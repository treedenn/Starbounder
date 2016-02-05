using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Starbounder.Json
{
	class JsonWriter
	{
		public static void GenerateJson(string filePath, string fileName, string fileExtension, Object obj)
		{
			int fileNumber = 0;
			string path = filePath + "\\" + fileName + fileExtension;

			while (File.Exists(path))
			{
				path = filePath + "\\" + fileName + fileNumber.ToString() + fileExtension;
				fileNumber++;
			}

			File.WriteAllText(path, JsonConvert.SerializeObject(obj, Formatting.Indented));
		}

		public static void GenerateJson(string filePath, string fileName, string fileExtension, Object obj, JsonSerializerSettings jsonSetting)
		{
			int fileNumber = 0;
			string path = filePath + "\\" + fileName + fileExtension;

			while (File.Exists(path))
			{
				path = filePath + "\\" + fileName + fileNumber.ToString() + fileExtension;
				fileNumber++;
			}

			File.WriteAllText(path, JsonConvert.SerializeObject(obj, Formatting.Indented, jsonSetting));
		}
	}
}
