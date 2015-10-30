using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mexico
{
    class MexicoModel
    {
        private List<TeerlingController> teerlingen = new List<TeerlingController>();

        private int aantalTeerlingen = 0;
        private int huidigAantalWorpen = 0;
        private int maximumAantalWorpen = 0;

        internal void addTeerling(TeerlingController teerling)
        {
            teerlingen.Add(teerling);
        }

        public List<TeerlingController> Teerlingen
        {
            get
            {
                return teerlingen;
            }
        }

        public int aantalWorpen
        {
            get
            {
                return huidigAantalWorpen;
            }
        }

        public int MaximumAantalWorpen
        {
            get
            {
                return maximumAantalWorpen;
            }
            set
            {
                maximumAantalWorpen = value;
            }
        }

        public int AantalTeerlingen
        {
            get
            {
                return aantalTeerlingen;
            }
            set
            {
                aantalTeerlingen = value;
            }
        }

        public int voegWorpToe()
        {
            return ++huidigAantalWorpen;
        }

        internal void ResetHuidigAantalWorpen()
        {
            huidigAantalWorpen = 0;
        }
    }
}
