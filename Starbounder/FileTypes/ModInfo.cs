using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Starbounder.FileTypes
{
	class ModInfo
	{
		public string name { get; set; } = "Untitled";
		public string version { get; set; } = "Starbound Version";
		public string path { get; set; } = ".";
		public List<object> dependencies { get; set; } = new List<object>();
		public Metadata metadata { get; set; } = new Metadata();

		public class Metadata
		{
			public string author { get; set; } = "HeiTX";
			public string version { get; set; } = "1.0.0";
			public string description { get; set; } = "Created by";
		}

		// Constructors

		// Create

		public static void Create(string path, ModInfo mi)
		{
			string fileName = Path.GetFileName(path);

			mi.name = fileName;

			string json = JsonConvert.SerializeObject( mi, Formatting.Indented );

			TextWriter tw = new StreamWriter(path + $@"\{fileName}.modinfo", true);
			tw.Write( json );
			tw.Dispose();
		}

		// Load

		public static ModInfo Load(string path)
		{
			string stringJSON = File.ReadAllText(path);
			return JsonConvert.DeserializeObject<ModInfo>( stringJSON );
		}

	}
}
