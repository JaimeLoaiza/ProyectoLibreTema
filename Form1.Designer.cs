namespace ProyectoDGVLibreTema
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.lblpais = new System.Windows.Forms.Label();
            this.lblciudad = new System.Windows.Forms.Label();
            this.lblbarrio = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtpais = new System.Windows.Forms.TextBox();
            this.txtciudad = new System.Windows.Forms.TextBox();
            this.txtbarrio = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.dgvlista = new System.Windows.Forms.DataGridView();
            this.btnagregarguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(251, 31);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(150, 24);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "LISTA EN DGV";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(19, 109);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(60, 13);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "NOMBRE";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapellido.Location = new System.Drawing.Point(19, 144);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(67, 13);
            this.lblapellido.TabIndex = 2;
            this.lblapellido.Text = "APELLIDO";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbledad.Location = new System.Drawing.Point(19, 179);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(41, 13);
            this.lbledad.TabIndex = 3;
            this.lbledad.Text = "EDAD";
            // 
            // lblpais
            // 
            this.lblpais.AutoSize = true;
            this.lblpais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpais.Location = new System.Drawing.Point(19, 214);
            this.lblpais.Name = "lblpais";
            this.lblpais.Size = new System.Drawing.Size(35, 13);
            this.lblpais.TabIndex = 4;
            this.lblpais.Text = "PAÍS";
            // 
            // lblciudad
            // 
            this.lblciudad.AutoSize = true;
            this.lblciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblciudad.Location = new System.Drawing.Point(19, 249);
            this.lblciudad.Name = "lblciudad";
            this.lblciudad.Size = new System.Drawing.Size(54, 13);
            this.lblciudad.TabIndex = 5;
            this.lblciudad.Text = "CIUDAD";
            // 
            // lblbarrio
            // 
            this.lblbarrio.AutoSize = true;
            this.lblbarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbarrio.Location = new System.Drawing.Point(19, 284);
            this.lblbarrio.Name = "lblbarrio";
            this.lblbarrio.Size = new System.Drawing.Size(54, 13);
            this.lblbarrio.TabIndex = 6;
            this.lblbarrio.Text = "BARRIO";
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccion.Location = new System.Drawing.Point(19, 320);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(75, 13);
            this.lbldireccion.TabIndex = 7;
            this.lbldireccion.Text = "DIRECCION";
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono.Location = new System.Drawing.Point(19, 355);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(72, 13);
            this.lbltelefono.TabIndex = 8;
            this.lbltelefono.Text = "TELEFONO";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(100, 106);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 9;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(100, 141);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 20);
            this.txtapellido.TabIndex = 10;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(100, 176);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 20);
            this.txtedad.TabIndex = 11;
            // 
            // txtpais
            // 
            this.txtpais.Location = new System.Drawing.Point(100, 211);
            this.txtpais.Name = "txtpais";
            this.txtpais.Size = new System.Drawing.Size(100, 20);
            this.txtpais.TabIndex = 12;
            // 
            // txtciudad
            // 
            this.txtciudad.Location = new System.Drawing.Point(100, 246);
            this.txtciudad.Name = "txtciudad";
            this.txtciudad.Size = new System.Drawing.Size(100, 20);
            this.txtciudad.TabIndex = 13;
            // 
            // txtbarrio
            // 
            this.txtbarrio.Location = new System.Drawing.Point(100, 281);
            this.txtbarrio.Name = "txtbarrio";
            this.txtbarrio.Size = new System.Drawing.Size(100, 20);
            this.txtbarrio.TabIndex = 14;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(100, 317);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(100, 20);
            this.txtdireccion.TabIndex = 15;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(100, 352);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 20);
            this.txttelefono.TabIndex = 16;
            // 
            // dgvlista
            // 
            this.dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlista.Location = new System.Drawing.Point(211, 76);
            this.dgvlista.Name = "dgvlista";
            this.dgvlista.Size = new System.Drawing.Size(374, 319);
            this.dgvlista.TabIndex = 17;
            // 
            // btnagregarguardar
            // 
            this.btnagregarguardar.BackColor = System.Drawing.Color.Bisque;
            this.btnagregarguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregarguardar.Location = new System.Drawing.Point(91, 412);
            this.btnagregarguardar.Name = "btnagregarguardar";
            this.btnagregarguardar.Size = new System.Drawing.Size(119, 37);
            this.btnagregarguardar.TabIndex = 18;
            this.btnagregarguardar.Text = "AGREGAR O GUARDAR";
            this.btnagregarguardar.UseVisualStyleBackColor = false;
            this.btnagregarguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.Bisque;
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Location = new System.Drawing.Point(216, 412);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(119, 37);
            this.btnnuevo.TabIndex = 19;
            this.btnnuevo.Text = "NUEVO";
            this.btnnuevo.UseVisualStyleBackColor = false;
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.Bisque;
            this.btnmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(341, 412);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(119, 37);
            this.btnmodificar.TabIndex = 20;
            this.btnmodificar.Text = "MODIFICAR";
            this.btnmodificar.UseVisualStyleBackColor = false;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Bisque;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(466, 412);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(119, 37);
            this.btneliminar.TabIndex = 21;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = false;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Chartreuse;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(507, 455);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 22;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 486);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnagregarguardar);
            this.Controls.Add(this.dgvlista);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtbarrio);
            this.Controls.Add(this.txtciudad);
            this.Controls.Add(this.txtpais);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.lblbarrio);
            this.Controls.Add(this.lblciudad);
            this.Controls.Add(this.lblpais);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblapellido;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lblpais;
        private System.Windows.Forms.Label lblciudad;
        private System.Windows.Forms.Label lblbarrio;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtpais;
        private System.Windows.Forms.TextBox txtciudad;
        private System.Windows.Forms.TextBox txtbarrio;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.DataGridView dgvlista;
        private System.Windows.Forms.Button btnagregarguardar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnsalir;
    }
}

