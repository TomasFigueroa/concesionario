namespace concesionario
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.Dgstock = new System.Windows.Forms.DataGridView();
            this.Bt_Agregar = new System.Windows.Forms.Button();
            this.txt_dni = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_patente = new System.Windows.Forms.TextBox();
            this.DNI = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Bt_buscar = new System.Windows.Forms.Button();
            this.errorD = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Dgstock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorD)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgstock
            // 
            this.Dgstock.AllowUserToAddRows = false;
            this.Dgstock.BackgroundColor = System.Drawing.Color.Gray;
            this.Dgstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgstock.Location = new System.Drawing.Point(285, 12);
            this.Dgstock.Name = "Dgstock";
            this.Dgstock.ReadOnly = true;
            this.Dgstock.RowHeadersWidth = 51;
            this.Dgstock.RowTemplate.Height = 24;
            this.Dgstock.Size = new System.Drawing.Size(581, 436);
            this.Dgstock.TabIndex = 0;
            this.Dgstock.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgstock_CellDoubleClick);
            // 
            // Bt_Agregar
            // 
            this.Bt_Agregar.BackColor = System.Drawing.SystemColors.Window;
            this.Bt_Agregar.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Agregar.Location = new System.Drawing.Point(12, 105);
            this.Bt_Agregar.Name = "Bt_Agregar";
            this.Bt_Agregar.Size = new System.Drawing.Size(117, 38);
            this.Bt_Agregar.TabIndex = 2;
            this.Bt_Agregar.Text = "Agregar";
            this.Bt_Agregar.UseVisualStyleBackColor = false;
            this.Bt_Agregar.Click += new System.EventHandler(this.Bt_Agregar_Click);
            // 
            // txt_dni
            // 
            this.txt_dni.Location = new System.Drawing.Point(143, 52);
            this.txt_dni.MaxLength = 10;
            this.txt_dni.Name = "txt_dni";
            this.txt_dni.Size = new System.Drawing.Size(100, 22);
            this.txt_dni.TabIndex = 7;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(143, 105);
            this.txt_nombre.MaxLength = 10;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 22);
            this.txt_nombre.TabIndex = 8;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(143, 159);
            this.txt_apellido.MaxLength = 10;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(100, 22);
            this.txt_apellido.TabIndex = 9;
            // 
            // txt_patente
            // 
            this.txt_patente.Location = new System.Drawing.Point(143, 210);
            this.txt_patente.MaxLength = 7;
            this.txt_patente.Name = "txt_patente";
            this.txt_patente.Size = new System.Drawing.Size(100, 22);
            this.txt_patente.TabIndex = 10;
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNI.Location = new System.Drawing.Point(139, 26);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(41, 23);
            this.DNI.TabIndex = 11;
            this.DNI.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(140, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Patente";
            // 
            // Bt_buscar
            // 
            this.Bt_buscar.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_buscar.Location = new System.Drawing.Point(12, 52);
            this.Bt_buscar.Name = "Bt_buscar";
            this.Bt_buscar.Size = new System.Drawing.Size(117, 37);
            this.Bt_buscar.TabIndex = 15;
            this.Bt_buscar.Text = "Buscar";
            this.Bt_buscar.UseVisualStyleBackColor = true;
            this.Bt_buscar.Click += new System.EventHandler(this.Bt_buscar_Click);
            // 
            // errorD
            // 
            this.errorD.ContainerControl = this;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(895, 451);
            this.Controls.Add(this.Bt_buscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.txt_patente);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_dni);
            this.Controls.Add(this.Bt_Agregar);
            this.Controls.Add(this.Dgstock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stock";
            this.Text = "Datos de ventas";
            ((System.ComponentModel.ISupportInitialize)(this.Dgstock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgstock;
        private System.Windows.Forms.Button Bt_Agregar;
        private System.Windows.Forms.TextBox txt_dni;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_patente;
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Bt_buscar;
        private System.Windows.Forms.ErrorProvider errorD;
    }
}