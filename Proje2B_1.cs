using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace proje2B
{
    class Teknoloji
    {
        public string teknolojiAdi;
        public int uretkenligeKalanSene;
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] teknolojiAdi = { "Internet of Things", "Big Data", "Autonomous Vehicles", "Data Science", "NLP", "Data Security", "Speech Recognition", "Machine Learning", "Quantum Computing", "Augmented Reality" };
            int[] uretkenligeKalanSene = { 5, 0, 5, 2, 5, 5, 0, 2, 10, 5 };
            int counter = 0, index=0;
            List<Teknoloji> genericListe;
            ArrayList Arrayliste = new ArrayList();
            
            while (counter < teknolojiAdi.Length)
            {
                genericListe = new List<Teknoloji>();
                    for (int i=1;i<3-(index%2);index++)
                    {
                    int a = 3 - (index % 2);
                    Teknoloji eleman = new Teknoloji();
                    eleman.teknolojiAdi = teknolojiAdi[counter];
                    eleman.uretkenligeKalanSene = uretkenligeKalanSene[counter];
                    genericListe.Add(eleman);
                    counter++;
                    if (counter == teknolojiAdi.Length)
                        break;
                    }
                Arrayliste.Add(genericListe);
                index++;
            }

            List<Teknoloji> Unboxlistele = new List<Teknoloji>();

            for (int i = 0; i < Arrayliste.Count; i++)
            {
                Unboxlistele = (List<Teknoloji>)Arrayliste[i];
                for (int ix = 0; ix < Unboxlistele.Count; ix++)
                    Console.WriteLine(Unboxlistele[ix].teknolojiAdi + "  " + Unboxlistele[ix].uretkenligeKalanSene);
            }

        }
    }
}
