using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Starbounder.Templates
{
	class Template
	{
		public static string itemItem = @".\templates\item\itemitem\";

		public static void AddTemplates()
		{

		}

		public static string[] GetTemplates(string path)
		{
			string[] templates = Directory.GetFiles(path);

			return templates;
		}
	}
}
