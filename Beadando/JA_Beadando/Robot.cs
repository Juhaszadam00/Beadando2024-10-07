using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JA_Beadando
{
    public class Robot : UrbazisElem
    {
        public static int RobotokSzama = 4; // Statikus változó a robotok számának nyilvántartására
        public int Eletero { get; private set; }

        public Robot(int x, int y) : base(x, y)
        {
            Eletero = 100;
            RobotokSzama++;
        }

        public override string ToString() => "R"; // "R" jelöli a robotot

        public void Sebzodik(int sebzes)
        {
            Eletero -= sebzes;
            if (Eletero < 0)
            {
                Eletero = 0;
                RobotokSzama--; // Csökkentjük a robotok számát
            }
        }
    }

}
