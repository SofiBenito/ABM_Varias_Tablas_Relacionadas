namespace ABMCarrera
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
            this.txtcod_carrera_detalle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btneditarDetalle = new System.Windows.Forms.Button();
            this.btngrabardetalle = new System.Windows.Forms.Button();
            this.btneliminarDetalle = new System.Windows.Forms.Button();
            this.btncancelardetalle = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevoDetalle = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvCarrera = new System.Windows.Forms.DataGridView();
            this.cboAsignatura = new System.Windows.Forms.ComboBox();
            this.txtCuatrimestre = new System.Windows.Forms.TextBox();
            this.dtpAnioCursado = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtCodigoCarrera = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrera)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcod_carrera_detalle
            // 
            this.txtcod_carrera_detalle.Location = new System.Drawing.Point(573, 36);
            this.txtcod_carrera_detalle.Name = "txtcod_carrera_detalle";
            this.txtcod_carrera_detalle.Size = new System.Drawing.Size(177, 20);
            this.txtcod_carrera_detalle.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Codigo De Carrera";
            // 
            // btneditarDetalle
            // 
            this.btneditarDetalle.Location = new System.Drawing.Point(491, 343);
            this.btneditarDetalle.Name = "btneditarDetalle";
            this.btneditarDetalle.Size = new System.Drawing.Size(75, 23);
            this.btneditarDetalle.TabIndex = 13;
            this.btneditarDetalle.Text = "Editar";
            this.btneditarDetalle.UseVisualStyleBackColor = true;
            this.btneditarDetalle.Click += new System.EventHandler(this.btneditarDetalle_Click);
            // 
            // btngrabardetalle
            // 
            this.btngrabardetalle.Location = new System.Drawing.Point(588, 314);
            this.btngrabardetalle.Name = "btngrabardetalle";
            this.btngrabardetalle.Size = new System.Drawing.Size(75, 23);
            this.btngrabardetalle.TabIndex = 14;
            this.btngrabardetalle.Text = "Grabar";
            this.btngrabardetalle.UseVisualStyleBackColor = true;
            this.btngrabardetalle.Click += new System.EventHandler(this.btngrabardetalle_Click);
            // 
            // btneliminarDetalle
            // 
            this.btneliminarDetalle.Location = new System.Drawing.Point(675, 328);
            this.btneliminarDetalle.Name = "btneliminarDetalle";
            this.btneliminarDetalle.Size = new System.Drawing.Size(75, 23);
            this.btneliminarDetalle.TabIndex = 16;
            this.btneliminarDetalle.Text = "Eliminar";
            this.btneliminarDetalle.UseVisualStyleBackColor = true;
            this.btneliminarDetalle.Click += new System.EventHandler(this.btneliminarDetalle_Click);
            // 
            // btncancelardetalle
            // 
            this.btncancelardetalle.Location = new System.Drawing.Point(588, 343);
            this.btncancelardetalle.Name = "btncancelardetalle";
            this.btncancelardetalle.Size = new System.Drawing.Size(75, 23);
            this.btncancelardetalle.TabIndex = 15;
            this.btncancelardetalle.Text = "Cancelar";
            this.btncancelardetalle.UseVisualStyleBackColor = true;
            this.btncancelardetalle.Click += new System.EventHandler(this.btncancelardetalle_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(789, 313);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 52);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevoDetalle
            // 
            this.btnNuevoDetalle.Location = new System.Drawing.Point(491, 314);
            this.btnNuevoDetalle.Name = "btnNuevoDetalle";
            this.btnNuevoDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoDetalle.TabIndex = 12;
            this.btnNuevoDetalle.Text = "Nuevo";
            this.btnNuevoDetalle.UseVisualStyleBackColor = true;
            this.btnNuevoDetalle.Click += new System.EventHandler(this.btnNuevoDetalle_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDetalle.Location = new System.Drawing.Point(459, 147);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(431, 160);
            this.dgvDetalle.TabIndex = 13;
            this.dgvDetalle.SelectionChanged += new System.EventHandler(this.dgvDetalle_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Cargar Detalle\r\n";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(46, 343);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(143, 314);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 5;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(224, 328);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(143, 343);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(46, 314);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvCarrera
            // 
            this.dgvCarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrera.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCarrera.Location = new System.Drawing.Point(30, 147);
            this.dgvCarrera.Name = "dgvCarrera";
            this.dgvCarrera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarrera.Size = new System.Drawing.Size(353, 160);
            this.dgvCarrera.TabIndex = 46;
            this.dgvCarrera.SelectionChanged += new System.EventHandler(this.dgvCarrera_SelectionChanged);
            // 
            // cboAsignatura
            // 
            this.cboAsignatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAsignatura.FormattingEnabled = true;
            this.cboAsignatura.Location = new System.Drawing.Point(573, 121);
            this.cboAsignatura.Name = "cboAsignatura";
            this.cboAsignatura.Size = new System.Drawing.Size(177, 21);
            this.cboAsignatura.TabIndex = 11;
            // 
            // txtCuatrimestre
            // 
            this.txtCuatrimestre.Location = new System.Drawing.Point(573, 92);
            this.txtCuatrimestre.Name = "txtCuatrimestre";
            this.txtCuatrimestre.Size = new System.Drawing.Size(177, 20);
            this.txtCuatrimestre.TabIndex = 10;
            // 
            // dtpAnioCursado
            // 
            this.dtpAnioCursado.Location = new System.Drawing.Point(573, 65);
            this.dtpAnioCursado.Name = "dtpAnioCursado";
            this.dtpAnioCursado.Size = new System.Drawing.Size(210, 20);
            this.dtpAnioCursado.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Cuatrimestre";
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(143, 71);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(177, 20);
            this.txtCarrera.TabIndex = 1;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(143, 97);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(177, 20);
            this.txtTitulo.TabIndex = 2;
            // 
            // txtCodigoCarrera
            // 
            this.txtCodigoCarrera.Location = new System.Drawing.Point(143, 43);
            this.txtCodigoCarrera.Name = "txtCodigoCarrera";
            this.txtCodigoCarrera.Size = new System.Drawing.Size(177, 20);
            this.txtCodigoCarrera.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(13, 97);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 38;
            this.lblTitulo.Text = "Titulo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Años de cursado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Asignatura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Codigo De Carrera";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(13, 71);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(41, 13);
            this.lblCarrera.TabIndex = 34;
            this.lblCarrera.Text = "Carrera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Cargar Carrera";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 390);
            this.Controls.Add(this.txtcod_carrera_detalle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btneditarDetalle);
            this.Controls.Add(this.btngrabardetalle);
            this.Controls.Add(this.btneliminarDetalle);
            this.Controls.Add(this.btncancelardetalle);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevoDetalle);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvCarrera);
            this.Controls.Add(this.cboAsignatura);
            this.Controls.Add(this.txtCuatrimestre);
            this.Controls.Add(this.dtpAnioCursado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtCodigoCarrera);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM_Carrera";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcod_carrera_detalle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btneditarDetalle;
        private System.Windows.Forms.Button btngrabardetalle;
        private System.Windows.Forms.Button btneliminarDetalle;
        private System.Windows.Forms.Button btncancelardetalle;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevoDetalle;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvCarrera;
        private System.Windows.Forms.ComboBox cboAsignatura;
        private System.Windows.Forms.TextBox txtCuatrimestre;
        private System.Windows.Forms.DateTimePicker dtpAnioCursado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtCodigoCarrera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label label1;
    }
}

