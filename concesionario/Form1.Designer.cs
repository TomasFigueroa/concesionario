namespace concesionario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Bt_agregar = new System.Windows.Forms.Button();
            this.Bt_buscar = new System.Windows.Forms.Button();
            this.Bt_borrar = new System.Windows.Forms.Button();
            this.Txt_patente = new System.Windows.Forms.TextBox();
            this.Txt_modelo = new System.Windows.Forms.TextBox();
            this.Txt_Marca = new System.Windows.Forms.TextBox();
            this.Txt_año = new System.Windows.Forms.TextBox();
            this.Patente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Bt_stock = new System.Windows.Forms.Button();
            this.dgautos = new System.Windows.Forms.DataGridView();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_disponible = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_Modificar = new System.Windows.Forms.Button();
            this.Bt_aceptar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.errorA = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgautos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // Bt_agregar
            // 
            this.Bt_agregar.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_agregar.Location = new System.Drawing.Point(45, 99);
            this.Bt_agregar.Name = "Bt_agregar";
            this.Bt_agregar.Size = new System.Drawing.Size(89, 36);
            this.Bt_agregar.TabIndex = 0;
            this.Bt_agregar.Text = "Agregar";
            this.Bt_agregar.UseVisualStyleBackColor = true;
            this.Bt_agregar.Click += new System.EventHandler(this.Bt_agregar_Click);
            // 
            // Bt_buscar
            // 
            this.Bt_buscar.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_buscar.Location = new System.Drawing.Point(45, 161);
            this.Bt_buscar.Name = "Bt_buscar";
            this.Bt_buscar.Size = new System.Drawing.Size(89, 33);
            this.Bt_buscar.TabIndex = 1;
            this.Bt_buscar.Text = "Buscar";
            this.Bt_buscar.UseVisualStyleBackColor = true;
            this.Bt_buscar.Click += new System.EventHandler(this.Bt_buscar_Click);
            // 
            // Bt_borrar
            // 
            this.Bt_borrar.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_borrar.Location = new System.Drawing.Point(45, 220);
            this.Bt_borrar.Name = "Bt_borrar";
            this.Bt_borrar.Size = new System.Drawing.Size(89, 33);
            this.Bt_borrar.TabIndex = 2;
            this.Bt_borrar.Text = "Borrar";
            this.Bt_borrar.UseVisualStyleBackColor = true;
            this.Bt_borrar.Click += new System.EventHandler(this.Bt_borrar_Click);
            // 
            // Txt_patente
            // 
            this.Txt_patente.Location = new System.Drawing.Point(140, 54);
            this.Txt_patente.MaxLength = 7;
            this.Txt_patente.Name = "Txt_patente";
            this.Txt_patente.Size = new System.Drawing.Size(100, 22);
            this.Txt_patente.TabIndex = 3;
            // 
            // Txt_modelo
            // 
            this.Txt_modelo.Location = new System.Drawing.Point(247, 54);
            this.Txt_modelo.MaxLength = 10;
            this.Txt_modelo.Name = "Txt_modelo";
            this.Txt_modelo.Size = new System.Drawing.Size(100, 22);
            this.Txt_modelo.TabIndex = 4;
            // 
            // Txt_Marca
            // 
            this.Txt_Marca.Location = new System.Drawing.Point(363, 54);
            this.Txt_Marca.MaxLength = 10;
            this.Txt_Marca.Name = "Txt_Marca";
            this.Txt_Marca.Size = new System.Drawing.Size(100, 22);
            this.Txt_Marca.TabIndex = 5;
            // 
            // Txt_año
            // 
            this.Txt_año.Location = new System.Drawing.Point(469, 54);
            this.Txt_año.MaxLength = 4;
            this.Txt_año.Name = "Txt_año";
            this.Txt_año.Size = new System.Drawing.Size(100, 22);
            this.Txt_año.TabIndex = 6;
            // 
            // Patente
            // 
            this.Patente.AutoSize = true;
            this.Patente.BackColor = System.Drawing.Color.Transparent;
            this.Patente.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patente.Location = new System.Drawing.Point(135, 25);
            this.Patente.Name = "Patente";
            this.Patente.Size = new System.Drawing.Size(84, 28);
            this.Patente.TabIndex = 7;
            this.Patente.Text = "Patente";
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(464, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Año";
            // 
            // Bt_stock
            // 
            this.Bt_stock.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_stock.Location = new System.Drawing.Point(26, 347);
            this.Bt_stock.Name = "Bt_stock";
            this.Bt_stock.Size = new System.Drawing.Size(108, 68);
            this.Bt_stock.TabIndex = 11;
            this.Bt_stock.Text = "Datos de Compras";
            this.Bt_stock.UseVisualStyleBackColor = true;
            this.Bt_stock.Click += new System.EventHandler(this.Bt_stock_Click);
            // 
            // dgautos
            // 
            this.dgautos.AllowUserToAddRows = false;
            this.dgautos.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgautos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgautos.Location = new System.Drawing.Point(140, 99);
            this.dgautos.Name = "dgautos";
            this.dgautos.RowHeadersWidth = 51;
            this.dgautos.RowTemplate.Height = 24;
            this.dgautos.Size = new System.Drawing.Size(875, 446);
            this.dgautos.TabIndex = 12;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(609, 54);
            this.txt_precio.MaxLength = 10;
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(100, 22);
            this.txt_precio.TabIndex = 13;
            // 
            // txt_disponible
            // 
            this.txt_disponible.Location = new System.Drawing.Point(740, 54);
            this.txt_disponible.MaxLength = 10;
            this.txt_disponible.Name = "txt_disponible";
            this.txt_disponible.Size = new System.Drawing.Size(100, 22);
            this.txt_disponible.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(604, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(735, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Estado";
            // 
            // bt_Modificar
            // 
            this.bt_Modificar.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Modificar.Location = new System.Drawing.Point(855, 52);
            this.bt_Modificar.Name = "bt_Modificar";
            this.bt_Modificar.Size = new System.Drawing.Size(89, 33);
            this.bt_Modificar.TabIndex = 17;
            this.bt_Modificar.Text = "Modificar";
            this.bt_Modificar.UseVisualStyleBackColor = true;
            this.bt_Modificar.Click += new System.EventHandler(this.bt_Modificar_Click);
            // 
            // Bt_aceptar
            // 
            this.Bt_aceptar.BackColor = System.Drawing.Color.Transparent;
            this.Bt_aceptar.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_aceptar.Location = new System.Drawing.Point(950, 44);
            this.Bt_aceptar.Name = "Bt_aceptar";
            this.Bt_aceptar.Size = new System.Drawing.Size(124, 49);
            this.Bt_aceptar.TabIndex = 18;
            this.Bt_aceptar.Text = "Confirmar Modificacion";
            this.Bt_aceptar.UseVisualStyleBackColor = false;
            this.Bt_aceptar.Click += new System.EventHandler(this.Bt_aceptar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(861, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Para modificar datos";
            // 
            // errorA
            // 
            this.errorA.ContainerControl = this;
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1097, 557);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Bt_aceptar);
            this.Controls.Add(this.bt_Modificar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_disponible);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.dgautos);
            this.Controls.Add(this.Bt_stock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Patente);
            this.Controls.Add(this.Txt_año);
            this.Controls.Add(this.Txt_Marca);
            this.Controls.Add(this.Txt_modelo);
            this.Controls.Add(this.Txt_patente);
            this.Controls.Add(this.Bt_borrar);
            this.Controls.Add(this.Bt_buscar);
            this.Controls.Add(this.Bt_agregar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Concesionario";
            ((System.ComponentModel.ISupportInitialize)(this.dgautos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bt_agregar;
        private System.Windows.Forms.Button Bt_buscar;
        private System.Windows.Forms.Button Bt_borrar;
        private System.Windows.Forms.TextBox Txt_patente;
        private System.Windows.Forms.TextBox Txt_modelo;
        private System.Windows.Forms.TextBox Txt_Marca;
        private System.Windows.Forms.TextBox Txt_año;
        private System.Windows.Forms.Label Patente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Bt_stock;
        private System.Windows.Forms.DataGridView dgautos;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_disponible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_Modificar;
        private System.Windows.Forms.Button Bt_aceptar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorA;
        private System.Windows.Forms.ErrorProvider errorP;
    }
}

