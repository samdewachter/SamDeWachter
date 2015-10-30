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
    public partial class MexicoView : UserControl
    {

        private MexicoController mexicoController;

        public MexicoView(MexicoController mexicoController)
        {

            this.mexicoController = mexicoController;
            InitializeComponent();
        }

        private void MexicoView_Load(object sender, EventArgs e)
        {
            List<TeerlingView> teerlingen = mexicoController.getTeerlingenView();

            int teerlingWidth = teerlingen.First().Width;

            int teerlingHeight = teerlingen.First().Height;

            foreach (TeerlingView teerling in teerlingen)
            {
                TeerlingView huidigeTeerling = teerling;

                int xPos = teerlingen.IndexOf(teerling) * teerlingWidth;

                huidigeTeerling.Location = new Point(xPos, 0);

                Controls.Add(huidigeTeerling);
            }

            werpAlleTeerlingenButton.Location = new Point(10, teerlingHeight);
        }

        private void smijtAlleTeerlingenButton_click(object sender, EventArgs e)
        {
            mexicoController.smijtAlleTeerlingen();

        }

    }
}
