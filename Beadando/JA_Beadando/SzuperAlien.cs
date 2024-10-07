using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JA_Beadando
{
    public class SzuperAlien : UrbazisElem
    {
        public int Eletero { get; private set; }

        public SzuperAlien(int x, int y) : base(x, y)
        {
            Eletero = 100;
        }

        public override string ToString() => "A"; // "A" jelöli a szuper alien-t
    }

}
