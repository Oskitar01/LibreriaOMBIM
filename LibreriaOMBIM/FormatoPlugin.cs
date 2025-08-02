using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Tekla.Structures.Dialog;
using Tekla.Structures.Model;

namespace LibreriaOMBIM
{
    public partial class FormatoPlugin : UserControl
    {
        public FormatoPlugin()
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
                //Form frm = this.FindForm();
                //Point newPoint = TopPanel.PointToScreen(new Point(e.X, e.Y));
                //newPoint.Offset(offset);

                //this.Location = newPoint;

                //this.Top += e.Y - MousedownLocation.Y;
                //this.Left += e.X - MousedownLocation.X;


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
            Form frm = this.FindForm();
            FormBase formBase = frm as FormBase;
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
                Form frm = this.FindForm();
                FormBase formBase = frm as FormBase;
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
                Form frm = this.FindForm();
                FormBase formBase = frm as FormBase;
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
            Form frm = this.FindForm();
            FormBase formBase = frm as FormBase;
            formBase.WindowState = FormWindowState.Minimized;
        }

        private void _MaxButton_Click(object sender, EventArgs e)
        {
            if (isWindowMaximized)
            {
                Form frm = this.FindForm();
                FormBase formBase = frm as FormBase;
                formBase.Location = _normalWindowLocation;
                formBase.Size = _normalWindowSize;
                //toolTip1.SetToolTip(_MaxButton, "Maximize");
                //_MaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
                isWindowMaximized = false;
            }
            else
            {
                Form frm = this.FindForm();
                FormBase formBase = frm as FormBase;
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
            FormBase formBase = frm as FormBase;
            formBase.Close();
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
                FormBase formBase = frm as FormBase;
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
                buttonSave.BackColor = ColorCabecera;
                buttonLoad.BackColor = ColorCabecera;
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

        protected bool _cambiarTamañoForm = true;

        public bool CambiarTamañoForm
        {
            get { return _cambiarTamañoForm; }
            set
            {
                _cambiarTamañoForm = value;

            }
        }





        //public int AltoCabecera
        //{
        //    get { return TopPanel.Height; }
        //    set
        //    {
        //        TopPanel.Height = value;
        //    }
        //}

        public string Titletext
        {
            get { return Titulo.Text; }
            set
            {
                Titulo.Text = value;
            }
        }

        protected string _selectedFilename;

        public string SelectedFilename
        {
            get { return _selectedFilename; }
            set
            {
                _selectedFilename = value;
            }
        }

        FormBase formBase;


        bool isAtributeLoaded = false;
        public event EventHandler OnAttributesLoaded;
        protected override void OnClick(EventArgs e)
        {
            if (isAtributeLoaded == true)
            {
                Form frm = this.FindForm();
                formBase = frm as FormBase;

                int index;
                string text;

                index = this.cmbLoadValues.SelectedIndex;
                if (index != -1) text = this.cmbLoadValues.SelectedItem.ToString();
                else text = this.cmbLoadValues.Text;


                if (text.Length > 0)
                {
                    formBase.LoadValues(text);
                }

                try
                {
                    OnAttributesLoaded(buttonLoad, e);
                }
                catch { }
            }
            base.OnClick(e);
        }

        private void buttonLoad_MouseEnter(object sender, EventArgs e)
        {
            isAtributeLoaded = true;
            buttonLoad.Click += OnAttributesLoaded;
        }

        private void buttonLoad_MouseLeave(object sender, EventArgs e)
        {
            isAtributeLoaded = false;
            buttonLoad.Click -= OnAttributesLoaded;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }






        //private void btnLoad_Click(object sender, EventArgs e)
        //{
        //    Form frm = this.FindForm();
        //    FormBase formBase = frm as FormBase;

        //    int index;
        //    string text;

        //    index = this.cmbLoadValues.SelectedIndex;
        //    if (index != -1) text = this.cmbLoadValues.SelectedItem.ToString();
        //    else text = this.cmbLoadValues.Text;


        //    if (text.Length > 0)
        //    {
        //        formBase.LoadValues(text);
        //    }

        //    return;
        //}



        private void btnSave_Click(object sender, EventArgs e)
        {
            Form frm = this.FindForm();
            formBase = frm as FormBase;

            int index;
            string text;

            index = this.cmbLoadValues.SelectedIndex;
            if (index != -1) text = this.cmbLoadValues.SelectedItem.ToString();
            else text = this.cmbLoadValues.Text;
            if (text.Length > 0)
            {
                SelectedFilename = text;
                formBase.SaveValues(text);
            }

            return;
        }




        private void rellenaCombo(ComboBox combo, string[] ficheros)
        {
            Form frm = this.FindForm();
            FormBase formBase = frm as FormBase;

            string form = formBase.Controls.Owner.ToString();
            string[] headers = form.Split(',');

            string final = "";

            for (int k = 0; k < headers.Length; k++)
            {
                final = "." + headers[0] + ".xml";
            }
            combo.Items.Clear();

            for (int i = 0; i < ficheros.Length; i++)
            {

                string f = ficheros[i];
                if (f.Contains(final))
                {
                    f = f.Replace(final, "");
                    string[] headers1 = f.Split('\\');
                    string p = "";
                    for (int k = 0; k < headers1.Length; k++)
                    {
                        p = headers1[headers1.Length - 1];
                    }
                    combo.Items.Add(p);
                }
            }
            if (!combo.Items.Contains("standard"))
            {
                combo.Items.Add("standard");
                formBase.SaveValues("standard");
            }
        }

        private void cmbLoadValues_DropDown(object sender, EventArgs e)
        {
            Model model = new Model();
            string modelpath = model.GetInfo().ModelPath;
            string FileName = Path.Combine(modelpath, "attributes");
            this.rellenaCombo(this.cmbLoadValues, Directory.GetFiles(FileName));
        }



        private void FormatoPlugin_Load(object sender, EventArgs e)
        {
            //string text = "standard";
            //cmbLoadValues.Items.Add(text);


            //cmbLoadValues.SelectedIndex = 0;


        }


        bool isActiveButtonSave = false;

        public event MouseEventHandler OnSaveClicked;

        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (isActiveButtonSave == true)
            {
                try
                {
                    OnSaveClicked(buttonSave, e);
                }
                catch
                {

                }
            }

            base.OnMouseClick(e);
        }





        private void buttonSave_MouseEnter(object sender, EventArgs e)
        {
            isActiveButtonSave = true;
            buttonSave.MouseClick += OnSaveClicked;
        }

        private void buttonSave_MouseLeave(object sender, EventArgs e)
        {
            isActiveButtonSave = false;
            buttonSave.MouseClick -= OnSaveClicked;
        }

        private void ButtonSave_MouseClick(object sender, MouseEventArgs e)
        {
            OnMouseClick(e);
        }












        //public event EventHandler FormLoad;

        //protected override void OnLoad(EventArgs e)
        //{
        //    //Form frm = this.FindForm();
        //    //FormBase formBase = frm as FormBase;
        //    //FormLoad(formBase, e);
        //    base.OnLoad(e);
        //}

        //    private void FormatoPlugin_Load(object sender, EventArgs e)
        //{
        //Form frm = this.FindForm();
        //FormBase formBase = frm as FormBase;

        //this.Load += FormLoad;
        //OnLoad(e);
        //}



        //private void saveStandard()
        //{
        //    Form frm = this.FindForm();
        //    FormBase formBase = frm as FormBase;

        //    string text = "standard";

        //    Model model = new Model();
        //    string modelpath = model.GetInfo().ModelPath;
        //    string FileName = Path.Combine(modelpath, "attributes");


        //    string b = busca(Directory.GetFiles(FileName));

        //    if (b != text) formBase.SaveValues(text);
        //    cmbLoadValues.Items.Add(text);
        //    cmbLoadValues.SelectedItem = text;
        //    return;
        //}
        //private string busca(string[] ficheros)
        //{
        //    Form frm = this.FindForm();
        //    FormBase formBase = frm as FormBase;

        //    string buscarStandard = "";

        //    string form = formBase.Controls.Owner.ToString();
        //    string[] headers = form.Split(',');

        //    string final = "";

        //    for (int k = 0; k < headers.Length; k++)
        //    {
        //        final = "." + headers[0] + ".xml";
        //    }

        //    for (int i = 0; i < ficheros.Length; i++)
        //    {

        //        string f = ficheros[i];
        //        if (f.Contains(final))
        //        {

        //            f = f.Replace(final, "");
        //            string[] headers1 = f.Split('\\');
        //            string p = "";
        //            for (int k = 0; k < headers1.Length; k++)
        //            {
        //                p = headers1[headers1.Length - 1];
        //                if (p == "standard")
        //                {
        //                    buscarStandard = p;
        //                }
        //            }

        //        }
        //    }

        //    return buscarStandard;
        //}


    }
}
