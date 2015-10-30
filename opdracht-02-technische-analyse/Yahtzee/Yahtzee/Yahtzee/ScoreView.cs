using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class ScoreView : UserControl
    {
        private ScoreController controller;

        public ScoreView(ScoreController c)
        {
            controller = c;
            InitializeComponent();
        }

        private void ScoreboardView_Load(object sender, EventArgs e)
        {
            maxWorpenLabel.Text = controller.MaximumAantalWorpen.ToString();

            aantalWorpenValueLabel.Text = controller.HuidigAantalWorpen.ToString();
        }

        public void updateView()
        {
            aantalWorpenValueLabel.Text = controller.HuidigAantalWorpen.ToString();
        }

        private void maxWorpenLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
