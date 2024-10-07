using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JA_Beadando
{
    public class Urbazis
    {
        private UrbazisElem[,] palya;
        private Random rand;

        public Urbazis()
        {
            palya = new UrbazisElem[22, 22]; // A pálya mérete
            rand = new Random();
        }

        public void GeneralPalyat()
        {
            // Pálya elemek véletlenszerű generálása
            ElemetHozzaad(new Urhajos(rand.Next(0, 22), rand.Next(0, 22))); // 1 űrhajós

            for (int i = 0; i < 4; i++)
                ElemetHozzaad(new Robot(rand.Next(0, 22), rand.Next(0, 22))); // 4 robot

            for (int i = 0; i < 3; i++)
                ElemetHozzaad(new UzemanyagKanna(rand.Next(0, 22), rand.Next(0, 22))); // 3 üzemanyag-kanna

            for (int i = 0; i < 4; i++)
                ElemetHozzaad(new MarsCsoki(rand.Next(0, 22), rand.Next(0, 22))); // 4 mars csoki

            ElemetHozzaad(new Kapu(rand.Next(0, 22), rand.Next(0, 22))); // 1 kapu
            ElemetHozzaad(new SzuperAlien(rand.Next(0, 22), rand.Next(0, 22))); // 1 szuper alien
        }

        public void ElemetHozzaad(UrbazisElem elem)
        {
            palya[elem.X, elem.Y] = elem;
        }

        public void Kirajzol(Urhajos urhajos)
        {
            Console.Clear();
            // Pálya kirajzolása
            for (int i = 0; i < 22; i++)
            {
                for (int j = 0; j < 22; j++)
                {
                    if (palya[i, j] != null)
                    {
                        Console.Write(palya[i, j].ToString() + " ");
                    }
                    else
                    {
                        Console.Write(". "); // Üres mezők
                    }
                }
                Console.WriteLine();
            }
            // Kiírja az űrhajós HP-ját
            Console.WriteLine($"Űrhajós HP: {urhajos.Eletero}");
        }
    }

}
