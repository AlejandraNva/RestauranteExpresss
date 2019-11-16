namespace Restaurante_Express
{
    partial class Empleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grdatospersonales = new System.Windows.Forms.GroupBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lbedad = new System.Windows.Forms.Label();
            this.lbapellidos = new System.Windows.Forms.Label();
            this.lbnombre = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnregresar = new System.Windows.Forms.Button();
            this.cbempleados = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbocupacion = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grdatospersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // grdatospersonales
            // 
            this.grdatospersonales.Controls.Add(this.txtapellidos);
            this.grdatospersonales.Controls.Add(this.txtnombre);
            this.grdatospersonales.Controls.Add(this.txtedad);
            this.grdatospersonales.Controls.Add(this.txtid);
            this.grdatospersonales.Controls.Add(this.lbedad);
            this.grdatospersonales.Controls.Add(this.lbapellidos);
            this.grdatospersonales.Controls.Add(this.lbnombre);
            this.grdatospersonales.Controls.Add(this.lbid);
            this.grdatospersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.grdatospersonales.Location = new System.Drawing.Point(14, 12);
            this.grdatospersonales.Name = "grdatospersonales";
            this.grdatospersonales.Size = new System.Drawing.Size(413, 224);
            this.grdatospersonales.TabIndex = 0;
            this.grdatospersonales.TabStop = false;
            this.grdatospersonales.Text = "Datos Personales";
            this.grdatospersonales.Enter += new System.EventHandler(this.grdatospersonales_Enter);
            // 
            // txtapellidos
            // 
            this.txtapellidos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapellidos.Location = new System.Drawing.Point(118, 144);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(255, 22);
            this.txtapellidos.TabIndex = 11;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(118, 102);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(174, 22);
            this.txtnombre.TabIndex = 10;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(118, 61);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(116, 22);
            this.txtedad.TabIndex = 9;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(118, 33);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(116, 22);
            this.txtid.TabIndex = 6;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // lbedad
            // 
            this.lbedad.AutoSize = true;
            this.lbedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbedad.Location = new System.Drawing.Point(26, 61);
            this.lbedad.Name = "lbedad";
            this.lbedad.Size = new System.Drawing.Size(61, 20);
            this.lbedad.TabIndex = 3;
            this.lbedad.Text = "Edad :";
            // 
            // lbapellidos
            // 
            this.lbapellidos.AutoSize = true;
            this.lbapellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbapellidos.Location = new System.Drawing.Point(26, 139);
            this.lbapellidos.Name = "lbapellidos";
            this.lbapellidos.Size = new System.Drawing.Size(92, 20);
            this.lbapellidos.TabIndex = 2;
            this.lbapellidos.Text = "Apellidos :";
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombre.Location = new System.Drawing.Point(26, 102);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(81, 20);
            this.lbnombre.TabIndex = 1;
            this.lbnombre.Text = "Nombre :";
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbid.Location = new System.Drawing.Point(26, 28);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(38, 20);
            this.lbid.TabIndex = 0;
            this.lbid.Text = "ID :";
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(518, 23);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(106, 49);
            this.btnagregar.TabIndex = 2;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(518, 96);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(106, 38);
            this.btnmodificar.TabIndex = 3;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(711, 23);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(105, 49);
            this.btneliminar.TabIndex = 4;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(518, 170);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(106, 40);
            this.btnbuscar.TabIndex = 5;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnregresar
            // 
            this.btnregresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.Location = new System.Drawing.Point(711, 101);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(105, 48);
            this.btnregresar.TabIndex = 8;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // cbempleados
            // 
            this.cbempleados.FormattingEnabled = true;
            this.cbempleados.Items.AddRange(new object[] {
            "Administrador",
            "Cocinero",
            "Cajero"});
            this.cbempleados.Location = new System.Drawing.Point(711, 215);
            this.cbempleados.Name = "cbempleados";
            this.cbempleados.Size = new System.Drawing.Size(121, 21);
            this.cbempleados.TabIndex = 9;
            this.cbempleados.SelectedIndexChanged += new System.EventHandler(this.cbempleados_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(241, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(575, 121);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick_1);
            // 
            // lbocupacion
            // 
            this.lbocupacion.AutoSize = true;
            this.lbocupacion.Location = new System.Drawing.Point(731, 180);
            this.lbocupacion.Name = "lbocupacion";
            this.lbocupacion.Size = new System.Drawing.Size(85, 13);
            this.lbocupacion.TabIndex = 12;
            this.lbocupacion.Text = "Ocupaciones:";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(44, 307);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(164, 20);
            this.txtbuscar.TabIndex = 12;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(860, 388);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.lbocupacion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbempleados);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.grdatospersonales);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grdatospersonales.ResumeLayout(false);
            this.grdatospersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.GroupBox grdatospersonales;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lbedad;
        private System.Windows.Forms.Label lbapellidos;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.ComboBox cbempleados;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbocupacion;
        private System.Windows.Forms.TextBox txtbuscar;
    }
}