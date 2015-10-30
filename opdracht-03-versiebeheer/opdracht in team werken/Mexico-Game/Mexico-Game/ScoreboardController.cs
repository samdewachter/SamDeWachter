using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mexico
{
    public class ScoreboardController
    {
        private GameController container;

        private ScoreboardView view;
        private ScoreboardModel model;

        public ScoreboardController(GameController cont)
        {
            container = cont;

            view = new ScoreboardView(this);
            model = new ScoreboardModel();
        }

        public ScoreboardView getView()
        {
            return view;
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
            view.updateView();
        }

        public void Reset()
        {
            updateHuidigAantalWorpen(0);
            updateView();
        }
    }
}
