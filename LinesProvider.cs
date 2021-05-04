using System;
using System.Collections.Generic;
using System.IO;

namespace NamesMarkov
{
    class LinesProvider
    {
        public LinesProvider()
        {
        }

        public string[] Lines()
        {
            string basePath = AppContext.BaseDirectory;
            string[] split = basePath.Split('\\');
            string path = "";
            for (int i = 0; i < split.Length - 4; i++)
            {
                path += split[i] + '\\';
            }
            
            path += "Dictionary\\Draconic.txt";
            Console.WriteLine(path);
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
