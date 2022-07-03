namespace LABOR_2
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
            this.btnRegistrarTrabajador = new System.Windows.Forms.Button();
            this.btnDatosPlanilla = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrarTrabajador
            // 
            this.btnRegistrarTrabajador.Location = new System.Drawing.Point(143, 58);
            this.btnRegistrarTrabajador.Name = "btnRegistrarTrabajador";
            this.btnRegistrarTrabajador.Size = new System.Drawing.Size(130, 52);
            this.btnRegistrarTrabajador.TabIndex = 0;
            this.btnRegistrarTrabajador.Text = "RegistrarTrabajador";
            this.btnRegistrarTrabajador.UseVisualStyleBackColor = true;
            this.btnRegistrarTrabajador.Click += new System.EventHandler(this.btnRegistrarTrabajador_Click);
            // 
            // btnDatosPlanilla
            // 
            this.btnDatosPlanilla.Location = new System.Drawing.Point(330, 58);
            this.btnDatosPlanilla.Name = "btnDatosPlanilla";
            this.btnDatosPlanilla.Size = new System.Drawing.Size(130, 52);
            this.btnDatosPlanilla.TabIndex = 1;
            this.btnDatosPlanilla.Text = "RegistrarTrabajador";
            this.btnDatosPlanilla.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(498, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "RegistrarTrabajador";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDatosPlanilla);
            this.Controls.Add(this.btnRegistrarTrabajador);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarTrabajador;
        private System.Windows.Forms.Button btnDatosPlanilla;
        private System.Windows.Forms.Button button2;
    }
}

