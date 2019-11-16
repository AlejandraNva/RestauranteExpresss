namespace Restaurante_Express
{
    partial class FormRestaurante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRestaurante));
            this.pbempleados = new System.Windows.Forms.PictureBox();
            this.pbbebidas = new System.Windows.Forms.PictureBox();
            this.pbplatillos = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbempleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbebidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbplatillos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbempleados
            // 
            this.pbempleados.Image = ((System.Drawing.Image)(resources.GetObject("pbempleados.Image")));
            this.pbempleados.Location = new System.Drawing.Point(59, 92);
            this.pbempleados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbempleados.Name = "pbempleados";
            this.pbempleados.Size = new System.Drawing.Size(301, 352);
            this.pbempleados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbempleados.TabIndex = 0;
            this.pbempleados.TabStop = false;
            this.pbempleados.Click += new System.EventHandler(this.pbempleados_Click);
            // 
            // pbbebidas
            // 
            this.pbbebidas.Image = ((System.Drawing.Image)(resources.GetObject("pbbebidas.Image")));
            this.pbbebidas.Location = new System.Drawing.Point(417, 92);
            this.pbbebidas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbbebidas.Name = "pbbebidas";
            this.pbbebidas.Size = new System.Drawing.Size(279, 352);
            this.pbbebidas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbbebidas.TabIndex = 1;
            this.pbbebidas.TabStop = false;
            this.pbbebidas.Click += new System.EventHandler(this.pbbebidas_Click);
            // 
            // pbplatillos
            // 
            this.pbplatillos.Image = ((System.Drawing.Image)(resources.GetObject("pbplatillos.Image")));
            this.pbplatillos.Location = new System.Drawing.Point(747, 92);
            this.pbplatillos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbplatillos.Name = "pbplatillos";
            this.pbplatillos.Size = new System.Drawing.Size(283, 352);
            this.pbplatillos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbplatillos.TabIndex = 2;
            this.pbplatillos.TabStop = false;
            this.pbplatillos.Click += new System.EventHandler(this.pbplatillos_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(726, 36);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(304, 22);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1079, 92);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 352);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1375, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pbplatillos);
            this.Controls.Add(this.pbbebidas);
            this.Controls.Add(this.pbempleados);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormRestaurante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurante Express";
            this.Load += new System.EventHandler(this.FormRestaurante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbempleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbebidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbplatillos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbempleados;
        private System.Windows.Forms.PictureBox pbbebidas;
        private System.Windows.Forms.PictureBox pbplatillos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

