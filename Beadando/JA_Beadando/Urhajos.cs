using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JA_Beadando
{
    public class Urhajos : UrbazisElem
    {
        public int Eletero { get; private set; }
        public int UzemanyagKannaSzam { get; private set; }

        public Urhajos(int x, int y) : base(x, y)
        {
            Eletero = 100;
            UzemanyagKannaSzam = 0;
        }

        public override string ToString() => "U"; // "U" jelöli az űrhajóst

        public void Sebzodik(int sebzes)
        {
            Eletero -= sebzes;
            if (Eletero < 0) Eletero = 0; // Az életerő nem csökkenhet 0 alá
        }

        public void UzemanyagotGyujt() => UzemanyagKannaSzam++;

        public bool Kijuthat() => UzemanyagKannaSzam >= 3; // Kijuthat, ha 3 kanna üzemanyaga van
    }

}
