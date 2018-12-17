using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int elemanSayisi = Convert.ToInt32(args[0]);
            Random rnd = new Random();
            int[] list = new int[elemanSayisi];
            for (int i = 0; i < elemanSayisi; i++)
            {
                list[i] = rnd.Next(elemanSayisi);
            }
        }
    }
}