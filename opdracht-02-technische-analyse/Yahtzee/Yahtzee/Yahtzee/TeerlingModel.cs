using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class TeerlingModel
    {
        private bool isVast;
        private int aantalOgen;
        private static Random randomNummer;

        public TeerlingModel()
        {
            isVast = false;

            aantalOgen = 1;

            if (randomNummer == null)
            {
                randomNummer = new Random();
            }
        }

        public void Werp()
        {
            aantalOgen = randomNummer.Next(1, 7);
        }

        public int AantalOgen
        {
            get
            {
                return aantalOgen;
            }
        }

        public void toggleVast()
        {
            isVast = !isVast;
        }

        public bool Vast
        {
            get
            {
                return isVast;
            }
        }
    }
}
