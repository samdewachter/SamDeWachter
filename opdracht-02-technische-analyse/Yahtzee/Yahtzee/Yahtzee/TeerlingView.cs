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
    public partial class TeerlingView : UserControl
    {
        private TeerlingController controller;


        public TeerlingView(TeerlingController teerlingController)
        {
            InitializeComponent();

            controller = teerlingController;
        }

        private void teerling_Click(object sender, EventArgs e)
        {
            controller.toggleVast();
        }

        private void werpButton_Click(object sender, EventArgs e)
        {
            if (!controller.Vast)
            {
                controller.Werp();
            }
        }

        public void updateUI()
        {
            teerlingWaarde.BackColor = (controller.Vast) ? Color.Gray : default(Color);
            teerlingWaarde.Text = controller.AantalOgen.ToString();
        }
    }
}
