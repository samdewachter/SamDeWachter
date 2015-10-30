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
    public partial class YahtzeeView : UserControl
    {

        private YahtzeeController yahtzeeController;

        public YahtzeeView(YahtzeeController yahtzeeController)
        {

            this.yahtzeeController = yahtzeeController;
            InitializeComponent();
        }

        private void YahtzeeView_Load(object sender, EventArgs e)
        {
            List<TeerlingView> teerlingen = yahtzeeController.getTeerlingenView();

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
            yahtzeeController.smijtAlleTeerlingen();

        }

    }
}
