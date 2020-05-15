using System;
using System.IO;
using System.Text;

namespace ClashofClans.Files
{
    public class Levels
    {
        public static string StartingHome;
        public static string MaxHome;

        public Levels()
        {
            if (Directory.Exists("GameAssets/level"))
            {
                if (File.Exists("GameAssets/starting_home.json"))
                {
                    StartingHome = File.ReadAllText("GameAssets/starting_home.json", Encoding.UTF8);
                    MaxHome = File.ReadAllText("GameAssets/level/townhall8.json", Encoding.UTF8);
                }
                else
                {
                    Console.WriteLine("Failed to load starting home.");
                    Program.Exit();
                }
            }
            else
            {
                Console.WriteLine("GameAssets folder doesn't exist.");
                Program.Exit();
            }
        }
    }
}