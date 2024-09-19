namespace ejemploWinFormsDateTime
{
    partial class Form1
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
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.calFecha = new System.Windows.Forms.MonthCalendar();
            this.btn1Fecha = new System.Windows.Forms.Button();
            this.btn2Fecha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(211, 60);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 22);
            this.dtpFecha.TabIndex = 0;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // calFecha
            // 
            this.calFecha.Location = new System.Drawing.Point(167, 119);
            this.calFecha.Name = "calFecha";
            this.calFecha.TabIndex = 1;
            // 
            // btn1Fecha
            // 
            this.btn1Fecha.Location = new System.Drawing.Point(529, 59);
            this.btn1Fecha.Name = "btn1Fecha";
            this.btn1Fecha.Size = new System.Drawing.Size(75, 23);
            this.btn1Fecha.TabIndex = 2;
            this.btn1Fecha.Text = "Fecha 1";
            this.btn1Fecha.UseVisualStyleBackColor = true;
            this.btn1Fecha.Click += new System.EventHandler(this.btn1Fecha_Click);
            // 
            // btn2Fecha
            // 
            this.btn2Fecha.Location = new System.Drawing.Point(529, 119);
            this.btn2Fecha.Name = "btn2Fecha";
            this.btn2Fecha.Size = new System.Drawing.Size(75, 23);
            this.btn2Fecha.TabIndex = 3;
            this.btn2Fecha.Text = "Fecha 2";
            this.btn2Fecha.UseVisualStyleBackColor = true;
            this.btn2Fecha.Click += new System.EventHandler(this.btn2Fecha_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn2Fecha);
            this.Controls.Add(this.btn1Fecha);
            this.Controls.Add(this.calFecha);
            this.Controls.Add(this.dtpFecha);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.MonthCalendar calFecha;
        private System.Windows.Forms.Button btn1Fecha;
        private System.Windows.Forms.Button btn2Fecha;
    }
}

