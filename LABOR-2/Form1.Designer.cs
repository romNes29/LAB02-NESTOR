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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistrarTrabajador
            // 
            this.btnRegistrarTrabajador.Location = new System.Drawing.Point(65, 48);
            this.btnRegistrarTrabajador.Name = "btnRegistrarTrabajador";
            this.btnRegistrarTrabajador.Size = new System.Drawing.Size(130, 52);
            this.btnRegistrarTrabajador.TabIndex = 0;
            this.btnRegistrarTrabajador.Text = "Registrar Trabajador";
            this.btnRegistrarTrabajador.UseVisualStyleBackColor = true;
            this.btnRegistrarTrabajador.Click += new System.EventHandler(this.btnRegistrarTrabajador_Click);
            // 
            // btnDatosPlanilla
            // 
            this.btnDatosPlanilla.Location = new System.Drawing.Point(65, 125);
            this.btnDatosPlanilla.Name = "btnDatosPlanilla";
            this.btnDatosPlanilla.Size = new System.Drawing.Size(130, 52);
            this.btnDatosPlanilla.TabIndex = 1;
            this.btnDatosPlanilla.Text = "Mostrar Datos De Empleado";
            this.btnDatosPlanilla.UseVisualStyleBackColor = true;
            this.btnDatosPlanilla.Click += new System.EventHandler(this.btnDatosPlanilla_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Registrar Dueño";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Opciones Principales";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 302);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDatosPlanilla);
            this.Controls.Add(this.btnRegistrarTrabajador);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarTrabajador;
        private System.Windows.Forms.Button btnDatosPlanilla;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

