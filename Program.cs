using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BukkitPluginGen.Properties;

namespace BukkitPluginGen
{
    class Program
    {
        static string PluginName;
        static string PackageName;
        static string JavaVersion;
        static string BukkitVersion;
        static void Main(string[] args)
        {
            PluginName = GetInput("Plugin name: ");
            PackageName = GetInput("Package name: ");
            JavaVersion = GetInput("Java Version (1.8): ");
            JavaVersion = (JavaVersion == "" ? "1.8" : JavaVersion);

            BukkitVersion = GetInput("Bukkit version (1.12.2-R0.1-SNAPSHOT): ");
            BukkitVersion = (BukkitVersion == "" ? "1.12.2-R0.1-SNAPSHOT" : BukkitVersion);

            Directory.CreateDirectory(PluginName);

            WriteResource(Resources.pom, Path.Combine(PluginName, "pom.xml"));
            WriteResource(Resources.project, Path.Combine(PluginName, ".project"));
            WriteResource(Resources.classpath, Path.Combine(PluginName, ".classpath"));

            Directory.CreateDirectory(Path.Combine(PluginName, "src"));
            Directory.CreateDirectory(Path.Combine(PluginName, "src", "main"));
            Directory.CreateDirectory(Path.Combine(PluginName, "src", "main", "resources"));
            WriteResource(Resources.plugin, Path.Combine(PluginName, "src", "main", "resources", "plugin.yml"));
            
            Directory.CreateDirectory(Path.Combine(PluginName, "src", "main", "java"));
            Directory.CreateDirectory(Path.Combine(PluginName, "src", "main", "java", "com"));
            Directory.CreateDirectory(Path.Combine(PluginName, "src", "main", "java", "com", PackageName));
            Directory.CreateDirectory(Path.Combine(PluginName, "src", "main", "java", "com", PackageName, "mod"));
            WriteResource(Resources.MainClass, Path.Combine(PluginName, "src", "main", "java", "com", PackageName, "mod", PluginName + ".java"));

            Directory.CreateDirectory(Path.Combine(PluginName, "src", "main", "java", "com", PackageName, "mod", "Commands"));
            WriteResource(Resources.DebugCommand, Path.Combine(PluginName, "src", "main", "java", "com", PackageName, "mod", "Commands", "DebugCommand.java"));
            WriteResource(Resources.PosCommand, Path.Combine(PluginName, "src", "main", "java", "com", PackageName, "mod", "Commands", "PosCommand.java"));

            Directory.CreateDirectory(Path.Combine(PluginName, "src", "main", "java", "com", PackageName, "mod", "Listeners"));
            WriteResource(Resources.BlockListener, Path.Combine(PluginName, "src", "main", "java", "com", PackageName, "mod", "Listeners", "BlockListener.java"));
            WriteResource(Resources.PlayerListener, Path.Combine(PluginName, "src", "main", "java", "com", PackageName, "mod", "Listeners", "PlayerListener.java"));

            Directory.CreateDirectory(Path.Combine(PluginName, "src", "test"));
            Directory.CreateDirectory(Path.Combine(PluginName, "src", "test", "java"));
            Directory.CreateDirectory(Path.Combine(PluginName, "src", "test", "resources"));
        }

        static string GetInput(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }

        static void WriteResource(string Resource, string FileLoc)
        {
            string[] Lines = Resource.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            for (int x = 0; x < Lines.Length; x++)
            {
                Lines[x] = Lines[x].Replace("{PluginName}", PluginName);
                Lines[x] = Lines[x].Replace("{PackageName}", PackageName);
                Lines[x] = Lines[x].Replace("{JavaVersion}", JavaVersion);
                Lines[x] = Lines[x].Replace("{BukkitVersion}", BukkitVersion);
            }

            File.WriteAllLines(FileLoc, Lines);
        }
    }
}
