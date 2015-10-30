using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class ScoreController
    {
        private GameController container;

        private ScoreView Scoreview;
        private ScoreModel model;

        public ScoreController(GameController gameController)
        {
            container = gameController;

            Scoreview = new ScoreView(this);
            model = new ScoreModel();
        }

        public ScoreView getView()
        {
            return Scoreview;
        }

        public int MaximumAantalWorpen
        {
            get
            {
                return model.MaxAantalWorpen;
            }
            set
            {
                model.MaxAantalWorpen = value;
            }
        }

        public int HuidigAantalWorpen
        {
            get
            {
                return model.HuidigAantalWorpen;
            }
        }

        internal void updateHuidigAantalWorpen(int huidigAantalWorpen)
        {
            model.HuidigAantalWorpen = huidigAantalWorpen;
            updateView();
        }

        public void updateView()
        {
            Scoreview.updateView();
        }

        public void Reset()
        {
            updateHuidigAantalWorpen(0);
            updateView();
        }
    }
}
