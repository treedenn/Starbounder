using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Starbounder.Functions
{
	class Actions
	{
		public static void CreateFolder(string path)
		{
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
		}

		public static void DeleteFile(string path)
		{

		}

		public static string Rename(string path)
		{

			return "";
		}
	}
}
