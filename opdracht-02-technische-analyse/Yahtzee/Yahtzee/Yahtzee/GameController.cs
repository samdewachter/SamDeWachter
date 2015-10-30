using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class GameController
    {

        private GameView view;

        private YahtzeeController yahtzeeController;
        private ScoreController scoreController;

        public GameController()
        {
            view = new GameView(this);

            yahtzeeController = new YahtzeeController(this);
            yahtzeeController.MaximumAantalWorpen = 3;
            yahtzeeController.AantalTeerlingen = 3;
            yahtzeeController.initialize();

            scoreController = new ScoreController(this);
            scoreController.MaximumAantalWorpen = 3;
        }

        public void modelHasChanged()
        {
            //scoreboardController.updateView();
            scoreController.updateHuidigAantalWorpen(yahtzeeController.HuidigAantalWorpen);
        }

        public GameView getView()
        {
            return view;
        }

        public YahtzeeView getViewYahtzee()
        {
            return yahtzeeController.getView();
        }

        public ScoreView getViewScoreboard()
        {
            return scoreController.getView();
        }

        public int MaximumAantalWorpen
        {
            get
            {
                return yahtzeeController.MaximumAantalWorpen;
            }
        }


        public int HuidigAantalWorpen
        {
            get
            {
                return yahtzeeController.HuidigAantalWorpen;
            }
        }

        public void Reset()
        {
            yahtzeeController.Reset();
            scoreController.Reset();

        }
    }
}
