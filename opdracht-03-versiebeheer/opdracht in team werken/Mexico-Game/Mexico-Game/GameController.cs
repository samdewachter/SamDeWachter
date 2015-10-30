using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mexico
{
    public class GameController
    {

        private GameView view;

        private MexicoController mexicoController;
        private ScoreboardController scoreboardController;

        public GameController()
        {
            view = new GameView(this);

            mexicoController = new MexicoController(this);
            mexicoController.MaximumAantalWorpen = 3;
            mexicoController.AantalTeerlingen = 2;
            mexicoController.initialize();

            scoreboardController = new ScoreboardController(this);
            scoreboardController.MaximumAantalWorpen = 3;
        }

        public void modelHasChanged()
        {
            //scoreboardController.updateView();
            scoreboardController.updateHuidigAantalWorpen(mexicoController.HuidigAantalWorpen);
        }

        public GameView getView()
        {
            return view;
        }

        public MexicoView getViewMexico()
        {
            return mexicoController.getView();
        }

        public ScoreboardView getViewScoreboard()
        {
            return scoreboardController.getView();
        }

        public int MaximumAantalWorpen
        {
            get
            {
                return mexicoController.MaximumAantalWorpen;
            }
        }


        public int HuidigAantalWorpen
        {
            get
            {
                return mexicoController.HuidigAantalWorpen;
            }
        }

        public void Reset()
        {
            mexicoController.Reset();
            scoreboardController.Reset();

        }
    }
}
