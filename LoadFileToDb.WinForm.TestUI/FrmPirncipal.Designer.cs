namespace LoadFileToDb.WinForm.TestUI
{
    partial class FrmPirncipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPirncipal));
            this.ucFileToProcess = new CommonUtils.WinCompTb.UCSelectedFile();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlsStrBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.tlsStrBtnProcess = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucFileToProcess
            // 
            this.ucFileToProcess.Location = new System.Drawing.Point(13, 35);
            this.ucFileToProcess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucFileToProcess.Name = "ucFileToProcess";
            this.ucFileToProcess.Size = new System.Drawing.Size(629, 172);
            this.ucFileToProcess.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsStrBtnSalir,
            this.tlsStrBtnProcess});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(662, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlsStrBtnSalir
            // 
            this.tlsStrBtnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsStrBtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("tlsStrBtnSalir.Image")));
            this.tlsStrBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsStrBtnSalir.Name = "tlsStrBtnSalir";
            this.tlsStrBtnSalir.Size = new System.Drawing.Size(23, 22);
            this.tlsStrBtnSalir.Text = "toolStripButton1";
            this.tlsStrBtnSalir.ToolTipText = "Salir";
            this.tlsStrBtnSalir.Click += new System.EventHandler(this.tlsStrBtnSalir_Click);
            // 
            // tlsStrBtnProcess
            // 
            this.tlsStrBtnProcess.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsStrBtnProcess.Image = ((System.Drawing.Image)(resources.GetObject("tlsStrBtnProcess.Image")));
            this.tlsStrBtnProcess.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsStrBtnProcess.Name = "tlsStrBtnProcess";
            this.tlsStrBtnProcess.Size = new System.Drawing.Size(23, 22);
            this.tlsStrBtnProcess.Text = "toolStripButton2";
            this.tlsStrBtnProcess.ToolTipText = "Process";
            this.tlsStrBtnProcess.Click += new System.EventHandler(this.tlsStrBtnProcess_Click);
            // 
            // FrmPirncipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 231);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ucFileToProcess);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPirncipal";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CommonUtils.WinCompTb.UCSelectedFile ucFileToProcess;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlsStrBtnSalir;
        private System.Windows.Forms.ToolStripButton tlsStrBtnProcess;
    }
}

