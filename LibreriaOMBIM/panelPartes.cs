using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TSD = Tekla.Structures.Datatype;

namespace LibreriaOMBIM
{
    public partial class panelPartes : UserControl
    {
        public panelPartes()
        {
            InitializeComponent();

        }

        public string GroupBoxNombre
        {
            get { return label6.Text; }
            set { label6.Text = value; }
        }
        public string TextNombre
        {
            get { return txtNombre.Text; }
            set { txtNombre.Text = value; }
        }
        public string TextPerfil
        {
            get { return txtPerfil.Text; }
            set { txtPerfil.Text = value; }
        }
        public string TextMaterial
        {
            get { return txtMaterial.Text; }
            set { txtMaterial.Text = value; }
        }
        public string TextPrefPart
        {
            get { return txtPrefPart.Text; }
            set { txtPrefPart.Text = value; }
        }
        public string TextNumPart
        {
            get { return txtNumPart.Text; }
            set { txtNumPart.Text = value; }
        }
        public string TextPrefAssembly
        {
            get { return txtPrefConj.Text; }
            set { txtPrefConj.Text = value; }
        }
        public string TextNumAssembly
        {
            get { return txtNumConj.Text; }
            set { txtNumConj.Text = value; }
        }

        public string TextAcabado
        {
            get { return txtAcabado.Text; }
            set { txtAcabado.Text = value; }
        }

        //string _color = "0";
        //public string TextColor
        //{
        //    get { return _color; }
        //    set { _color = value; }
        //}



        public int TextColor
        {
            get { return cmbColor.SelectedIndex; }
            set { cmbColor.SelectedIndex = value; }
        }
        public string TextTipoPedido
        {
            get { return cmbPed.Text; }
            set { cmbPed.Text = value; }
        }


        bool _TextTipoPedido_Visible = true;

        public bool TextTipoPedido_Visible
        {
            get { return _TextTipoPedido_Visible; }
            set
            {
                _TextTipoPedido_Visible = value;

            }
        }

        public bool checkNombre
        {
            get { return chkNombre.Checked; }
            set { chkNombre.Checked = value; }
        }
        public bool checkPerfil
        {
            get { return chkPerfil.Checked; }
            set { chkPerfil.Checked = value; }
        }
        public bool checkMaterial
        {
            get { return chkMaterial.Checked; }
            set { chkMaterial.Checked = value; }
        }
        public bool checkPrefPart
        {
            get { return chkPrefPart.Checked; }
            set { chkPrefPart.Checked = value; }
        }
        public bool checkNumPart
        {
            get { return chkNumPart.Checked; }
            set { chkNumPart.Checked = value; }
        }
        public bool checkPrefConj
        {
            get { return chkPrefConj.Checked; }
            set { chkPrefConj.Checked = value; }
        }
        public bool checkNumConj
        {
            get { return chkNumConj.Checked; }
            set { chkNumConj.Checked = value; }
        }
        public bool checkColor
        {
            get { return chkColor.Checked; }
            set { chkColor.Checked = value; }
        }
        public bool checkComment
        {
            get { return chkPed.Checked; }
            set { chkPed.Checked = value; }
        }
        public bool checkAcabado
        {
            get { return chkAcabado.Checked; }
            set { chkAcabado.Checked = value; }
        }
        List<object> _listObject = new List<object>();

        public List<object> ListObject
        {
            get { return _listObject; }
            set { _listObject = value; }
        }

        //List<bool> _listObjectCheck = new List<bool>();

        //public List<bool> ListObjectCheck
        //{
        //    get { return _listObjectCheck; }
        //    set { _listObjectCheck = value; }
        //}


        //string _TextprofileCatalog = " ";
        //public string TextprofileCatalog
        //{
        //    get { return _TextprofileCatalog; }
        //    set { _TextprofileCatalog = value; }
        //}
        private void cmbComment_VisibleChanged(object sender, EventArgs e)
        {
            try
            {
                cmbPed.Visible = TextTipoPedido_Visible;
                chkPed.Visible = TextTipoPedido_Visible;

            }
            catch
            {
                // ignored
            }

        }

