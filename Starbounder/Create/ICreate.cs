using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Starbounder.Create
{
	class ICreate
	{
		public static void Folder(string path)
		{
			if ( !Directory.Exists(path) )
			{
				Directory.CreateDirectory(path);
			}
		}
	}
}
