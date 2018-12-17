using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            int elemanSayisi = Convert.ToInt32(args[0]);
            Random rnd = new Random();
            HashSet<int> list = new HashSet<int>(); 
            for (int i = 0; i < elemanSayisi; i++)
            {
                int tutulan = rnd.Next(elemanSayisi); 
                list.Add(tutulan);
            }
        }
    }
}
