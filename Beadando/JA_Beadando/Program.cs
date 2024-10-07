using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace JA_Beadando
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Urbazis urbazis = new Urbazis();
            urbazis.GeneralPalyat();

            Urhajos urhajos = new Urhajos(10, 10); // Az űrhajós kezdeti pozíciója
            urbazis.ElemetHozzaad(urhajos);

            while (true)
            {
                urbazis.Kirajzol(urhajos);
                Thread.Sleep(1000); // 1 másodperces késleltetés

            }
        }
    }

}
