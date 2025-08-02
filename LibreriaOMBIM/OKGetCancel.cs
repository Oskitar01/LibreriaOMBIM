using System;
using System.Windows.Forms;

namespace LibreriaOMBIM
{
    public partial class OKGetCancel : UserControl
    {

        public OKGetCancel()
        {
            InitializeComponent();
            //btn_Cancel.Click += BotonCancelClick;
            //btnGet.Click += BotonGetClick;
            //btnModify.Click += BotonModifyClick;
            //btnToggle.Click += BotonOnOffClick;
            //btnApply.Click += BotonApplyClick;
            //btn_OK.Click += BotonOKClick;

        }
        bool isActiveButtonCancel = false;
        bool isActiveButtonOnOff = false;
        bool isActiveButtonGet = false;
        bool isActiveButtonModify = false;
        bool isActiveButtonApply = false;
        bool isActiveButtonOk = false;



        public event EventHandler BotonCancelClick;
        //[Category("Action"), Browsable(true), Description("El color del titulo de la pagina")]

        //protected override void OnMouseClick(MouseEventArgs e)
        //{
        //    if (isActiveButtonCancel == true)
        //    {
        //        BotonCancelClick(btn_Cancel, e);
        //    }
        //    if (isActiveButtonOnOff == true)
        //    {
        //        BotonOnOffClick(btn_Cancel, e);
        //    }

        //    base.OnMouseClick(e);
        //}

        protected override void OnClick(EventArgs e)
        {
            if (isActiveButtonCancel == true)
            {
                BotonCancelClick(btn_Cancel, e);
            }
            else if (isActiveButtonOnOff == true)
            {
                buttonOnOff.Click += BotonOnOffClick;
                BotonOnOffClick(buttonOnOff, e);
            }
            else if (isActiveButtonGet == true)
            {
                BotonGetClick(btnGet, e);
            }
            else if (isActiveButtonModify == true)
            {
                BotonModifyClick(btnModify, e);
            }
            else if (isActiveButtonApply == true)
            {
                BotonApplyClick(btn_OK, e);
            }
            else if (isActiveButtonOk == true)
            {
                BotonOKClick(btn_OK, e);
            }

            base.OnClick(e);
        }

        public event EventHandler BotonOnOffClick;
        //[Category("Action"), Browsable(true), Description("El color del titulo de la pagina")]

        //protected virtual void OnBotonOnOffClick(EventArgs e)
        //{
        //    if (BotonOnOffClick != null)
        //        BotonOnOffClick(btnToggle, e);
        //}

        public event EventHandler BotonGetClick;
        //[Category("Action"), Browsable(true), Description("El color del titulo de la pagina")]

        //protected virtual void OnBotonGetClick(EventArgs e)
        //{
        //    if (BotonGetClick != null)
        //        BotonGetClick(btnGet, e);
        //}

        public event EventHandler BotonModifyClick;
        //[Category("Action"), Browsable(true), Description("El color del titulo de la pagina")]

        //protected virtual void OnBotonModifyClick(EventArgs e)
        //{
        //    if (BotonModifyClick != null)
        //        BotonModifyClick(btnModify, e);
        //}

        public event EventHandler BotonApplyClick;
        //[Category("Action"), Browsable(true), Description("El color del titulo de la pagina")]

        //protected virtual void OnBotonApplyClick(EventArgs e)
        //{
        //    if (BotonApplyClick != null)
        //        BotonApplyClick(btnApply, e);
        //}

        public event EventHandler BotonOKClick;
        //[Category("Action"), Browsable(true), Description("El color del titulo de la pagina")]

        //protected virtual void OnBotonOKClick(EventArgs e)
        //{
        //    if (BotonOKClick != null)
        //        BotonOKClick(btn_OK, e);
        //}

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

            OnClick(e);

        }


        private void buttonOnOff_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
        private void btnGet_Click(object sender, EventArgs e)
        {

            OnClick(e);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {

            OnClick(e);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {

            OnClick(e);
        }

        private void btn_Cancel_MouseEnter(object sender, EventArgs e)
        {
            isActiveButtonCancel = true;
            btn_Cancel.Click += BotonCancelClick;

        }

        private void btn_Cancel_MouseLeave(object sender, EventArgs e)
        {
            isActiveButtonCancel = false;
            btn_Cancel.Click -= BotonCancelClick;
        }

        private void btnToggle_MouseEnter(object sender, EventArgs e)
        {
            isActiveButtonOnOff = true;
            //buttonOnOff.Click += BotonOnOffClick;
        }

        private void btnToggle_MouseLeave(object sender, EventArgs e)
        {
            isActiveButtonOnOff = false;
            buttonOnOff.Click -= BotonOnOffClick;
        }

        private void btnGet_MouseEnter(object sender, EventArgs e)
        {
            isActiveButtonGet = true;
            btnGet.Click += BotonGetClick;

        }

        private void btnGet_MouseLeave(object sender, EventArgs e)
        {
            isActiveButtonGet = false;
            btnGet.Click -= BotonGetClick;

        }

        private void btnModify_MouseEnter(object sender, EventArgs e)
        {
            isActiveButtonModify = true;
            btnModify.Click += BotonModifyClick;

        }

        private void btnModify_MouseLeave(object sender, EventArgs e)
        {
            isActiveButtonModify = false;
            btnModify.Click -= BotonModifyClick;

        }

        private void btnApply_MouseEnter(object sender, EventArgs e)
        {
            isActiveButtonApply = true;
            btn_OK.Click += BotonApplyClick;


        }

        private void btnApply_MouseLeave(object sender, EventArgs e)
        {
            isActiveButtonApply = false;
            btn_OK.Click -= BotonApplyClick;

        }

        private void btn_OK_MouseEnter(object sender, EventArgs e)
        {
            isActiveButtonOk = true;
            btn_OK.Click += BotonOKClick;
        }

        private void btn_OK_MouseLeave(object sender, EventArgs e)
        {
            isActiveButtonOk = false;
            btn_OK.Click -= BotonOKClick;
        }


    }
}
