using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mexico
{
    public class TeerlingController
    {
        private TeerlingModel model;
        private TeerlingView view;

        public TeerlingController()
        {
            model = new TeerlingModel();

            view = new TeerlingView(this);
        }

        public TeerlingView getView()
        {
            return view;
        }

        public void Werp()
        {
            if (!model.Vast)
            {
                model.Werp();

                view.updateUI();
            }
        }

        public void toggleVast()
        {
            model.toggleVast();

            view.updateUI();
        }

        public bool Vast
        {
            get
            {
                return model.Vast;
            }
        }

        public int AantalOgen
        {
            get
            {
                return model.AantalOgen;
            }
        }
    }
}
