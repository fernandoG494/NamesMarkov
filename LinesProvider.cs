using System;
using System.Collections.Generic;
using System.IO;

namespace NamesMarkov
{
    class LinesProvider
    {
        char separator;
        public LinesProvider()
        {
            OperatingSystem os = System.Environment.OSVersion;
            string plataform = os.Platform.ToString();
            if (plataform == "Unix")
            {
                separator = '/';
            }
            else
            {
                separator = '\\';
            }
        }

        public string[] Lines(string names)
        {
            string basePath = AppContext.BaseDirectory;
            //Console.WriteLine("Base path: " + basePath);
            string[] split = basePath.Split(separator);
            string path = "";
            for (int i = 0; i < split.Length - 4; i++)
            {
                path += split[i] + separator;
            }
            
            path += "Dictionary" + separator + names + ".txt";
            //Console.WriteLine(path);
            string[] empty = { };
            if (File.Exists(path))
            {
                return File.ReadAllLines(path);
            }
            else
            {
                Console.WriteLine("No existing file");
                return empty;
            }
        }

        public List<String> Convert(string[] arr)
        {
            List<string> list = new List<string>(arr);
            return list;
        }
    }
}
