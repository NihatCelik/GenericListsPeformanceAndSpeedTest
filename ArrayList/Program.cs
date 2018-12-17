using System;
using System.Collections;

namespace ArrayListSample
{
    class Program
    {
        static void Main(string[] args)
        {
            int elemanSayisi = Convert.ToInt32(args[0]);
            Random rnd = new Random();
            ArrayList list = new ArrayList(); 
            for (int i = 0; i < elemanSayisi; i++)
            {
                int tutulan = rnd.Next(elemanSayisi); 
                list.Add(tutulan);
            }
        }
    }
}
