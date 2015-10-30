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
    public partial class TeerlingView : UserControl
    {
        private TeerlingController controller;
        private TeerlingModel teerlingModel;

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



        private void TeerlingView_Load(object sender, EventArgs e)
        {

        }

        private void werpButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
