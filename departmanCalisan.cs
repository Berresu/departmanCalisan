using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public class Departman
        {
            public string Ad { get; set; }
            public List<Calisan> Calisanlar { get; set; } = new List<Calisan>();

            public Departman(string ad)
            {
                Ad = ad;
            }

            public void CalisanEkle(Calisan calisan)
            {
                Calisanlar.Add(calisan);
            }

            public void DepartmandakiCalisanlariGoster()
            {
                Console.WriteLine($"{Ad} Departmanındaki Çalışanlar:");
                foreach (var calisan in Calisanlar)
                {
                    Console.WriteLine($"- {calisan.Ad}");
                }
            }
        }
        public class Calisan
        {
        public string Ad { get; set; }
        public Departman Departman { get; set; }

        public Calisan(string ad)
        {
            Ad = ad;
        }

        public void DepartmanAta(Departman departman)
        {
            Departman = departman;
        }

        public void CalisanBilgileriniGoster()
        {
            Console.WriteLine($"Çalışan Adı: {Ad}");
            if (Departman != null)
            {
                Console.WriteLine($"Departmanı: {Departman.Ad}");
            }
            else
            {
                Console.WriteLine("Departman Bilgisi Bulunmamaktadır.");
            }
        }
    }

        public class AggergationOrnek
        {
            static void Main(string[] args)
            {
                Departman yazilimDepartmani = new Departman("Yazılım");
                Calisan berre = new Calisan("Berre");
                Calisan alper = new Calisan("Alper");

                yazilimDepartmani.CalisanEkle(berre);
                yazilimDepartmani.CalisanEkle(alper);
                berre.DepartmanAta(yazilimDepartmani);
                alper.DepartmanAta(yazilimDepartmani);

                yazilimDepartmani.DepartmandakiCalisanlariGoster();
                berre.CalisanBilgileriniGoster();
                alper.CalisanBilgileriniGoster();
            }
        }
    }
}
