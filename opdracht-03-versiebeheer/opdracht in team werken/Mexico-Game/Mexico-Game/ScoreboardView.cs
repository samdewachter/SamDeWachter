using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mexico
{
    public partial class ScoreboardView : UserControl
    {
        private ScoreboardController controller;

        public ScoreboardView(ScoreboardController c)
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
    }
}
