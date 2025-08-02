namespace LibreriaOMBIM
{
    partial class FormatoPlugin
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanelSaveLoad = new System.Windows.Forms.TableLayoutPanel();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.cmbLoadValues = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.TopBorderPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.RightBottomPanel_1 = new System.Windows.Forms.Panel();
            this.RightBottomPanel_2 = new System.Windows.Forms.Panel();
            this.LeftTopPanel_2 = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.RightTopPanel_1 = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelSaveLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TopPanel.Controls.Add(this.tableLayoutPanel1);
            this.TopPanel.Controls.Add(this.tableLayoutPanelSaveLoad);
            this.TopPanel.Controls.Add(this.Titulo);
            this.TopPanel.Controls.Add(this.pictureBox4);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(745, 30);
            this.TopPanel.TabIndex = 42;
            this.TopPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCabeceraOnPaint);
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(659, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(84, 28);
            this.tableLayoutPanel1.TabIndex = 142;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::LibreriaOMBIM.Properties.Resources.Minimiza;
            this.button3.Location = new System.Drawing.Point(3, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 22);
            this.button3.TabIndex = 141;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this._MinButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::LibreriaOMBIM.Properties.Resources.Cierra;
            this.button1.Location = new System.Drawing.Point(59, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
            this.button1.TabIndex = 139;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this._CloseButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::LibreriaOMBIM.Properties.Resources.Maximiza;
            this.button2.Location = new System.Drawing.Point(31, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 22);
            this.button2.TabIndex = 140;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this._MaxButton_Click);
            // 
            // tableLayoutPanelSaveLoad
            // 
            this.tableLayoutPanelSaveLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelSaveLoad.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelSaveLoad.ColumnCount = 3;
            this.tableLayoutPanelSaveLoad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanelSaveLoad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanelSaveLoad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelSaveLoad.Controls.Add(this.buttonLoad, 0, 0);
            this.tableLayoutPanelSaveLoad.Controls.Add(this.cmbLoadValues, 2, 0);
            this.tableLayoutPanelSaveLoad.Controls.Add(this.buttonSave, 1, 0);
            this.tableLayoutPanelSaveLoad.Location = new System.Drawing.Point(477, 1);
            this.tableLayoutPanelSaveLoad.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelSaveLoad.Name = "tableLayoutPanelSaveLoad";
            this.tableLayoutPanelSaveLoad.RowCount = 1;
            this.tableLayoutPanelSaveLoad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanelSaveLoad.Size = new System.Drawing.Size(175, 28);
            this.tableLayoutPanelSaveLoad.TabIndex = 46;
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.Transparent;
            this.buttonLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLoad.FlatAppearance.BorderSize = 0;
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoad.Image = global::LibreriaOMBIM.Properties.Resources.Carga;
            this.buttonLoad.Location = new System.Drawing.Point(3, 3);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(22, 22);
            this.buttonLoad.TabIndex = 139;
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.btnLoad_Click);
            this.buttonLoad.MouseEnter += new System.EventHandler(this.buttonLoad_MouseEnter);
            this.buttonLoad.MouseLeave += new System.EventHandler(this.buttonLoad_MouseLeave);
            // 
            // cmbLoadValues
            // 
            this.cmbLoadValues.BackColor = System.Drawing.SystemColors.Window;
            this.cmbLoadValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbLoadValues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLoadValues.FormattingEnabled = true;
            this.cmbLoadValues.Items.AddRange(new object[] {
            "standard"});
            this.cmbLoadValues.Location = new System.Drawing.Point(59, 3);
            this.cmbLoadValues.Name = "cmbLoadValues";
            this.cmbLoadValues.Size = new System.Drawing.Size(113, 21);
            this.cmbLoadValues.TabIndex = 44;
            this.cmbLoadValues.DropDown += new System.EventHandler(this.cmbLoadValues_DropDown);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Image = global::LibreriaOMBIM.Properties.Resources.Guarda;
            this.buttonSave.Location = new System.Drawing.Point(31, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(22, 22);
            this.buttonSave.TabIndex = 138;
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.btnSave_Click);
            this.buttonSave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonSave_MouseClick);
            this.buttonSave.MouseEnter += new System.EventHandler(this.buttonSave_MouseEnter);
            this.buttonSave.MouseLeave += new System.EventHandler(this.buttonSave_MouseLeave);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Titulo.Location = new System.Drawing.Point(31, 6);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(41, 19);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "Form";
            this.Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowTextLabel_MouseDown);
            this.Titulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowTextLabel_MouseMove);
            this.Titulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowTextLabel_MouseUp);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Location = new System.Drawing.Point(5, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(21, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowTextLabel_MouseDown);
            this.pictureBox4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowTextLabel_MouseMove);
            this.pictureBox4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowTextLabel_MouseUp);
            // 
            // TopBorderPanel
            // 
            this.TopBorderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopBorderPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TopBorderPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.TopBorderPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBorderPanel.Name = "TopBorderPanel";
            this.TopBorderPanel.Size = new System.Drawing.Size(745, 2);
            this.TopBorderPanel.TabIndex = 40;
            this.TopBorderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaintBordeCabecera);
            // 
            // RightPanel
            // 
            this.RightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.RightPanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.RightPanel.Location = new System.Drawing.Point(743, 30);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(2, 381);
            this.RightPanel.TabIndex = 39;
            this.RightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.RightPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseDown);
            this.RightPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseMove);
            this.RightPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightPanel_MouseUp);
            // 
            // LeftPanel
            // 
            this.LeftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LeftPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.LeftPanel.Location = new System.Drawing.Point(0, 30);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(2, 411);
            this.LeftPanel.TabIndex = 38;
            this.LeftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            // 
            // RightBottomPanel_1
            // 
            this.RightBottomPanel_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RightBottomPanel_1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.RightBottomPanel_1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.RightBottomPanel_1.Location = new System.Drawing.Point(715, 439);
            this.RightBottomPanel_1.Name = "RightBottomPanel_1";
            this.RightBottomPanel_1.Size = new System.Drawing.Size(30, 2);
            this.RightBottomPanel_1.TabIndex = 36;
            this.RightBottomPanel_1.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.RightBottomPanel_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_1_MouseDown);
            this.RightBottomPanel_1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_1_MouseMove);
            this.RightBottomPanel_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_1_MouseUp);
            // 
            // RightBottomPanel_2
            // 
            this.RightBottomPanel_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RightBottomPanel_2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.RightBottomPanel_2.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.RightBottomPanel_2.Location = new System.Drawing.Point(743, 411);
            this.RightBottomPanel_2.Name = "RightBottomPanel_2";
            this.RightBottomPanel_2.Size = new System.Drawing.Size(2, 30);
            this.RightBottomPanel_2.TabIndex = 35;
            this.RightBottomPanel_2.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.RightBottomPanel_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_2_MouseDown);
            this.RightBottomPanel_2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_2_MouseMove);
            this.RightBottomPanel_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightBottomPanel_2_MouseUp);
            // 
            // LeftTopPanel_2
            // 
            this.LeftTopPanel_2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LeftTopPanel_2.Cursor = System.Windows.Forms.Cursors.Default;
            this.LeftTopPanel_2.Location = new System.Drawing.Point(0, 0);
            this.LeftTopPanel_2.Name = "LeftTopPanel_2";
            this.LeftTopPanel_2.Size = new System.Drawing.Size(2, 30);
            this.LeftTopPanel_2.TabIndex = 30;
            this.LeftTopPanel_2.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaintBordeCabecera);
            // 
            // BottomPanel
            // 
            this.BottomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BottomPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BottomPanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.BottomPanel.Location = new System.Drawing.Point(0, 439);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(715, 2);
            this.BottomPanel.TabIndex = 37;
            this.BottomPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.BottomPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseDown);
            this.BottomPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseMove);
            this.BottomPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseUp);
            // 
            // RightTopPanel_1
            // 
            this.RightTopPanel_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RightTopPanel_1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.RightTopPanel_1.Cursor = System.Windows.Forms.Cursors.Default;
            this.RightTopPanel_1.Location = new System.Drawing.Point(743, 0);
            this.RightTopPanel_1.Name = "RightTopPanel_1";
            this.RightTopPanel_1.Size = new System.Drawing.Size(2, 30);
            this.RightTopPanel_1.TabIndex = 31;
            this.RightTopPanel_1.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaintBordeCabecera);
            // 
            // FormatoPlugin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TopBorderPanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.RightBottomPanel_1);
            this.Controls.Add(this.RightBottomPanel_2);
            this.Controls.Add(this.RightTopPanel_1);
            this.Controls.Add(this.LeftTopPanel_2);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FormatoPlugin";
            this.Size = new System.Drawing.Size(745, 441);
            this.Load += new System.EventHandler(this.FormatoPlugin_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanelSaveLoad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel TopBorderPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel RightBottomPanel_1;
        private System.Windows.Forms.Panel RightBottomPanel_2;
        private System.Windows.Forms.Panel LeftTopPanel_2;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel RightTopPanel_1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSaveLoad;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.ComboBox cmbLoadValues;
    }
}
