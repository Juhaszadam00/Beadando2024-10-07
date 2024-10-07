using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JA_Beadando
{
    public class MarsCsoki : UrbazisElem
    {
        public MarsCsoki(int x, int y) : base(x, y) { }

        public override string ToString() => "C"; // "C" jelöli a marscsokit
    }

}
