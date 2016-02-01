using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Starbounder.FileTypes
{
	class FileTypes
	{
		public static string[] supportedTextExtensions = new string[]
		{
			".sword", ".staff", ".gun", ".thrown",
			".beamaxe", ".harvestingtool", ".miningtool",
			".head", ".chest", ".legs", ".back",
			".item", ".matitem", ".liqitem",
			".consumable",
			".modinfo", ".frames"
		};

		public static string[] supportedImageExtensions = new string[]
		{
			".png"
		};

		public static void CreateJson(string path, object obj, string FileExtension)
		{
			string folderPath = (Path.HasExtension(path)) ? Path.GetDirectoryName(path) : Path.GetFullPath(path);
			string fileName = Path.GetFileNameWithoutExtension(path);

			Json.JsonWriter.GenerateJson(folderPath, fileName, FileExtension, obj);
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
