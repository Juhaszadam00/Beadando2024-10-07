using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JA_Beadando
{
    public abstract class UrbazisElem
    {
        public int X { get; protected set; }
        public int Y { get; protected set; }

        protected UrbazisElem(int x, int y)
        {
            X = x;
            Y = y;
        }

        public abstract string ToString(); // Minden elemnek saját ToString metódusa lesz
    }

}
