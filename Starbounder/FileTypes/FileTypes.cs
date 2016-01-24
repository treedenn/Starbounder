using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Starbounder.FileTypes
{
	class FileTypes
	{
		public static void Create(string path, object obj, string FileExtension)
		{
			string filePath = (Path.HasExtension(path)) ? Path.GetDirectoryName(path) : Path.GetFullPath(path);
			string fileName = Path.GetFileNameWithoutExtension(path);

			Json.JsonWriter.GenerateJson(filePath, fileName, FileExtension, obj);
		}
	}
}
