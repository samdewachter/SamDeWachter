using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class TeerlingController
    {
        private TeerlingModel teerlingModel;
        private TeerlingView teerlingView;

        public TeerlingController()
        {
            teerlingModel = new TeerlingModel();

            teerlingView = new TeerlingView(this);
        }

        public TeerlingView getView()
        {
            return teerlingView;
        }

        public void Werp()
        {
            if (!teerlingModel.Vast)
            {
                teerlingModel.Werp();

                teerlingView.updateUI();
            }
        }

        public void toggleVast()
        {
            teerlingModel.toggleVast();

            teerlingView.updateUI();
        }

        public bool Vast
        {
            get
            {
                return teerlingModel.Vast;
            }
        }

        public int AantalOgen
        {
            get
            {
                return teerlingModel.AantalOgen;
            }
        }
    }
}
