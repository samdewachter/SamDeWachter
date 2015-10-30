using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mexico
{
    public partial class GameView : Form
    {
        private GameController gameController;

        public GameView(GameController c)
        {
            gameController = c;

            InitializeComponent();
        }

        private void GameView_Load(object sender, EventArgs e)
        {
            ScoreboardView scoreboard = gameController.getViewScoreboard();
            MexicoView mexico = gameController.getViewMexico();

            mexico.Location = new Point(0, scoreboard.Height);

            Controls.Add(scoreboard);
            Controls.Add(mexico);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            gameController.Reset();
        }
    }
}
