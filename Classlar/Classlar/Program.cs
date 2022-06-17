using System;

namespace Valyuta
{                                                      //valyuta haqqin class//
    class Program
    {
        static void Main(string[] args)
        {
            Valyuta birincivalyuta = new Valyuta("Kokoin", "mokoin", "tacikistan", 1000)
            {
            };
            Valyuta ikincivalyuta = new Valyuta("kuza", "muza", "basqirdistan", 5000)
            {
            };
            Valyuta ucuncuvalyuta = new Valyuta("durba", "murba", "hindistan", 3000)
            {
            };
            Valyuta dorduncuvalyuta = new Valyuta("mina", "gina", "pakistan", 2000)
            {
            };

            //ikincivalyuta.Start();
            //Console.WriteLine(ikincivalyuta.kursunVeziyyeti);
            //ikincivalyuta.Start();

            //ikincivalyuta.Stop();
            //Console.WriteLine(ikincivalyuta.kursunVeziyyeti);
            //ucuncuvalyuta.Start();
            //ucuncuvalyuta.Start();
            //ucuncuvalyuta.Stop();
            //Console.WriteLine(ucuncuvalyuta.kursunVeziyyeti);
            //ucuncuvalyuta.Stop();
            Console.WriteLine(birincivalyuta._olke);
        }
    }
    class Valyuta
    {
        public Valyuta(string name, string valyutaindex, string olke, double kurs)
        {
            _name = name;
            _olke = olke;
            _valyutaindex = valyutaindex;
            _kurs = kurs;
        }
        public Valyuta(string name)
        {
            _name = name;
        }
        public Valyuta(string name, string olke)
            : this(name)
        {
            _olke = olke;
        }
        public bool kursunVeziyyeti;
        public string _name;
        public string _valyutaindex;
        public string _olke;
        public double _kurs;
        public void Start()
        {
            if (kursunVeziyyeti == true)
            {
                Console.WriteLine($"{_name} artiq ise dusub");
            }
            else
            {
                kursunVeziyyeti = true;
                Console.WriteLine($"{_name} ise sal");
            }
        }
        public void Stop()
        {
            if (kursunVeziyyeti == false)
            {
                Console.WriteLine($"{_name} artiq dayanib");
            }
            else
            {
                kursunVeziyyeti = false;
                Console.WriteLine($"{_name} saxla");
            }
            
        }
    }
}
