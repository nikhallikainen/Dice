using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noppa
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("Tehnyt: Elia Hallikainen 2021");
            Console.WriteLine();
            Console.WriteLine("*******************************");
            Console.WriteLine();
            int henkCount = CountLinesInFile("henkilot.txt");
            int paikkaCount = CountLinesInFile("paikka.txt");

            var generator = new RandomGenerator();

            int henkVal = generator.RandomNumber(1, henkCount);

            int paikkaVal = generator.RandomNumber(1, paikkaCount);

            string henkilo = File.ReadLines("henkilot.txt").ElementAt(henkVal - 1);
            Console.WriteLine("Noppaa heitetty: {0}", henkVal);
            Console.WriteLine("Tapahtuman henkilö: {0}", henkilo);
            Console.WriteLine();
            string paikka = File.ReadLines("paikka.txt").ElementAt(paikkaVal - 1);
            Console.WriteLine("Noppaa heitetty: {0}", paikkaVal);
            Console.WriteLine("Paikka: {0}", paikka);
            Console.ReadLine();

        }

        static int CountLinesInFile(string f)
        {
            int count = 0;
            using (StreamReader r = new StreamReader(f))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    count++;
                }
            }
            return count;
        }
    }

    public class RandomGenerator
    {
 
        private readonly Random _random = new Random();
    
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
        
    }

}
