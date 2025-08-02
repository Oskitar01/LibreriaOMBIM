using System;
using System.Drawing;
using System.Windows.Forms;

namespace LibreriaOMBIM
{
    public partial class BarraSaveLoad : UserControl
    {
        public BarraSaveLoad()
        {
            InitializeComponent();
        }

        private void pnlSaveLoad_Click(object sender, EventArgs e)
        {
            if (this.Height < 10)
            {
                this.Height = 40;
                this.BringToFront();
            }
            else
            {
                this.Height = 5;
            }
        }

        private void pnlSaveLoad_MouseEnter(object sender, EventArgs e)
        {
            if (this.Height < 10)
            {
                this.BackColor = SystemColors.ActiveCaption;
            }
            else
            {
                this.BackColor = SystemColors.ControlLight;
            }

        }

        private void pnlSaveLoad_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ControlLight;
        }

        private void pnlSaveLoad_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = SystemColors.ControlLight;
        }

    }
}
