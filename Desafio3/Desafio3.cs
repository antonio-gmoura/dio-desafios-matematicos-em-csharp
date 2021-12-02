using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    internal class Desafio3
    {
        static void Main(string[] args)
        {
            List<String> joias = new List<String>();
            String joia;
            do
            {
                joia = Convert.ToString(Console.ReadLine());
                if (!String.IsNullOrEmpty(joia))
                {
                    if (!joias.Exists(x => x == joia))
                    {
                        joias.Add(joia);
                    };
                }
            } while (!String.IsNullOrEmpty(joia));
            Console.WriteLine(joias.Count);
        }
    }
}
