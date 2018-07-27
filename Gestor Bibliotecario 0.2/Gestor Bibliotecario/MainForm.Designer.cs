/*
 * Created by SharpDevelop.
 * User: jfcha
 * Date: 17/07/2018
 * Time: 08:58 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Gestor_Bibliotecario
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtTitulo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtEdicion;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtPaginas;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtBusqueda;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnBaja;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnEdicion;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtIsbn;
		private System.Windows.Forms.DataGridView dgvLibros;
		private System.Windows.Forms.Button btnAutor;
		private System.Windows.Forms.ComboBox cmbAutor;
		private System.Windows.Forms.ComboBox cmbEditorial;
		private System.Windows.Forms.ComboBox cmbGenero;
		
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
			this.txtTitulo = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtEdicion = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtPaginas = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtBusqueda = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnBaja = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnEdicion = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtIsbn = new System.Windows.Forms.TextBox();
			this.dgvLibros = new System.Windows.Forms.DataGridView();
			this.btnAutor = new System.Windows.Forms.Button();
			this.cmbAutor = new System.Windows.Forms.ComboBox();
			this.cmbGenero = new System.Windows.Forms.ComboBox();
			this.cmbEditorial = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
			this.SuspendLayout();
			// 
			// txtTitulo
			// 
			this.txtTitulo.Location = new System.Drawing.Point(134, 101);
			this.txtTitulo.Name = "txtTitulo";
			this.txtTitulo.Size = new System.Drawing.Size(100, 20);
			this.txtTitulo.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(28, 106);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "Titulo del Libro";
			// 
			// txtEdicion
			// 
			this.txtEdicion.Location = new System.Drawing.Point(135, 273);
			this.txtEdicion.Name = "txtEdicion";
			this.txtEdicion.Size = new System.Drawing.Size(100, 20);
			this.txtEdicion.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(29, 270);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 13;
			this.label7.Text = "Año de Edicion";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(27, 230);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 15;
			this.label8.Text = "Editorial";
			// 
			// txtPaginas
			// 
			this.txtPaginas.Location = new System.Drawing.Point(133, 187);
			this.txtPaginas.Name = "txtPaginas";
			this.txtPaginas.Size = new System.Drawing.Size(100, 20);
			this.txtPaginas.TabIndex = 18;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(27, 181);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 17;
			this.label9.Text = "No. de Paginas";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(30, 142);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 19;
			this.label10.Text = "Genero";
			// 
			// txtBusqueda
			// 
			this.txtBusqueda.Location = new System.Drawing.Point(375, 12);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new System.Drawing.Size(353, 20);
			this.txtBusqueda.TabIndex = 22;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(289, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 23;
			this.label1.Text = "Titulo del Libro";
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.Location = new System.Drawing.Point(28, 418);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(101, 35);
			this.btnRegistrar.TabIndex = 24;
			this.btnRegistrar.Text = "Registrar Libro";
			this.btnRegistrar.UseVisualStyleBackColor = true;
			this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrarClick);
			// 
			// btnEditar
			// 
			this.btnEditar.Location = new System.Drawing.Point(241, 418);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(91, 35);
			this.btnEditar.TabIndex = 25;
			this.btnEditar.Text = "Editar Libro";
			this.btnEditar.UseVisualStyleBackColor = true;
			
			// 
			// btnBaja
			// 
			this.btnBaja.Location = new System.Drawing.Point(346, 418);
			this.btnBaja.Name = "btnBaja";
			this.btnBaja.Size = new System.Drawing.Size(86, 35);
			this.btnBaja.TabIndex = 26;
			this.btnBaja.Text = "Dar de Baja libro";
			this.btnBaja.UseVisualStyleBackColor = true;
			this.btnBaja.Click += new System.EventHandler(this.BtnBajaClick);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(768, 394);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(87, 35);
			this.btnSalir.TabIndex = 27;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			// 
			// btnNuevo
			// 
			this.btnNuevo.Enabled = false;
			this.btnNuevo.Location = new System.Drawing.Point(135, 418);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(100, 35);
			this.btnNuevo.TabIndex = 28;
			this.btnNuevo.Text = "Nuevo Libro";
			this.btnNuevo.UseVisualStyleBackColor = true;
			this.btnNuevo.Click += new System.EventHandler(this.BtnNuevoClick);
			// 
			// btnEdicion
			// 
			this.btnEdicion.Location = new System.Drawing.Point(29, 459);
			this.btnEdicion.Name = "btnEdicion";
			this.btnEdicion.Size = new System.Drawing.Size(101, 35);
			this.btnEdicion.TabIndex = 29;
			this.btnEdicion.Text = "Registrar Libro";
			this.btnEdicion.UseVisualStyleBackColor = true;
			this.btnEdicion.Click += new System.EventHandler(this.BtnEdicionClick);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(30, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 33;
			this.label3.Text = "ISBN";
			// 
			// txtIsbn
			// 
			this.txtIsbn.Location = new System.Drawing.Point(135, 64);
			this.txtIsbn.Name = "txtIsbn";
			this.txtIsbn.Size = new System.Drawing.Size(100, 20);
			this.txtIsbn.TabIndex = 32;
			// 
			// dgvLibros
			// 
			this.dgvLibros.AllowUserToAddRows = false;
			this.dgvLibros.AllowUserToDeleteRows = false;
			this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLibros.Location = new System.Drawing.Point(268, 61);
			this.dgvLibros.Name = "dgvLibros";
			this.dgvLibros.ReadOnly = true;
			this.dgvLibros.Size = new System.Drawing.Size(745, 327);
			this.dgvLibros.TabIndex = 34;
			// 
			// btnAutor
			// 
			this.btnAutor.Location = new System.Drawing.Point(27, 317);
			this.btnAutor.Name = "btnAutor";
			this.btnAutor.Size = new System.Drawing.Size(78, 22);
			this.btnAutor.TabIndex = 36;
			this.btnAutor.Text = "Buscar autor";
			this.btnAutor.UseVisualStyleBackColor = true;
			this.btnAutor.Click += new System.EventHandler(this.BtnAutorClick);
			// 
			// cmbAutor
			// 
			this.cmbAutor.FormattingEnabled = true;
			this.cmbAutor.Location = new System.Drawing.Point(133, 317);
			this.cmbAutor.Name = "cmbAutor";
			this.cmbAutor.Size = new System.Drawing.Size(121, 21);
			this.cmbAutor.TabIndex = 37;
			// 
			// cmbGenero
			// 
			this.cmbGenero.FormattingEnabled = true;
			this.cmbGenero.Location = new System.Drawing.Point(136, 144);
			this.cmbGenero.Name = "cmbGenero";
			this.cmbGenero.Size = new System.Drawing.Size(121, 21);
			this.cmbGenero.TabIndex = 38;
			// 
			// cmbEditorial
			// 
			this.cmbEditorial.FormattingEnabled = true;
			this.cmbEditorial.Location = new System.Drawing.Point(133, 227);
			this.cmbEditorial.Name = "cmbEditorial";
			this.cmbEditorial.Size = new System.Drawing.Size(121, 21);
			this.cmbEditorial.TabIndex = 39;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1106, 533);
			this.Controls.Add(this.cmbEditorial);
			this.Controls.Add(this.cmbGenero);
			this.Controls.Add(this.cmbAutor);
			this.Controls.Add(this.btnAutor);
			this.Controls.Add(this.dgvLibros);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtIsbn);
			this.Controls.Add(this.btnEdicion);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnBaja);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnRegistrar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtBusqueda);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtPaginas);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtEdicion);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtTitulo);
			this.Controls.Add(this.label5);
			this.Name = "MainForm";
			this.Text = "Gestor Bibliotecario";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
