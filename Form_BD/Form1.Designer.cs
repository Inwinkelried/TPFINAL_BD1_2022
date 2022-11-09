namespace Form_BD {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_CargarVista = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Nro_Doc = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_Localidad = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.btn_AddPersona = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1029, 170);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_CargarVista
            // 
            this.btn_CargarVista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_CargarVista.Location = new System.Drawing.Point(105, 310);
            this.btn_CargarVista.Name = "btn_CargarVista";
            this.btn_CargarVista.Size = new System.Drawing.Size(167, 63);
            this.btn_CargarVista.TabIndex = 1;
            this.btn_CargarVista.Text = "Refrescar Tabla";
            this.btn_CargarVista.UseVisualStyleBackColor = true;
            this.btn_CargarVista.Click += new System.EventHandler(this.btn_CargarVista_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(624, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nro Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(669, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(661, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Direccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(658, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Localidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(664, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefono:";
            // 
            // txt_Nro_Doc
            // 
            this.txt_Nro_Doc.Location = new System.Drawing.Point(734, 260);
            this.txt_Nro_Doc.Name = "txt_Nro_Doc";
            this.txt_Nro_Doc.Size = new System.Drawing.Size(104, 22);
            this.txt_Nro_Doc.TabIndex = 8;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(734, 288);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(104, 22);
            this.txt_Nombre.TabIndex = 9;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(734, 310);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(104, 22);
            this.txt_Direccion.TabIndex = 10;
            // 
            // txt_Localidad
            // 
            this.txt_Localidad.Location = new System.Drawing.Point(734, 335);
            this.txt_Localidad.Name = "txt_Localidad";
            this.txt_Localidad.Size = new System.Drawing.Size(104, 22);
            this.txt_Localidad.TabIndex = 11;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(734, 363);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(104, 22);
            this.txt_Telefono.TabIndex = 12;
            // 
            // btn_AddPersona
            // 
            this.btn_AddPersona.Location = new System.Drawing.Point(678, 434);
            this.btn_AddPersona.Name = "btn_AddPersona";
            this.btn_AddPersona.Size = new System.Drawing.Size(160, 55);
            this.btn_AddPersona.TabIndex = 14;
            this.btn_AddPersona.Text = "Cargar Persona";
            this.btn_AddPersona.UseVisualStyleBackColor = true;
            this.btn_AddPersona.Click += new System.EventHandler(this.btn_AddPersona_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(142, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ejecutar Vista";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(669, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ejecutar Stored Procedure";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 521);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_AddPersona);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.txt_Localidad);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Nro_Doc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_CargarVista);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_CargarVista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Nro_Doc;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_Localidad;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.Button btn_AddPersona;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

