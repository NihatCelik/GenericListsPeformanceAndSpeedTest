using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            int elemanSayisi = Convert.ToInt32(args[0]);
            Random rnd = new Random();
            List<int> list = new List<int>(); 
            for (int i = 0; i < elemanSayisi; i++)
            {
                int tutulan = rnd.Next(elemanSayisi); 
                list.Add(tutulan);
            }
        }
    }
}
