using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using Newtonsoft.Json;

namespace Starbounder.Generate
{
	class FileTypes
	{
		/// <summary>
		/// Creates an object in json, located in path with file extension.
		/// </summary>
		public static void CreateJson(string path, object obj, string FileExtension)
		{
			string folderPath = (Path.HasExtension(path)) ? Path.GetDirectoryName(path) : Path.GetFullPath(path);
			string fileName = Path.GetFileNameWithoutExtension(path);

			Json.JsonWriter.GenerateJson(folderPath, fileName, FileExtension, obj);
		}

		/// <summary>
		/// Creates an object in json, located in path with file extension and a jsonsetting.
		/// </summary>
		public static void CreateJson(string path, object obj, string FileExtension, JsonSerializerSettings jsonSetting)
		{
			string folderPath = (Path.HasExtension(path)) ? Path.GetDirectoryName(path) : Path.GetFullPath(path);
			string fileName = Path.GetFileNameWithoutExtension(path);

			Json.JsonWriter.GenerateJson(folderPath, fileName, FileExtension, obj, jsonSetting);
		}

		/// <summary>
		/// Creates a .frames, located at the path.
		/// </summary>
		public static void CreateFrames(string path)
		{
			Others.Frames frame = new Others.Frames().setDefault();

			string folderPath = (Path.HasExtension(path)) ? Path.GetDirectoryName(path) : Path.GetFullPath(path);
			string fileName = Path.GetFileNameWithoutExtension(path);

			Json.JsonWriter.GenerateJson(folderPath, fileName, ".frames", frame);

		}

		/// <summary>
		/// Creates a PNG depending on the path. The name parameter is optional.
		/// </summary>
		public static void CreatePNG(string path, int width, int height)
		{
			string folderPath = (Path.HasExtension(path)) ? Path.GetDirectoryName(path) : Path.GetFullPath(path);
			string fileName = Path.GetFileNameWithoutExtension(path);

			using (Bitmap bm = new Bitmap(width, height))
			{
				bm.Save(folderPath + "\\" + fileName + ".png", System.Drawing.Imaging.ImageFormat.Png);
			}
		}

		/// <summary>
		/// Creates a PNG depending on the path with a name parameter.
		/// </summary>
		public static void CreatePNG(string path, int width, int height, string name)
		{
			string folderPath = (Path.HasExtension(path)) ? Path.GetDirectoryName(path) : Path.GetFullPath(path);
			string fileName = Path.GetFileNameWithoutExtension(path + name);

			using (Bitmap bm = new Bitmap(width, height))
			{
				bm.Save(folderPath + "\\" + fileName + ".png", System.Drawing.Imaging.ImageFormat.Png);
			}
		}
	}
}
