using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using Newtonsoft.Json;

namespace Starbounder.FileTypes
{
	class FileTypes
	{
		// Create

		public static void CreateJson(string path, object obj, string FileExtension)
		{
			string folderPath = (Path.HasExtension(path)) ? Path.GetDirectoryName(path) : Path.GetFullPath(path);
			string fileName = Path.GetFileNameWithoutExtension(path);

			Json.JsonWriter.GenerateJson(folderPath, fileName, FileExtension, obj);
		}

		public static void CreateJson(string path, object obj, string FileExtension, JsonSerializerSettings jsonSetting)
		{
			string folderPath = (Path.HasExtension(path)) ? Path.GetDirectoryName(path) : Path.GetFullPath(path);
			string fileName = Path.GetFileNameWithoutExtension(path);

			Json.JsonWriter.GenerateJson(folderPath, fileName, FileExtension, obj, jsonSetting);
		}

		public static void CreateFrames(string path)
		{
			Frames frame = new Frames().setDefault();

			string folderPath = (Path.HasExtension(path)) ? Path.GetDirectoryName(path) : Path.GetFullPath(path);
			string fileName = Path.GetFileNameWithoutExtension(path);

			Json.JsonWriter.GenerateJson(folderPath, fileName, ".frames", frame);

		}

		public static void CreatePNG(string path, int width, int height)
		{
			string folderPath = (Path.HasExtension(path)) ? Path.GetDirectoryName(path) : Path.GetFullPath(path);
			string fileName = Path.GetFileNameWithoutExtension(path);

			using (Bitmap bm = new Bitmap(width, height))
			{
				bm.Save(folderPath + "\\" + fileName + ".png", System.Drawing.Imaging.ImageFormat.Png);
			}
		}
	}
}
