namespace agenda
{
    partial class frm_interfaz
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Dgv_test = new System.Windows.Forms.DataGridView();
            this.Btn_cargartxt = new System.Windows.Forms.Button();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Txt_direcc = new System.Windows.Forms.TextBox();
            this.Txt_fecha = new System.Windows.Forms.TextBox();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.Lbl_direcc = new System.Windows.Forms.Label();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Btn_salvar = new System.Windows.Forms.Button();
            this.Btn_Borrar = new System.Windows.Forms.Button();
            this.Lbl_tel1 = new System.Windows.Forms.Label();
            this.Txt_tel1 = new System.Windows.Forms.TextBox();
            this.Lbl_tel2 = new System.Windows.Forms.Label();
            this.Txt_tel2 = new System.Windows.Forms.TextBox();
            this.Lbl_tel3 = new System.Windows.Forms.Label();
            this.Txt_tel3 = new System.Windows.Forms.TextBox();
            this.Cb_tel1 = new System.Windows.Forms.ComboBox();
            this.Cb_tel2 = new System.Windows.Forms.ComboBox();
            this.Cb_tel3 = new System.Windows.Forms.ComboBox();
            this.Btn_cargarxml = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_test)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_agregar.ForeColor = System.Drawing.Color.Black;
            this.Btn_agregar.Location = new System.Drawing.Point(338, 192);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(168, 42);
            this.Btn_agregar.TabIndex = 0;
            this.Btn_agregar.Text = "Agregar Contacto";
            this.Btn_agregar.UseVisualStyleBackColor = true;
            this.Btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // Dgv_test
            // 
            this.Dgv_test.AllowUserToAddRows = false;
            this.Dgv_test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_test.DefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_test.Location = new System.Drawing.Point(28, 255);
            this.Dgv_test.Name = "Dgv_test";
            this.Dgv_test.Size = new System.Drawing.Size(643, 209);
            this.Dgv_test.TabIndex = 1;
            // 
            // Btn_cargartxt
            // 
            this.Btn_cargartxt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cargartxt.ForeColor = System.Drawing.Color.Black;
            this.Btn_cargartxt.Location = new System.Drawing.Point(117, 490);
            this.Btn_cargartxt.Name = "Btn_cargartxt";
            this.Btn_cargartxt.Size = new System.Drawing.Size(142, 53);
            this.Btn_cargartxt.TabIndex = 2;
            this.Btn_cargartxt.Text = "Cargar Contactos TXT";
            this.Btn_cargartxt.UseVisualStyleBackColor = true;
            this.Btn_cargartxt.Click += new System.EventHandler(this.Btn_cargartxt_Click);
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Location = new System.Drawing.Point(238, 47);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(170, 20);
            this.Txt_nombre.TabIndex = 3;
            // 
            // Txt_direcc
            // 
            this.Txt_direcc.Location = new System.Drawing.Point(238, 92);
            this.Txt_direcc.Name = "Txt_direcc";
            this.Txt_direcc.Size = new System.Drawing.Size(170, 20);
            this.Txt_direcc.TabIndex = 4;
            // 
            // Txt_fecha
            // 
            this.Txt_fecha.Location = new System.Drawing.Point(238, 135);
            this.Txt_fecha.Name = "Txt_fecha";
            this.Txt_fecha.Size = new System.Drawing.Size(170, 20);
            this.Txt_fecha.TabIndex = 5;
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.Lbl_nombre.Location = new System.Drawing.Point(24, 47);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(83, 22);
            this.Lbl_nombre.TabIndex = 6;
            this.Lbl_nombre.Text = "Nombre";
            // 
            // Lbl_direcc
            // 
            this.Lbl_direcc.AutoSize = true;
            this.Lbl_direcc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_direcc.Location = new System.Drawing.Point(24, 89);
            this.Lbl_direcc.Name = "Lbl_direcc";
            this.Lbl_direcc.Size = new System.Drawing.Size(99, 22);
            this.Lbl_direcc.TabIndex = 7;
            this.Lbl_direcc.Text = "Dirección";
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.Location = new System.Drawing.Point(24, 135);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(203, 22);
            this.Lbl_fecha.TabIndex = 8;
            this.Lbl_fecha.Text = "Fecha de Nacimiento";
            // 
            // Btn_salvar
            // 
            this.Btn_salvar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_salvar.ForeColor = System.Drawing.Color.Black;
            this.Btn_salvar.Location = new System.Drawing.Point(582, 510);
            this.Btn_salvar.Name = "Btn_salvar";
            this.Btn_salvar.Size = new System.Drawing.Size(124, 87);
            this.Btn_salvar.TabIndex = 9;
            this.Btn_salvar.Text = "Guardar Cambios";
            this.Btn_salvar.UseVisualStyleBackColor = true;
            this.Btn_salvar.Click += new System.EventHandler(this.Btn_salvar_Click);
            // 
            // Btn_Borrar
            // 
            this.Btn_Borrar.Enabled = false;
            this.Btn_Borrar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Borrar.ForeColor = System.Drawing.Color.Black;
            this.Btn_Borrar.Location = new System.Drawing.Point(710, 341);
            this.Btn_Borrar.Name = "Btn_Borrar";
            this.Btn_Borrar.Size = new System.Drawing.Size(108, 49);
            this.Btn_Borrar.TabIndex = 10;
            this.Btn_Borrar.Text = "Borrar Contacto";
            this.Btn_Borrar.UseVisualStyleBackColor = true;
            this.Btn_Borrar.Click += new System.EventHandler(this.Btn_Borrar_Click);
            // 
            // Lbl_tel1
            // 
            this.Lbl_tel1.AutoSize = true;
            this.Lbl_tel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tel1.Location = new System.Drawing.Point(426, 43);
            this.Lbl_tel1.Name = "Lbl_tel1";
            this.Lbl_tel1.Size = new System.Drawing.Size(118, 22);
            this.Lbl_tel1.TabIndex = 12;
            this.Lbl_tel1.Text = "Telefono #1";
            // 
            // Txt_tel1
            // 
            this.Txt_tel1.Location = new System.Drawing.Point(546, 45);
            this.Txt_tel1.Name = "Txt_tel1";
            this.Txt_tel1.Size = new System.Drawing.Size(142, 20);
            this.Txt_tel1.TabIndex = 11;
            // 
            // Lbl_tel2
            // 
            this.Lbl_tel2.AutoSize = true;
            this.Lbl_tel2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tel2.Location = new System.Drawing.Point(426, 89);
            this.Lbl_tel2.Name = "Lbl_tel2";
            this.Lbl_tel2.Size = new System.Drawing.Size(118, 22);
            this.Lbl_tel2.TabIndex = 14;
            this.Lbl_tel2.Text = "Telefono #2";
            // 
            // Txt_tel2
            // 
            this.Txt_tel2.Location = new System.Drawing.Point(546, 93);
            this.Txt_tel2.Name = "Txt_tel2";
            this.Txt_tel2.Size = new System.Drawing.Size(142, 20);
            this.Txt_tel2.TabIndex = 13;
            // 
            // Lbl_tel3
            // 
            this.Lbl_tel3.AutoSize = true;
            this.Lbl_tel3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tel3.Location = new System.Drawing.Point(426, 135);
            this.Lbl_tel3.Name = "Lbl_tel3";
            this.Lbl_tel3.Size = new System.Drawing.Size(118, 22);
            this.Lbl_tel3.TabIndex = 16;
            this.Lbl_tel3.Text = "Telefono #3";
            // 
            // Txt_tel3
            // 
            this.Txt_tel3.Location = new System.Drawing.Point(546, 139);
            this.Txt_tel3.Name = "Txt_tel3";
            this.Txt_tel3.Size = new System.Drawing.Size(142, 20);
            this.Txt_tel3.TabIndex = 15;
            // 
            // Cb_tel1
            // 
            this.Cb_tel1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_tel1.FormattingEnabled = true;
            this.Cb_tel1.Items.AddRange(new object[] {
            "Casa",
            "Celular",
            "Trabajo"});
            this.Cb_tel1.Location = new System.Drawing.Point(710, 44);
            this.Cb_tel1.Name = "Cb_tel1";
            this.Cb_tel1.Size = new System.Drawing.Size(87, 21);
            this.Cb_tel1.TabIndex = 17;
            // 
            // Cb_tel2
            // 
            this.Cb_tel2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_tel2.FormattingEnabled = true;
            this.Cb_tel2.Items.AddRange(new object[] {
            "Casa",
            "Celular",
            "Trabajo"});
            this.Cb_tel2.Location = new System.Drawing.Point(710, 92);
            this.Cb_tel2.Name = "Cb_tel2";
            this.Cb_tel2.Size = new System.Drawing.Size(87, 21);
            this.Cb_tel2.TabIndex = 18;
            // 
            // Cb_tel3
            // 
            this.Cb_tel3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_tel3.FormattingEnabled = true;
            this.Cb_tel3.Items.AddRange(new object[] {
            "Casa",
            "Celular",
            "Trabajo"});
            this.Cb_tel3.Location = new System.Drawing.Point(710, 139);
            this.Cb_tel3.Name = "Cb_tel3";
            this.Cb_tel3.Size = new System.Drawing.Size(87, 21);
            this.Cb_tel3.TabIndex = 19;
            // 
            // Btn_cargarxml
            // 
            this.Btn_cargarxml.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cargarxml.ForeColor = System.Drawing.Color.Black;
            this.Btn_cargarxml.Location = new System.Drawing.Point(117, 563);
            this.Btn_cargarxml.Name = "Btn_cargarxml";
            this.Btn_cargarxml.Size = new System.Drawing.Size(142, 55);
            this.Btn_cargarxml.TabIndex = 20;
            this.Btn_cargarxml.Text = "Cargar Contactos XML";
            this.Btn_cargarxml.UseVisualStyleBackColor = true;
            this.Btn_cargarxml.Click += new System.EventHandler(this.Btn_cargarxml_Click);
            // 
            // frm_interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(854, 659);
            this.Controls.Add(this.Btn_cargarxml);
            this.Controls.Add(this.Cb_tel3);
            this.Controls.Add(this.Cb_tel2);
            this.Controls.Add(this.Cb_tel1);
            this.Controls.Add(this.Lbl_tel3);
            this.Controls.Add(this.Txt_tel3);
            this.Controls.Add(this.Lbl_tel2);
            this.Controls.Add(this.Txt_tel2);
            this.Controls.Add(this.Lbl_tel1);
            this.Controls.Add(this.Txt_tel1);
            this.Controls.Add(this.Btn_Borrar);
            this.Controls.Add(this.Btn_salvar);
            this.Controls.Add(this.Lbl_fecha);
            this.Controls.Add(this.Lbl_direcc);
            this.Controls.Add(this.Lbl_nombre);
            this.Controls.Add(this.Txt_fecha);
            this.Controls.Add(this.Txt_direcc);
            this.Controls.Add(this.Txt_nombre);
            this.Controls.Add(this.Btn_cargartxt);
            this.Controls.Add(this.Dgv_test);
            this.Controls.Add(this.Btn_agregar);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frm_interfaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.frm_interfaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_test)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.DataGridView Dgv_test;
        private System.Windows.Forms.Button Btn_cargartxt;
        private System.Windows.Forms.TextBox Txt_direcc;
        private System.Windows.Forms.TextBox Txt_fecha;
        private System.Windows.Forms.Label Lbl_nombre;
        private System.Windows.Forms.Label Lbl_direcc;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.Button Btn_salvar;
        private System.Windows.Forms.Button Btn_Borrar;
        private System.Windows.Forms.Label Lbl_tel1;
        private System.Windows.Forms.TextBox Txt_tel1;
        private System.Windows.Forms.Label Lbl_tel2;
        private System.Windows.Forms.TextBox Txt_tel2;
        private System.Windows.Forms.Label Lbl_tel3;
        private System.Windows.Forms.TextBox Txt_tel3;
        private System.Windows.Forms.ComboBox Cb_tel1;
        private System.Windows.Forms.ComboBox Cb_tel2;
        private System.Windows.Forms.ComboBox Cb_tel3;
        public System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.Button Btn_cargarxml;
    }
}

