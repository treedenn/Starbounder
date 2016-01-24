using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace Starbounder.Functions
{
    class Steam
    {

		/// <summary>
		/// Gets the steam path, if steam is installed & has registry.
		/// </summary>
        public static string GetSteamFolder()
        {
            RegistryKey rk = Registry.CurrentUser;

            rk = rk.OpenSubKey(@"Software\Valve\Steam");
			var data = rk.GetValue("SteamPath");

            return data.ToString().Replace(@"/", @"\");
        }

		/// <summary>
		/// This reads the steam config and looks for new steam locations/paths.
		/// </summary>
		public static string[] GetSteamLocations()
		{
			List<string> configs = new List<string>();

			using (StreamReader sr = new StreamReader(GetSteamFolder() + @"\config\config.vdf"))
			{
				string line;

				while ( (line = sr.ReadLine()) != null )
				{
					if (line.Contains( "BaseInstallFolder" ) )
					{
						string[] words = line.Split('"');

						configs.Add( words[3].Replace(@"\\", @"\") );
					}
				}
			}

			return configs.ToArray();
		}

		/// <summary>
		/// Searches for starbound folder from a steam location (not steamapps).
		/// </summary>
		public static string GetStarboundFolder(string pathSteam)
		{
			string starboundPath = pathSteam + @"\steamapps\common\starbound";

			return ( Directory.Exists( starboundPath ) ) ? starboundPath : "";
		}

    }
}
