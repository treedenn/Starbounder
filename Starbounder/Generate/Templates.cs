using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Starbounder.Generate
{
	class Templates
	{
		FormMain fm;
		ToolStripMenuItem menuitem;
		EventHandler eventhandler;

		static string appPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
		string tempPath = appPath + "\\" + "templates";

		public Templates(FormMain fm, ToolStripMenuItem menuitem, EventHandler eventhandler)
		{
			this.fm = fm;
			this.menuitem = menuitem;
			this.eventhandler = eventhandler;
		}

		public void Refresh()
		{
			if (Directory.Exists(tempPath))
			{
				menuitem.DropDownItems.AddRange(Populate(tempPath));
			}
		}

		public ToolStripMenuItem[] Populate(string startPath)
		{
			List<ToolStripMenuItem> tItems = new List<ToolStripMenuItem>();

			tItems.AddRange(RecursiveFolder(startPath));
			tItems.AddRange(RecursiveFiles(startPath));

			return tItems.ToArray();
		}

		public ToolStripMenuItem[] RecursiveFolder(string path)
		{
			List<ToolStripMenuItem> items = new List<ToolStripMenuItem>();

			foreach (var folder in Directory.GetDirectories(path))
			{
				string folderName = Path.GetFileName(folder);

				ToolStripMenuItem item = new ToolStripMenuItem(folderName) { Tag = folder };

				item.DropDownItems.AddRange(RecursiveFolder(folder));
				item.DropDownItems.AddRange(RecursiveFiles(folder));

				if (item.HasDropDownItems) { items.Add(item); }

			}

			return items.ToArray();
		}

		
		public ToolStripMenuItem[] RecursiveFiles(string path)
		{
			List<ToolStripMenuItem> items = new List<ToolStripMenuItem>();

			foreach (var file in Directory.GetFiles(path))
			{
				string fileName = Path.GetFileNameWithoutExtension(file);
				string fileExt = " (" + Path.GetExtension(file) + ")";

				ToolStripMenuItem item = new ToolStripMenuItem(fileName + fileExt) { Tag = file };
				item.Click += new EventHandler(eventhandler);

				items.Add(item);
			}

			return items.ToArray();
		}

	}
}
