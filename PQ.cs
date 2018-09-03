using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2B_3
{
    class PQ
    {
        List<int> v;

        public PQ() { v = new List<int>(); }

        public void ekle(int number)
        { v.Add(number); }

        public int sil()
        {
            int min = v.IndexOf(0), minIndex = 0;
            for (int i = 1; i < v.Count(); ++i)
            {
                if (v.IndexOf(i) < min)
                {
                    min = v.IndexOf(i);
                    minIndex = i;
                }
            }
            v.RemoveAt(minIndex); return min;
        }
        public bool bosMu() { return v.Count() == 0; }
        public void yazdir()
        {
            foreach (int i in v)
                Console.Write(i+" ");
        }

        public static void Main(string[] arg)
        {
            Random rnd = new Random();
            PQ pq = new PQ();
            System.Collections.ArrayList Alist = new System.Collections.ArrayList();
            for (int i = 0; i < 10; i++)
                Alist.Add(rnd.Next(100));
            for (int i = 0; i < Alist.Count; i++)
                pq.ekle((int)Alist[i]);

            Console.WriteLine("Ekelenen elemanlar...\n");
            pq.yazdir();

            pq.sil();
            Console.Write("\n\nSil metodundan sonraki liste...\n\n");
            pq.yazdir();

            pq.ekle(99);
            Console.WriteLine("\n\n99 sayısı için Ekle metodundan sonraki liste...\n");
            pq.yazdir();
            Console.WriteLine("\n");
        }
    }
}
