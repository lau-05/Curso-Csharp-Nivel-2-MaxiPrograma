namespace Discos_DB
{
    partial class frmDiscos
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
            this.dgvDiscos = new System.Windows.Forms.DataGridView();
            this.pbDiscos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDiscos
            // 
            this.dgvDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscos.Location = new System.Drawing.Point(22, 34);
            this.dgvDiscos.Name = "dgvDiscos";
            this.dgvDiscos.RowHeadersWidth = 51;
            this.dgvDiscos.RowTemplate.Height = 24;
            this.dgvDiscos.Size = new System.Drawing.Size(827, 350);
            this.dgvDiscos.TabIndex = 0;
            this.dgvDiscos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiscos_CellContentClick);
            this.dgvDiscos.SelectionChanged += new System.EventHandler(this.dgvDiscos_SelectionChanged);
            // 
            // pbDiscos
            // 
            this.pbDiscos.Location = new System.Drawing.Point(866, 34);
            this.pbDiscos.Name = "pbDiscos";
            this.pbDiscos.Size = new System.Drawing.Size(367, 350);
            this.pbDiscos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDiscos.TabIndex = 1;
            this.pbDiscos.TabStop = false;
            this.pbDiscos.Click += new System.EventHandler(this.pbDiscos_Click);
            // 
            // frmDiscos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 462);
            this.Controls.Add(this.pbDiscos);
            this.Controls.Add(this.dgvDiscos);
            this.Name = "frmDiscos";
            this.Text = "Discos";
            this.Load += new System.EventHandler(this.frmDiscos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiscos;
        private System.Windows.Forms.PictureBox pbDiscos;
    }
}

