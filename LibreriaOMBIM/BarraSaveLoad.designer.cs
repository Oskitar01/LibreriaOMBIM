namespace LibreriaOMBIM
{
    partial class BarraSaveLoad
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
            this.controlSaveLoad1 = new LibreriaOMBIM.ControlSaveLoad();
            this.SuspendLayout();
            // 
            // controlSaveLoad1
            // 
            this.controlSaveLoad1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlSaveLoad1.BackColor = System.Drawing.Color.Transparent;
            this.controlSaveLoad1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.controlSaveLoad1.Location = new System.Drawing.Point(3, 7);
            this.controlSaveLoad1.Name = "controlSaveLoad1";
            this.controlSaveLoad1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.controlSaveLoad1.Size = new System.Drawing.Size(543, 26);
            this.controlSaveLoad1.TabIndex = 48;
            this.controlSaveLoad1.Click += new System.EventHandler(this.pnlSaveLoad_Click);
            this.controlSaveLoad1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSaveLoad_MouseDown);
            this.controlSaveLoad1.MouseEnter += new System.EventHandler(this.pnlSaveLoad_MouseEnter);
            this.controlSaveLoad1.MouseLeave += new System.EventHandler(this.pnlSaveLoad_MouseLeave);
            // 
            // BarraSaveLoad
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.controlSaveLoad1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BarraSaveLoad";
            this.Size = new System.Drawing.Size(549, 6);
            this.Click += new System.EventHandler(this.pnlSaveLoad_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSaveLoad_MouseDown);
            this.MouseEnter += new System.EventHandler(this.pnlSaveLoad_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.pnlSaveLoad_MouseLeave);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlSaveLoad controlSaveLoad1;
    }
}
