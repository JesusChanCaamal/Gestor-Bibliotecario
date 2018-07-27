/*
 * Created by SharpDevelop.
 * User: Crist
 * Date: 19/07/2018
 * Time: 07:57 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace softjace
{
	partial class frmUsuarios
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnGuardarE;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtEdad;
		private System.Windows.Forms.TextBox txtApellidoP;
		private System.Windows.Forms.TextBox txtApellidoM;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtMatricula;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.DataGridView dgvUsuarios;
		private System.Windows.Forms.ComboBox cmbLocalidad;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.TextBox txtGenero;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnGuardarE = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtEdad = new System.Windows.Forms.TextBox();
			this.txtApellidoP = new System.Windows.Forms.TextBox();
			this.txtApellidoM = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtMatricula = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.dgvUsuarios = new System.Windows.Forms.DataGridView();
			this.cmbLocalidad = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.txtGenero = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGuardarE
			// 
			this.btnGuardarE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardarE.Location = new System.Drawing.Point(182, 316);
			this.btnGuardarE.Name = "btnGuardarE";
			this.btnGuardarE.Size = new System.Drawing.Size(116, 35);
			this.btnGuardarE.TabIndex = 35;
			this.btnGuardarE.Text = "Guardar";
			this.btnGuardarE.UseVisualStyleBackColor = true;
			this.btnGuardarE.Visible = false;
			this.btnGuardarE.Click += new System.EventHandler(this.BtnGuardarEClick);
			// 
			// btnEditar
			// 
			this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditar.Location = new System.Drawing.Point(168, 359);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(116, 35);
			this.btnEditar.TabIndex = 34;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.BtnEditarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.Location = new System.Drawing.Point(307, 359);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(116, 35);
			this.btnEliminar.TabIndex = 33;
			this.btnEliminar.Text = "Guardar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// btnGuardar
			// 
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(34, 357);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(116, 35);
			this.btnGuardar.TabIndex = 32;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(21, 190);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 23);
			this.label6.TabIndex = 31;
			this.label6.Text = "Edad";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(21, 132);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 23);
			this.label5.TabIndex = 30;
			this.label5.Text = "Apellido P";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(19, 158);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 23);
			this.label4.TabIndex = 29;
			this.label4.Text = "Apellido M.";
			this.label4.Click += new System.EventHandler(this.Label4Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(21, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 23);
			this.label3.TabIndex = 28;
			this.label3.Text = "Nombre";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(21, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 23);
			this.label2.TabIndex = 27;
			this.label2.Text = "Matricula: ";
			// 
			// txtEdad
			// 
			this.txtEdad.Location = new System.Drawing.Point(108, 190);
			this.txtEdad.Name = "txtEdad";
			this.txtEdad.Size = new System.Drawing.Size(116, 20);
			this.txtEdad.TabIndex = 5;
			// 
			// txtApellidoP
			// 
			this.txtApellidoP.Location = new System.Drawing.Point(107, 135);
			this.txtApellidoP.Name = "txtApellidoP";
			this.txtApellidoP.Size = new System.Drawing.Size(116, 20);
			this.txtApellidoP.TabIndex = 3;
			// 
			// txtApellidoM
			// 
			this.txtApellidoM.Location = new System.Drawing.Point(108, 161);
			this.txtApellidoM.Name = "txtApellidoM";
			this.txtApellidoM.Size = new System.Drawing.Size(116, 20);
			this.txtApellidoM.TabIndex = 4;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(108, 112);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(116, 20);
			this.txtNombre.TabIndex = 2;
			// 
			// txtMatricula
			// 
			this.txtMatricula.Location = new System.Drawing.Point(108, 87);
			this.txtMatricula.Name = "txtMatricula";
			this.txtMatricula.Size = new System.Drawing.Size(116, 20);
			this.txtMatricula.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(35, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 23);
			this.label1.TabIndex = 21;
			this.label1.Text = "Usuario";
			// 
			// txtBuscar
			// 
			this.txtBuscar.Location = new System.Drawing.Point(182, 27);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(389, 20);
			this.txtBuscar.TabIndex = 20;
			this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscarTextChanged);
			// 
			// dgvUsuarios
			// 
			this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsuarios.Location = new System.Drawing.Point(242, 67);
			this.dgvUsuarios.Name = "dgvUsuarios";
			this.dgvUsuarios.ReadOnly = true;
			this.dgvUsuarios.Size = new System.Drawing.Size(513, 216);
			this.dgvUsuarios.TabIndex = 19;
			// 
			// cmbLocalidad
			// 
			this.cmbLocalidad.FormattingEnabled = true;
			this.cmbLocalidad.Location = new System.Drawing.Point(108, 275);
			this.cmbLocalidad.Name = "cmbLocalidad";
			this.cmbLocalidad.Size = new System.Drawing.Size(121, 21);
			this.cmbLocalidad.TabIndex = 37;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(20, 275);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(81, 23);
			this.label7.TabIndex = 38;
			this.label7.Text = "Localidad";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(19, 249);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(81, 23);
			this.label8.TabIndex = 42;
			this.label8.Text = "Telefono";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(20, 223);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(81, 23);
			this.label9.TabIndex = 41;
			this.label9.Text = "Genero";
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(107, 249);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(116, 20);
			this.txtTelefono.TabIndex = 7;
			// 
			// txtGenero
			// 
			this.txtGenero.Location = new System.Drawing.Point(107, 223);
			this.txtGenero.Name = "txtGenero";
			this.txtGenero.Size = new System.Drawing.Size(116, 20);
			this.txtGenero.TabIndex = 6;
			// 
			// frmUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(775, 406);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.txtGenero);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cmbLocalidad);
			this.Controls.Add(this.btnGuardarE);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtEdad);
			this.Controls.Add(this.txtApellidoP);
			this.Controls.Add(this.txtApellidoM);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtMatricula);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.dgvUsuarios);
			this.Name = "frmUsuarios";
			this.Text = "frmUsuarios";
			this.Load += new System.EventHandler(this.FrmUsuariosLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
