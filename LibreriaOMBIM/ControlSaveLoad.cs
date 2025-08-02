using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Tekla.Structures;
using Tekla.Structures.Dialog;
using Tekla.Structures.Model;

namespace LibreriaOMBIM
{
    public partial class ControlSaveLoad : UserControl
    {


        public ControlSaveLoad()
        {
            InitializeComponent();



        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Form frm = this.FindForm();
            FormBase formBase = frm as FormBase;
        
            int index;
            string text;

            index = this.cmbLoadValues.SelectedIndex;
            if (index != -1) text = this.cmbLoadValues.SelectedItem.ToString();
            else text = this.cmbLoadValues.Text;


            if (text.Length > 0)
            {
                string nomApp = formBase.Controls.Owner.CompanyName.ToString();
                string nomForm = formBase.Controls.Owner.Name.ToString();

                string paQuitar = "." + nomApp + "." + nomForm;
                text += paQuitar;
                formBase.LoadValues(text);
            }
           
            return;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Form frm = this.FindForm();
            FormBase formBase = frm as FormBase;


            int index;
            string text;

            index = this.cmbLoadValues.SelectedIndex;
            if (index != -1) text = this.cmbLoadValues.SelectedItem.ToString();
            else text = this.cmbLoadValues.Text;
            if (text.Length > 0) formBase.SaveValues(text);
            return;
        }


        private void rellenaCombo(Infinite.UI.UIComboBox
            combo, string[] ficheros)
        {
            Form frm = this.FindForm();
            FormBase formBase = frm as FormBase;

            string nomApp = formBase.Controls.Owner.CompanyName.ToString();
            string nomForm = formBase.Controls.Owner.Name.ToString();

            string paQuitar = "." + nomApp + "." + nomForm;

            foreach (string fichero in ficheros)
            {
                string fi = Path.GetExtension(fichero);
                string nom = Path.GetFileNameWithoutExtension(fichero);

                if (nom.Contains(nomApp))
                {
                    nom = nom.Replace(paQuitar, "");
                    if (!combo.Items.Contains(nom))
                    {
                        combo.Items.Add(nom);
                    }
                }
            }

        }

        private void cmbLoadValues_DropDown(object sender, EventArgs e)
        {
            Model model = new Model();
            Infinite.UI.UIComboBox combo = (sender) as Infinite.UI.UIComboBox;

            string modelpath = model.GetInfo().ModelPath;
            string FileName = Path.Combine(modelpath, "attributes");

            this.rellenaCombo(combo, Directory.GetFiles(FileName));

            TryGetFileInFirmProjectOrSystemFolders(combo);
        }
        public bool TryGetFileInFirmProjectOrSystemFolders(Infinite.UI.UIComboBox combo)
        {
            //filePath = null;
            var advancedOptions = new List<string> { "XS_FIRM", "XS_PROJECT", "XS_SYSTEM" };
            foreach (var advancedOption in advancedOptions)
            {
                List<string> paths;
                if (!TeklaStructuresSettings.GetAdvancedOptionPaths(
                    advancedOption,
                    out paths,
                    MyGetAdvancedOptionPathsErrorCallback))
                {
                    continue;
                }

                foreach (var path in paths)
                {
                    rellenaCombo(combo, Directory.GetFiles(path));


                  
                    return true;
                    
                }
            }

            return false;
        }


        public static void MyGetAdvancedOptionPathsErrorCallback(string advancedOpt, string invalidString, string exceptionMessage)
        {
            Console.WriteLine(
                string.Format(
                    "The advanced option path string {0} could not be read correctly. Some or all of its content(s) will be ignored.",
                    advancedOpt));

            if (!string.IsNullOrWhiteSpace(invalidString))
            {
                Console.WriteLine("The invalid string is: " + invalidString);
            }

            if (!string.IsNullOrWhiteSpace(exceptionMessage))
            {
                Console.WriteLine("The exception message is: " + exceptionMessage);
            }
        }





        private void ControlSaveLoad_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("hola");
        }

        private void ControlSaveLoad_ControlAdded(object sender, ControlEventArgs e)
        {
            MessageBox.Show("hola");
        }
    }
}
