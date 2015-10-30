using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mexico
{
    public class MexicoController
    {
        private GameController container;

        private MexicoView view;
        private MexicoModel model;

        public MexicoController(GameController cont)
        {
            container = cont;
            view = new MexicoView(this);
            model = new MexicoModel();
        }

        public void initialize()
        {
            maakTeerlingen();
        }

        private void maakTeerlingen()
        {
            for (int teerlingNummer = 0; teerlingNummer < AantalTeerlingen; ++teerlingNummer)
            {
                TeerlingController teerling = new TeerlingController();

                model.addTeerling(teerling);
            }
        }

        public List<TeerlingView> getTeerlingenView()
        {
            List<TeerlingView> teerlingenView = new List<TeerlingView>();

            foreach (TeerlingController teerling in model.Teerlingen)
            {
                TeerlingView teerlingView = teerling.getView();

                teerlingenView.Add(teerlingView);
            }

            return teerlingenView;
        }

        public MexicoView getView()
        {
            return view;
        }

        public void smijtAlleTeerlingen()
        {
            if (model.aantalWorpen < MaximumAantalWorpen)
            {
                List<TeerlingController> teerlingen = model.Teerlingen;

                foreach (TeerlingController teerling in teerlingen)
                {
                    teerling.Werp();
                }

                model.voegWorpToe();

                container.modelHasChanged();
            }


        }

        public void Reset()
        {
            model.ResetHuidigAantalWorpen();
            //container.Reset();
        }

        public int MaximumAantalWorpen
        {
            get
            {
                return model.MaximumAantalWorpen;
            }
            set
            {
                model.MaximumAantalWorpen = value;
            }

        }

        public int HuidigAantalWorpen
        {
            get
            {
                return model.aantalWorpen;
            }
        }

        public int AantalTeerlingen
        {
            get
            {
                return model.AantalTeerlingen;
            }
            set
            {
                model.AantalTeerlingen = value;
            }
        }
    }
}
