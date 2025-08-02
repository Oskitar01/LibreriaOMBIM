using System;
using System.Drawing;
using System.Windows.Forms;
using Tekla.Structures.Dialog;

namespace LibreriaOMBIM
{
    public partial class FormatoAppMini : UserControl
    {
        public FormatoAppMini()
        {
            InitializeComponent();
        }

        bool isTopPanelDragged = false;

        bool isRightPanelDragged = false;
        bool isBottomPanelDragged = false;


        bool isRightBottomPanelDragged = false;


        bool isWindowMaximized = false;



        Size _normalWindowSize;
        Point _normalWindowLocation = Point.Empty;
        System.Drawing.Point MousedownLocation;



        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                isTopPanelDragged = true;
                MousedownLocation = e.Location;
                //Point pointStartPosition = this.PointToScreen(new Point(e.X, e.Y));
                //offset = new Point();
                //offset.X = this.Location.X - pointStartPosition.X;
                //offset.Y = this.Location.Y - pointStartPosition.Y;
                //frm.Location =  this.Location;
            }
            else
            {
                isTopPanelDragged = false;
            }
            if (e.Clicks == 2)
            {
                isTopPanelDragged = false;
                _MaxButton_Click(sender, e);
            }
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                Form frm = this.FindForm();
                FormBase formBase = frm as FormBase;
                formBase.Top += e.Y - MousedownLocation.Y;
                formBase.Left += e.X - MousedownLocation.X;


                if (formBase.Location.X > 2 || formBase.Location.Y > 2)
                {


                    if (formBase.WindowState == FormWindowState.Maximized)
                    {
                        formBase.Location = _normalWindowLocation;
                        formBase.Size = _normalWindowSize;
                        isWindowMaximized = false;
                    }
                }
            }
        }


        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopPanelDragged = false;
            Form frm = this.FindForm();
            if (frm.Location.Y <= 5)
            {
                if (!isWindowMaximized)
                {
                    _normalWindowSize = frm.Size;
                    _normalWindowLocation = frm.Location;

                    Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                    frm.Location = new Point(0, 0);
                    frm.Size = new System.Drawing.Size(rect.Width, rect.Height);
                    isWindowMaximized = true;
                }
            }
        }






        private void RightPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (_cambiarTamañoForm == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    isRightPanelDragged = true;
                }
                else
                {
                    isRightPanelDragged = false;
                }
            }
        }

        private void RightPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isRightPanelDragged)
            {
                Form frm = this.FindForm();
                if (frm.Width < 100)
                {
                    frm.Width = 100;
                    frm.Refresh();
                    isRightPanelDragged = false;
                }
                else
                {
                    //this.Width = this.Width + e.X;
                    frm.Width = frm.Width + e.X;
                    frm.Refresh();
                }
            }
        }

        private void RightPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isRightPanelDragged = false;
        }



        private void BottomPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (_cambiarTamañoForm == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    isBottomPanelDragged = true;
                }
                else
                {
                    isBottomPanelDragged = false;
                }
            }
        }

        private void BottomPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isBottomPanelDragged)
            {
                Form frm = this.FindForm();
                if (frm.Height < 50)
                {
                    frm.Height = 50;
                    frm.Refresh();
                    isBottomPanelDragged = false;
                }
                else
                {
                    frm.Height = this.Height + e.Y;
                    frm.Refresh();
                }
            }
        }

        private void BottomPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isBottomPanelDragged = false;
        }


        private void _MinButton_Click(object sender, EventArgs e)
        {
            Form frm = this.FindForm();
            frm.WindowState = FormWindowState.Minimized;
        }

        private void _MaxButton_Click(object sender, EventArgs e)
        {
            if (isWindowMaximized)
            {
                Form frm = this.FindForm();
                frm.Location = _normalWindowLocation;
                frm.Size = _normalWindowSize;
                isWindowMaximized = false;
            }
            else
            {
                Form frm = this.FindForm();
                _normalWindowSize = frm.Size;
                _normalWindowLocation = frm.Location;

                Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                frm.Location = new Point(0, 0);
                frm.Size = new System.Drawing.Size(rect.Width, rect.Height);
                isWindowMaximized = true;
            }
        }

        private void _CloseButton_Click(object sender, EventArgs e)
        {
            Form frm = this.FindForm();
            frm.Close();
        }




        private void RightBottomPanel_1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_cambiarTamañoForm == true)
            {
                isRightBottomPanelDragged = true;
            }
        }

        private void RightBottomPanel_1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isRightBottomPanelDragged)
            {
                Form frm = this.FindForm();
                if (frm.Width < 100 || frm.Height < 50)
                {
                    frm.Width = 100;
                    frm.Height = 50;
                    frm.Refresh();
                    isRightBottomPanelDragged = false;
                }
                else
                {
                    //this.Width = this.Width + e.X;
                    //this.Height = this.Height + e.Y;
                    frm.Width = this.Width + e.X;
                    frm.Height = this.Height + e.Y;
                    frm.Refresh();
                }
            }
        }


        private void RightBottomPanel_1_MouseUp(object sender, MouseEventArgs e)
        {
            isRightBottomPanelDragged = false;
        }

        private void RightBottomPanel_2_MouseDown(object sender, MouseEventArgs e)
        {
            RightBottomPanel_1_MouseDown(sender, e);
        }

        private void RightBottomPanel_2_MouseMove(object sender, MouseEventArgs e)
        {
            RightBottomPanel_1_MouseMove(sender, e);
        }

        private void RightBottomPanel_2_MouseUp(object sender, MouseEventArgs e)
        {
            RightBottomPanel_1_MouseUp(sender, e);
        }



        private void WindowTextLabel_MouseDown(object sender, MouseEventArgs e)
        {
            TopPanel_MouseDown(sender, e);
        }

        private void WindowTextLabel_MouseMove(object sender, MouseEventArgs e)
        {
            TopPanel_MouseMove(sender, e);
        }

        private void WindowTextLabel_MouseUp(object sender, MouseEventArgs e)
        {
            TopPanel_MouseUp(sender, e);
        }


        protected Color _borderColor;

        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
            }
        }
        private void OnPaint(object sender, PaintEventArgs e)
        {

            Panel pn = sender as Panel;
            try
            {
                pn.BackColor = BorderColor;
            }
            catch
            {
                // ignored
            }
        }
        private void OnPaintBordeCabecera(object sender, PaintEventArgs e)
        {

            Panel pn = sender as Panel;
            try
            {
                if (BorderColor == Color.Transparent)
                {
                    pn.BackColor = ColorCabecera;
                }
                else
                {
                    pn.BackColor = BorderColor;
                }
            }
            catch
            {
                // ignored
            }
        }

        protected Color _colorCabecera;
        public Color ColorCabecera
        {
            get { return _colorCabecera; }
            set
            {
                _colorCabecera = value;
            }
        }


        private void PanelCabeceraOnPaint(object sender, PaintEventArgs e)
        {
            Panel pn = sender as Panel;
            try
            {
                pn.BackColor = ColorCabecera;

            }
            catch
            {
                // ignored
            }
        }



        public Color ColorFondo
        {
            get { return this.BackColor; }
            set
            {
                this.BackColor = value;
            }
        }

        bool _cambiarTamañoForm = true;

        public bool CambiarTamañoForm
        {
            get { return _cambiarTamañoForm; }
            set
            {
                _cambiarTamañoForm = value;

            }
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
    }
}
