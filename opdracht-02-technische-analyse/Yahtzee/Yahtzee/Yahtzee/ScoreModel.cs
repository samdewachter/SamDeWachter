using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{

    class ScoreModel
    {

        private int huidigAantalWorpen = 0;
        private int maxAantalWorpen = 0;
        private int score = 0;

        public int MaxAantalWorpen
        {
            get
            {
                return maxAantalWorpen;
            }
            set
            {
                maxAantalWorpen = value;
            }
        }

        public int HuidigAantalWorpen
        {
            get
            {
                return huidigAantalWorpen;
            }
            set
            {
                huidigAantalWorpen = value;
            }
        }


    }
}
