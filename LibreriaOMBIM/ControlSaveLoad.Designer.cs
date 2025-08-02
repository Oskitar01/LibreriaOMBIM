namespace LibreriaOMBIM
{
    partial class ControlSaveLoad
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbLoadValues = new Infinite.UI.UIComboBox();
            this.uiSymbolButtonLoad = new Infinite.UI.UISymbolButton();
            this.uiSymbolButtonSave = new Infinite.UI.UISymbolButton();
            this.uiTableLayoutPanel2 = new Infinite.UI.UITableLayoutPanel();
            this.uiTableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbLoadValues
            // 
            this.cmbLoadValues.DataSource = null;
            this.cmbLoadValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbLoadValues.FillColor = System.Drawing.Color.White;
            this.cmbLoadValues.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cmbLoadValues.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cmbLoadValues.Location = new System.Drawing.Point(214, 5);
            this.cmbLoadValues.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbLoadValues.MinimumSize = new System.Drawing.Size(63, 0);
            this.cmbLoadValues.Name = "cmbLoadValues";
            this.cmbLoadValues.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cmbLoadValues.Size = new System.Drawing.Size(296, 31);
            this.cmbLoadValues.SymbolSize = 24;
            this.cmbLoadValues.TabIndex = 144;
            this.cmbLoadValues.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmbLoadValues.Watermark = "";
            this.cmbLoadValues.DropDown += new System.EventHandler(this.cmbLoadValues_DropDown);
            // 
            // uiSymbolButtonLoad
            // 
            this.uiSymbolButtonLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButtonLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiSymbolButtonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolButtonLoad.Location = new System.Drawing.Point(3, 3);
            this.uiSymbolButtonLoad.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButtonLoad.Name = "uiSymbolButtonLoad";
            this.uiSymbolButtonLoad.Size = new System.Drawing.Size(99, 35);
            this.uiSymbolButtonLoad.Style = Infinite.UI.UIStyle.Custom;
            this.uiSymbolButtonLoad.Symbol = 57438;
            this.uiSymbolButtonLoad.TabIndex = 145;
            this.uiSymbolButtonLoad.Text = "Cargar";
            this.uiSymbolButtonLoad.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiSymbolButtonLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // uiSymbolButtonSave
            // 
            this.uiSymbolButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButtonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiSymbolButtonSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiSymbolButtonSave.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiSymbolButtonSave.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.uiSymbolButtonSave.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolButtonSave.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.uiSymbolButtonSave.LightColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.uiSymbolButtonSave.Location = new System.Drawing.Point(108, 3);
            this.uiSymbolButtonSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButtonSave.Name = "uiSymbolButtonSave";
            this.uiSymbolButtonSave.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiSymbolButtonSave.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.uiSymbolButtonSave.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolButtonSave.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolButtonSave.Size = new System.Drawing.Size(99, 35);
            this.uiSymbolButtonSave.Style = Infinite.UI.UIStyle.Custom;
            this.uiSymbolButtonSave.Symbol = 57572;
            this.uiSymbolButtonSave.TabIndex = 146;
            this.uiSymbolButtonSave.Text = "Guardar";
            this.uiSymbolButtonSave.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiSymbolButtonSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // uiTableLayoutPanel2
            // 
            this.uiTableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uiTableLayoutPanel2.ColumnCount = 3;
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.uiTableLayoutPanel2.Controls.Add(this.uiSymbolButtonSave, 1, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.uiSymbolButtonLoad, 0, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.cmbLoadValues, 2, 0);
            this.uiTableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.uiTableLayoutPanel2.Name = "uiTableLayoutPanel2";
            this.uiTableLayoutPanel2.RowCount = 1;
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel2.Size = new System.Drawing.Size(514, 41);
            this.uiTableLayoutPanel2.TabIndex = 0;
            this.uiTableLayoutPanel2.TagString = null;
            // 
            // ControlSaveLoad
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.uiTableLayoutPanel2);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "ControlSaveLoad";
            this.Size = new System.Drawing.Size(794, 41);
            this.uiTableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Infinite.UI.UIComboBox cmbLoadValues;
        private Infinite.UI.UISymbolButton uiSymbolButtonLoad;
        private Infinite.UI.UISymbolButton uiSymbolButtonSave;
        private Infinite.UI.UITableLayoutPanel uiTableLayoutPanel2;
    }
}
