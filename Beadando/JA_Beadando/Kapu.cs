using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JA_Beadando
{
    public class Kapu : UrbazisElem
    {
        public Kapu(int x, int y) : base(x, y) { }

        public override string ToString() => "K"; // "K" jelöli a kaput
    }

}
