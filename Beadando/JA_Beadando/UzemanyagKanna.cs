using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JA_Beadando
{
    public class UzemanyagKanna : UrbazisElem
    {
        public UzemanyagKanna(int x, int y) : base(x, y) { }

        public override string ToString() => "U"; // "U" jelöli az üzemanyag kannát
    }

}
