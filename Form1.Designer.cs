
namespace tp_2___lab
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAlojamientos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnReservas);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnAlojamientos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnAlojamientos
            // 
            this.btnAlojamientos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAlojamientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlojamientos.Location = new System.Drawing.Point(0, 50);
            this.btnAlojamientos.Name = "btnAlojamientos";
            this.btnAlojamientos.Size = new System.Drawing.Size(200, 61);
            this.btnAlojamientos.TabIndex = 0;
            this.btnAlojamientos.Text = "Alojamientos";
            this.btnAlojamientos.UseVisualStyleBackColor = false;
            this.btnAlojamientos.Click += new System.EventHandler(this.btnAlojamientos_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(-3, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 61);
            this.button1.TabIndex = 1;
            this.button1.Text = "CLIENTES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReservas
            // 
            this.btnReservas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservas.Location = new System.Drawing.Point(0, 184);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(200, 61);
            this.btnReservas.TabIndex = 2;
            this.btnReservas.Text = "RESERVAS";
            this.btnReservas.UseVisualStyleBackColor = false;
            this.btnReservas.Click += new System.EventHandler(this.btnReservas_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(203, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.SandyBrown;
            this.panelContenedor.Location = new System.Drawing.Point(206, 3);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(799, 435);
            this.panelContenedor.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 450);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Sistema de Reservas";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAlojamientos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelContenedor;
    }
}

