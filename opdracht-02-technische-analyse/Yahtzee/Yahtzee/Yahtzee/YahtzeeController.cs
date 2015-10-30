using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class YahtzeeController
    {
        private GameController container;

        private YahtzeeView yahtzeeView;
        private YahtzeeModel yahtzeeModel;

        public YahtzeeController(GameController gameController)
        {
            container = gameController;
            yahtzeeView = new YahtzeeView(this);
            yahtzeeModel = new YahtzeeModel();
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

                yahtzeeModel.addTeerling(teerling);
            }
        }

        public List<TeerlingView> getTeerlingenView()
        {
            List<TeerlingView> teerlingenView = new List<TeerlingView>();

            foreach (TeerlingController teerling in yahtzeeModel.Teerlingen)
            {
                TeerlingView teerlingView = teerling.getView();

                teerlingenView.Add(teerlingView);
            }

            return teerlingenView;
        }

        public YahtzeeView getView()
        {
            return yahtzeeView;
        }

        public void smijtAlleTeerlingen()
        {
            if (yahtzeeModel.aantalWorpen < MaximumAantalWorpen)
            {
                List<TeerlingController> teerlingen = yahtzeeModel.Teerlingen;

                foreach (TeerlingController teerling in teerlingen)
                {
                    teerling.Werp();
                }

                yahtzeeModel.voegWorpToe();

                container.modelHasChanged();
            }


        }

        public void Reset()
        {
            yahtzeeModel.ResetHuidigAantalWorpen();
            //container.Reset();
        }

        public int MaximumAantalWorpen
        {
            get
            {
                return yahtzeeModel.MaximumAantalWorpen;
            }
            set
            {
                yahtzeeModel.MaximumAantalWorpen = value;
            }

        }

        public int HuidigAantalWorpen
        {
            get
            {
                return yahtzeeModel.aantalWorpen;
            }
        }

        public int AantalTeerlingen
        {
            get
            {
                return yahtzeeModel.AantalTeerlingen;
            }
            set
            {
                yahtzeeModel.AantalTeerlingen = value;
            }
        }
    }
}
