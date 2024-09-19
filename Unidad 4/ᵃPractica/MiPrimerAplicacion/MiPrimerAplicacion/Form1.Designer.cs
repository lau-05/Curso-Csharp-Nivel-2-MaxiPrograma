namespace MiPrimerAplicacion
{
    partial class principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            this.btn = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn.Location = new System.Drawing.Point(127, 28);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(115, 30);
            this.btn.TabIndex = 0;
            this.btn.Text = "Pulse aquí";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(50, 34);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(60, 17);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Etiqueta";
            // 
            // tb
            // 
            this.tb.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tb.Location = new System.Drawing.Point(127, 89);
            this.tb.MaxLength = 10000;
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(115, 22);
            this.tb.TabIndex = 2;
            this.tb.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(127, 143);
            this.tb2.Multiline = true;
            this.tb2.Name = "tb2";
            this.tb2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb2.Size = new System.Drawing.Size(115, 22);
            this.tb2.TabIndex = 3;
            this.tb2.Leave += new System.EventHandler(this.tb2_Leave);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btn);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "principal";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.principal_FormClosed);
            this.Load += new System.EventHandler(this.principal_Load);
            this.Click += new System.EventHandler(this.principal_Click);
            this.MouseLeave += new System.EventHandler(this.principal_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.principal_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.TextBox tb2;
    }
}