        //private void cmbColor_ImageListComboBoxSelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //int selected = int.Parse(TextColor.ToString());
        //    //cmbColor.SelectedIndex = selected;
        //}


        private void profileCatalog1_SelectClicked(object sender, EventArgs e)
        {
            //profileCatalog1.SelectedProfile = " ";
            profileCatalog1.SelectedProfile = TextPerfil;

            //profileCatalog1.Update();
        }

        private void profileCatalog1_SelectionDone(object sender, EventArgs e)
        {
            TextPerfil = profileCatalog1.SelectedProfile;

        }

        private void materialCatalog1_SelectClicked(object sender, EventArgs e)
        {
            materialCatalog1.SelectedMaterial = TextMaterial;
        }

        private void materialCatalog1_SelectionDone(object sender, EventArgs e)
        {
            TextMaterial = materialCatalog1.SelectedMaterial;
        }

        //private void panelPropiedades_Load(object sender, EventArgs e)
        //{
        //    //_listObject = new List<object>();
        //    //_listObject.Add(TextNombre);
        //    //_listObject.Add(TextPerfil);
        //    //_listObject.Add(TextMaterial);
        //    //_listObject.Add(TextPrefPart);
        //    //_listObject.Add(TextNumPart);
        //    //_listObject.Add(TextPrefAssembly);
        //    //_listObject.Add(TextNumAssembly);
        //    //_listObject.Add(TextColor);
        //    //_listObject.Add(TextTipoPedido);
        //    //_listObject.Add(TextAcabado);

        //    //_listObjectCheck = new List<bool>();
        //    //_listObjectCheck.Add(checkNombre);
        //    //_listObjectCheck.Add(checkPerfil);
        //    //_listObjectCheck.Add(checkMaterial);
        //    //_listObjectCheck.Add(checkPrefPart);
        //    //_listObjectCheck.Add(checkNumPart);
        //    //_listObjectCheck.Add(checkPrefConj);
        //    //_listObjectCheck.Add(checkNumConj);
        //    //_listObjectCheck.Add(checkColor);
        //    //_listObjectCheck.Add(checkComment);
        //    //_listObjectCheck.Add(checkAcabado);
        //}





        //public TextBox TextNumAssembly
        //{
        //    get { return txtNumConj; }
        //    set { txtNumConj = TextNumAssembly; }
        //}

    }

    public class propertiesParts
    {
        public static string TextGroupBox = "TextGroupBox";
        public static CheckBox check = new CheckBox();

        public static string[] ColumnNames = new string[10]
        {
            "Nombre",
            "Perfil",
            "Material",
            "PrefPart",
            "NumPart",
            "PrefConj",
            "NumConj",
            "Color",
            "TipoPedido",
            "Acabado"
        };
        public static Type[] ColumnTypes = new Type[10]
        {

            typeof(TSD.String),
            typeof(TSD.String),
            typeof(TSD.String),
            typeof(TSD.String),
            typeof(TSD.String),
            typeof(TSD.String),
            typeof(TSD.String),
            typeof(TSD.Integer),
            typeof(TSD.String),
            typeof(TSD.String),
        };

    }

    //public class propertiesPartsCheck
    //{
    //    //public static string TextGroupBox = "TextGroupBox";

    //    public static string[] ColumnNames = new string[10]
    //    {
    //        "Nombre",
    //        "Perfil",
    //        "Material",
    //        "PrefPart",
    //        "NumPart",
    //        "PrefConj",
    //        "NumConj",
    //        "Color",
    //        "TipoPedido",
    //        "Acabado"
    //    };
    //    public static Control[] ColumnTypes = new Control[10]
    //    {

    //        new CheckBox(),
    //       new CheckBox(),
    //        new CheckBox(),
    //        new CheckBox(),
    //        new CheckBox(),
    //        new CheckBox(),
    //        new CheckBox(),
    //        new CheckBox(),
    //        new CheckBox(),
    //        new CheckBox()
    //    };

    //}

}
