using System;
using System.Collections.Generic;

namespace NamesMarkov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t Names Generator!");
            
            // numero de nombres
            int n = 1;

            // diccionario [Ancient_greek, Arachnid, Biblical, Dark_elven, Draconic, Egiptian, Elven, English, French, German, Giant, Orc, Punic, Serpent]
            string origen = "Giant";

            Starter(origen, n);
            
        }

        static void Starter(string names, int n)
        {
            LinesProvider provider = new LinesProvider();
            string[] lines = provider.Lines(names);

            List<String> list = provider.Convert(lines);

            var namegen = new Sobriquet.Generator(3, list);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(namegen.Next());
            }
        }
    }
}
