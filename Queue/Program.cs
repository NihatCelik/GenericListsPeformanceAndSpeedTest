using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            int elemanSayisi = Convert.ToInt32(args[0]);
            Random rnd = new Random();
            Queue<int> list = new Queue<int>();
            int sum = 0;
            for (int i = 0; i < elemanSayisi; i++)
            {
                int tutulan = rnd.Next(elemanSayisi); 
                list.Enqueue(tutulan);
            }
        }
    }
}