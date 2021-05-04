using System;
using System.Collections.Generic;

namespace NamesMarkov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t AAAAAAAAAAAAAAAAAAAAAAAAAA!");
            LinesProvider provider = new LinesProvider();
            string[] lines = provider.Lines();

            List<String> list = provider.Convert(lines);

            var namegen = new Sobriquet.Generator(3, list);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(namegen.Next());
            }
        }
    }
}
