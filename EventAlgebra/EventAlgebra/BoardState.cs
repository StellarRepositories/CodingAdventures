using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAlgebra
{
    public class BoardState
    {
        public int DarkScale;
        public int LightScale;

        public int turnCount = 1; // Beginnt bei 1; Spieler 1 fängt an

        public int PlayerOneAP;
        public int PlayerOneMaxAP;

        public int PlayerTwoAP;
        public int PlayerTwoMaxAP;

        public int Stake;


        public int calculateStake()
        {
            return 0;
        }
    }
}
