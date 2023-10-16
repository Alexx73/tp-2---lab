
namespace tp_2___lab
{
    partial class FiltroAlojamiento
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
            this.FlpAlojamientos = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelAlojamiento = new System.Windows.Forms.FlowLayoutPanel();
            this.pBox1 = new System.Windows.Forms.PictureBox();
            this.pBox2 = new System.Windows.Forms.PictureBox();
            this.FlpAlojamientos.SuspendLayout();
            this.flowLayoutPanelAlojamiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // FlpAlojamientos
            // 
            this.FlpAlojamientos.Controls.Add(this.label1);
            this.FlpAlojamientos.Controls.Add(this.flowLayoutPanelAlojamiento);
            this.FlpAlojamientos.Controls.Add(this.button1);
            this.FlpAlojamientos.Location = new System.Drawing.Point(0, 0);
            this.FlpAlojamientos.Name = "FlpAlojamientos";
            this.FlpAlojamientos.Size = new System.Drawing.Size(889, 443);
            this.FlpAlojamientos.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alojamientos";
            // 
            // flowLayoutPanelAlojamiento
            // 
            this.flowLayoutPanelAlojamiento.Controls.Add(this.pBox1);
            this.flowLayoutPanelAlojamiento.Controls.Add(this.pBox2);
            this.flowLayoutPanelAlojamiento.Location = new System.Drawing.Point(307, 3);
            this.flowLayoutPanelAlojamiento.Name = "flowLayoutPanelAlojamiento";
            this.flowLayoutPanelAlojamiento.Size = new System.Drawing.Size(248, 415);
            this.flowLayoutPanelAlojamiento.TabIndex = 2;
            // 
            // pBox1
            // 
            this.pBox1.Image = global::tp_2___lab.Properties.Resources.casa_1;
            this.pBox1.Location = new System.Drawing.Point(3, 3);
            this.pBox1.Name = "pBox1";
            this.pBox1.Size = new System.Drawing.Size(200, 100);
            this.pBox1.TabIndex = 3;
            this.pBox1.TabStop = false;
            // 
            // pBox2
            // 
            this.pBox2.Location = new System.Drawing.Point(3, 109);
            this.pBox2.Name = "pBox2";
            this.pBox2.Size = new System.Drawing.Size(200, 100);
            this.pBox2.TabIndex = 4;
            this.pBox2.TabStop = false;
            // 
            // FiltroAlojamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.FlpAlojamientos);
            this.Name = "FiltroAlojamiento";
            this.Size = new System.Drawing.Size(892, 421);
            this.FlpAlojamientos.ResumeLayout(false);
            this.FlpAlojamientos.PerformLayout();
            this.flowLayoutPanelAlojamiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlpAlojamientos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAlojamiento;
        private System.Windows.Forms.PictureBox pBox1;
        private System.Windows.Forms.PictureBox pBox2;
    }
}
