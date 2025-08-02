using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Tekla.Structures.Dialog;
using Tekla.Structures.Model;

namespace LibreriaOMBIM
{
    public partial class panelForm : UserControl
    {
        //private readonly Model MyModel;

        public panelForm()
        {
            InitializeComponent();
            //MyModel = new Model();

        }

        bool isTopPanelDragged = false;

        bool isRightPanelDragged = false;
        bool isBottomPanelDragged = false;


        bool isRightBottomPanelDragged = false;


        bool isWindowMaximized = false;

        bool isFormBig = false;

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
                //Form frm = this.FindForm();
                //Point newPoint = TopPanel.PointToScreen(new Point(e.X, e.Y));
                //newPoint.Offset(offset);

                //this.Location = newPoint;

                //this.Top += e.Y - MousedownLocation.Y;
                //this.Left += e.X - MousedownLocation.X;


                Form formBase = this.FindForm();

                formBase.Top += e.Y - MousedownLocation.Y;
                formBase.Left += e.X - MousedownLocation.X;


                if (formBase.Location.X > 2 || formBase.Location.Y > 2)
                {


                    if (formBase.WindowState == FormWindowState.Maximized)
                    {
                        formBase.Location = _normalWindowLocation;
                        formBase.Size = _normalWindowSize;
                        //toolTip1.SetToolTip(_MaxButton, "Maximize");
                        //_MaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
                        isWindowMaximized = false;
                    }
                }
            }
        }


        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopPanelDragged = false;
            Form formBase = this.FindForm();
            if (formBase.Location.Y <= 5)
            {
                if (!isWindowMaximized)
                {
                    _normalWindowSize = formBase.Size;
                    _normalWindowLocation = formBase.Location;

                    Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                    formBase.Location = new Point(0, 0);
                    formBase.Size = new System.Drawing.Size(rect.Width, rect.Height);
                    //toolTip1.SetToolTip(_MaxButton, "Restore Down");
                    //_MaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
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
                Form formBase = this.FindForm();
                //FormBase formBase = frm as FormBase;
                if (formBase.Width < 100)
                {
                    //this.Width = 100;
                    formBase.Width = 100;
                    formBase.Refresh();
                    isRightPanelDragged = false;
                }
                else
                {
                    //this.Width = this.Width + e.X;
                    formBase.Width = formBase.Width + e.X;
                    formBase.Refresh();
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
                Form formBase = this.FindForm();
                //FormBase formBase = frm as FormBase;
                if (formBase.Height < 50)
                {
                    //this.Height = 50;
                    formBase.Height = 50;
                    formBase.Refresh();
                    isBottomPanelDragged = false;
                }
                else
                {
                    //this.Height = this.Height + e.Y;
                    formBase.Height = this.Height + e.Y;
                    formBase.Refresh();
                }
            }
        }

        private void BottomPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isBottomPanelDragged = false;
        }


        private void _MinButton_Click(object sender, EventArgs e)
        {
            Form formBase = this.FindForm();
            //FormBase formBase = frm as FormBase;
            formBase.WindowState = FormWindowState.Minimized;
        }

        private void _MaxButton_Click(object sender, EventArgs e)
        {
            if (isWindowMaximized)
            {
                Form formBase = this.FindForm();
                //FormBase formBase = frm as FormBase;
                formBase.Location = _normalWindowLocation;
                formBase.Size = _normalWindowSize;
                //toolTip1.SetToolTip(_MaxButton, "Maximize");
                //_MaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
                isWindowMaximized = false;
            }
            else
            {
                Form formBase = this.FindForm();
                //FormBase formBase = frm as FormBase;
                _normalWindowSize = formBase.Size;
                _normalWindowLocation = formBase.Location;

                Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                formBase.Location = new Point(0, 0);
                formBase.Size = new System.Drawing.Size(rect.Width, rect.Height);
                //toolTip1.SetToolTip(_MaxButton, "Restore Down");
                //_MaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
                isWindowMaximized = true;
            }
        }

        private void _CloseButton_Click(object sender, EventArgs e)
        {
            Form frm = this.FindForm();
            //FormBase formBase = frm as FormBase;
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
                Form formBase = this.FindForm();
                //FormBase formBase = frm as FormBase;
                if (formBase.Width < 100 || formBase.Height < 50)
                {
                    //this.Width = 100;
                    //this.Height = 50;
                    formBase.Width = 100;
                    formBase.Height = 50;
                    formBase.Refresh();
                    isRightBottomPanelDragged = false;
                }
                else
                {
                    //this.Width = this.Width + e.X;
                    //this.Height = this.Height + e.Y;
                    formBase.Width = this.Width + e.X;
                    formBase.Height = this.Height + e.Y;
                    formBase.Refresh();
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


















        //private void file_button_Click(object sender, EventArgs e)
        //{
        //    file_button.BZBackColor = Color.Black;
        //    file_button.ChangeColorMouseHC = false;
        //    edit_button.BZBackColor = Color.FromArgb(60, 60, 60);
        //    view_button.BZBackColor = Color.FromArgb(60, 60, 60);
        //    run_button.BZBackColor = Color.FromArgb(60, 60, 60);
        //    help_button.BZBackColor = Color.FromArgb(60, 60, 60);
        //    edit_button.ChangeColorMouseHC = true;
        //    view_button.ChangeColorMouseHC = true;
        //    run_button.ChangeColorMouseHC = true;
        //    help_button.ChangeColorMouseHC = true;
        //}

        //private void edit_button_Click(object sender, EventArgs e)
        //{
        //    edit_button.BZBackColor = Color.Black;
        //    edit_button.ChangeColorMouseHC = false;
        //    file_button.BZBackColor = Color.FromArgb(60, 60, 60);
        //    view_button.BZBackColor = Color.FromArgb(60, 60, 60);
        //    run_button.BZBackColor = Color.FromArgb(60, 60, 60);
        //    help_button.BZBackColor = Color.FromArgb(60, 60, 60);
        //    file_button.ChangeColorMouseHC = true;
        //    view_button.ChangeColorMouseHC = true;
        //    run_button.ChangeColorMouseHC = true;
        //    help_button.ChangeColorMouseHC = true;
        //}

        //private void view_button_Click(object sender, EventArgs e)
        //{
        //    view_button.BZBackColor = Color.Black;
        //    view_button.ChangeColorMouseHC = false;
        //    file_button.BZBackColor = Color.FromArgb(60, 60, 60);
        //    edit_button.BZBackColor = Color.FromArgb(60, 60, 60);
        //    run_button.BZBackColor = Color.FromArgb(60, 60, 60);
        //    help_button.BZBackColor = Color.FromArgb(60, 60, 60);
        //    file_button.ChangeColorMouseHC = true;
        //    edit_button.ChangeColorMouseHC = true;
        //    run_button.ChangeColorMouseHC = true;
        //    help_button.ChangeColorMouseHC = true;
        //}

        //private void run_button_Click(object sender, EventArgs e)
        //{
        //    run_button.BZBackColor = Color.Black;
        //    run_button.ChangeColorMouseHC = false;
        //    file_button.BZBackColor = Color.FromArgb(60, 60, 60);
        //    edit_button.BZBackColor = Color.FromArgb(60, 60, 60);
        //    view_button.BZBackColor = Color.FromArgb(60, 60, 60);
        //    help_button.BZBackColor = Color.FromArgb(60, 60, 60);
        //    file_button.ChangeColorMouseHC = true;
        //    edit_button.ChangeColorMouseHC = true;
        //    view_button.ChangeColorMouseHC = true;
        //    help_button.ChangeColorMouseHC = true;
        //}

        //private void help_button_Click(object sender, EventArgs e)
        //{
        //    help_button.BZBackColor = Color.Black;
        //    help_button.ChangeColorMouseHC = false;
        //    file_button.BZBackColor = Color.FromArgb(60, 60, 60);
        //    edit_button.BZBackColor = Color.FromArgb(60, 60, 60);
        //    view_button.BZBackColor = Color.FromArgb(60, 60, 60);
        //    run_button.BZBackColor = Color.FromArgb(60, 60, 60);
        //    file_button.ChangeColorMouseHC = true;
        //    edit_button.ChangeColorMouseHC = true;
        //    view_button.ChangeColorMouseHC = true;
        //    run_button.ChangeColorMouseHC = true;
        //}






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


        Color _borderColor = Color.Transparent;

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

        Color _colorCabecera = SystemColors.AppWorkspace;
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
                buttonSave.BackColor = ColorCabecera;
                buttonLoad.BackColor = ColorCabecera;
            }
            catch
            {
                // ignored
            }
        }


        Color _colorFondo = SystemColors.ControlLight;
        public Color ColorFondo
        {
            get { return _colorFondo; }
            set
            {
                _colorFondo = value;
            }
        }

        //protected bool _crearBordes;

        //public bool CrearBordes
        //{
        //    get { return _crearBordes; }
        //    set
        //    {
        //        _crearBordes = value;

        //    }
        //}

        bool _cambiarTamañoForm = true;

        public bool CambiarTamañoForm
        {
            get { return _cambiarTamañoForm; }
            set
            {
                _cambiarTamañoForm = value;

            }
        }

        bool _cuadroGuargar = true;

        public bool CuadroGuardar
        {
            get { return _cuadroGuargar; }
            set
            {
                _cuadroGuargar = value;

            }
        }
        bool _minimizarMaximizar = true;

        public bool MinimizarMaximizar
        {
            get { return _minimizarMaximizar; }
            set
            {
                _minimizarMaximizar = value;

            }
        }

        bool _iconoEmpresa = true;

        public bool IconoEmpresa
        {
            get { return _iconoEmpresa; }
            set
            {
                _iconoEmpresa = value;

            }
        }

        bool _cambiarAltoMaxForm = false;

        public bool CambiarAltoMaxForm
        {
            get { return _cambiarAltoMaxForm; }
            set
            {
                _cambiarAltoMaxForm = value;

            }
        }
        int _altoForm = 500;
        public int AltoForm
        {
            get { return _altoForm; }
            set
            {
                _altoForm = value;
            }
        }

        public string Titletext
        {
            get { return Titulo.Text; }
            set
            {
                Titulo.Text = value;
            }
        }

        private void panelForm_Load(object sender, EventArgs e)
        {
            if (_cuadroGuargar == true)
            {
                tableLayoutPanelSaveLoad.Visible = true;
            }
            else
            {
                tableLayoutPanelSaveLoad.Visible = false;
            }

            if (_iconoEmpresa == true)
            {
                pictureBox4.Visible = true;
                Titulo.Location = new Point(31, 8);
            }
            else
            {
                pictureBox4.Visible = false;
                Titulo.Location = new Point(5, 8);

            }

            if (_minimizarMaximizar == true)
            {
                button2.Visible = true;
                button3.Visible = true;

            }
            else
            {
                button2.Visible = false;
                button3.Visible = false;
            }



            //Timer1
            Timer1.Interval = 5;
            Timer1.Tick += Timer1_Tick;

            //Timer2
            Timer2.Interval = 5;
            Timer2.Tick += Timer2_Tick;




        }

        protected Timer Timer1 = new Timer();
        protected Timer Timer2 = new Timer();

        // Timer1
        void Timer1_Tick(object sender, EventArgs e)
        {
            if (Top < 0)
            {
                Top++;
            }
            else
            {
                Timer1.Stop();
            }
        }

        //Timer2
        void Timer2_Tick(object sender, EventArgs e)
        {
            if (Bottom > 4)
            {
                //Top--;
            }
            else
            {
                Timer2.Stop();
            }
        }

        //public event EventHandler FormLoad;

        //protected override void OnLoad(EventArgs e)
        //{
        //    //Form frm = this.FindForm();
        //    //FormBase formBase = frm as FormBase;
        //    //FormLoad(formBase, e);
        //    base.OnLoad(e);
        //}



        //private void panelForm_Load(object sender, EventArgs e)
        //{
        //    Form frm = this.FindForm();
        //    //FormBase formBase = frm as FormBase;

        //    frm.Load += FormLoad;
        //    OnLoad(e);
        //}

        public void btnLoad_Click(object sender, EventArgs e)
        {
            Model model = new Model();

            Form frm = this.FindForm();
            FormBase formBase = frm as FormBase;

            int index;
            string text, pad;

            string modelpath = model.GetInfo().ModelPath;

            index = this.cmbLoadValues.SelectedIndex;
            if (index != -1) text = this.cmbLoadValues.SelectedItem.ToString();
            else text = this.cmbLoadValues.Text;


            if (text.Length > 0)
            {
                pad = BuscaPath(text);

                string nombreNamespace = GetThisNamespace();
                string FileName2 = Path.Combine(pad, text + nombreNamespace);

                formBase.ApplyValues(FileName2);
            }

            return;
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            Model model = new Model();

            Form frm = this.FindForm();
            FormBase formBase = frm as FormBase;

            int index;
            string text, pad;

            string modelpath = model.GetInfo().ModelPath;

            index = this.cmbLoadValues.SelectedIndex;
            if (index != -1) text = this.cmbLoadValues.SelectedItem.ToString();
            else text = this.cmbLoadValues.Text;

            if (text.Length > 0)
            {
                pad = BuscaPath(text);
                string nombreNamespace = GetThisNamespace();
                string FileName2 = Path.Combine(pad, text + nombreNamespace);
                formBase.SaveValues(FileName2);
            }

            return;
        }

        public string BuscaPath(string text)
        {
            Model model = new Model();

            string modelpath = model.GetInfo().ModelPath;
            string FileName = Path.Combine(modelpath, "attributes");

            return FileName;
        }


        public string GetThisNamespace()
        {
            Form frm = this.FindForm();
            //FormBase formBase = frm as FormBase;
            string nombre = frm.GetType().Namespace;
            string filename = "." + nombre + "." + frm.Name + ".xml";

            return filename;
        }

        private void rellenaCombo(ComboBox combo, string[] ficheros)
        {
            Form frm = this.FindForm();
            FormBase formBase = frm as FormBase;

            string form = formBase.GetType().Namespace;
            string name = formBase.Name;
            foreach (string fichero in ficheros)
            {

                string fi = Path.GetFileNameWithoutExtension(fichero);
                if (fi.Contains(form))
                {
                    string cambio = "." + form + "." + name;
                    fi = fi.Replace(cambio, "");

                    combo.Items.Add(fi);
                }
            }

        }

        private void cmbLoadValues_DropDown(object sender, EventArgs e)
        {
            Model model = new Model();

            if (model.GetConnectionStatus() == false)
            {
                MessageBox.Show("Connection to model failed!");
            }
            else
            {
                Model myModel = new Model();
                //Model model = new Model();
                string modelpath = myModel.GetInfo().ModelPath;
                string FileName = Path.Combine(modelpath, "attributes");
                this.rellenaCombo(this.cmbLoadValues, Directory.GetFiles(FileName));
            }
        }

        private void cmbLoadValues_TextUpdate(object sender, EventArgs e)
        {
            string s = cmbLoadValues.SelectedText;
            cmbLoadValues.SelectedItem = s.ToString();
        }

        private void TopPanel_MouseEnter(object sender, EventArgs e)
        {
            Form formBase = this.FindForm();

            if (CambiarAltoMaxForm)
            {
                formBase.Size = new System.Drawing.Size(formBase.Width, AltoForm);
                isFormBig = true;
            }
            else
            {
                formBase.Size = new System.Drawing.Size(formBase.Width, formBase.Height);
                isFormBig = false;
            }
        }



        private void panelForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isFormBig)
            {
                Form formBase = this.FindForm();

                if ((e.Location.Y > formBase.Height - 10 /*&& e.Y < formBase.Height + 5*/) || (e.Location.X > formBase.Width - 10 /*&& e.X < formBase.Width + 5*/))
                {
                    formBase.Size = new System.Drawing.Size(formBase.Width, 34);
                }
                else
                {
                    formBase.Size = new System.Drawing.Size(formBase.Width, formBase.Height);
                }
            }


            //if (e.Y < Height / 2)
            //{
            //    Timer1.Start();
            //    Timer2.Stop();
            //}
            //else
            //{
            //    Timer2.Start();
            //    Timer1.Stop();
            //}
        }

        private void panelForm_MouseLeave(object sender, EventArgs e)
        {
            isFormBig = true;

        }


    }
}
