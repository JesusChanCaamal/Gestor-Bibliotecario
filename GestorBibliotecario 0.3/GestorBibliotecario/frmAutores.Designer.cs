/*
 * Created by SharpDevelop.
 * User: abril
 * Date: 26/07/2018
 * Time: 09:32 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GestorBibliotecario
{
	partial class frmAutores
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnSeleccionar;
		private System.Windows.Forms.Button btnAgregarAutor;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtBusqueda;
		private System.Windows.Forms.DataGridView dgvAutor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPais;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtM;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtP;
		private System.Windows.Forms.Label label5;
		
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
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.btnAgregarAutor = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtBusqueda = new System.Windows.Forms.TextBox();
			this.dgvAutor = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPais = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtM = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtP = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvAutor)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.Location = new System.Drawing.Point(577, 270);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(104, 37);
			this.btnSeleccionar.TabIndex = 62;
			this.btnSeleccionar.Text = "Seleccionar.";
			this.btnSeleccionar.UseVisualStyleBackColor = true;
			// 
			// btnAgregarAutor
			// 
			this.btnAgregarAutor.Location = new System.Drawing.Point(172, 270);
			this.btnAgregarAutor.Name = "btnAgregarAutor";
			this.btnAgregarAutor.Size = new System.Drawing.Size(94, 37);
			this.btnAgregarAutor.TabIndex = 60;
			this.btnAgregarAutor.Text = "Agregar.";
			this.btnAgregarAutor.UseVisualStyleBackColor = true;
			this.btnAgregarAutor.Click += new System.EventHandler(this.BtnAgregarAutorClick);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(49, 54);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 59;
			this.label4.Text = "Titulo del Libro";
			// 
			// txtBusqueda
			// 
			this.txtBusqueda.Location = new System.Drawing.Point(137, 51);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new System.Drawing.Size(353, 20);
			this.txtBusqueda.TabIndex = 58;
			// 
			// dgvAutor
			// 
			this.dgvAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAutor.Location = new System.Drawing.Point(278, 101);
			this.dgvAutor.Name = "dgvAutor";
			this.dgvAutor.Size = new System.Drawing.Size(403, 150);
			this.dgvAutor.TabIndex = 57;
			this.dgvAutor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAutorCellContentClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(49, 221);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 56;
			this.label1.Text = "procedencia";
			// 
			// txtPais
			// 
			this.txtPais.Location = new System.Drawing.Point(154, 224);
			this.txtPais.Name = "txtPais";
			this.txtPais.Size = new System.Drawing.Size(100, 20);
			this.txtPais.TabIndex = 55;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(49, 179);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 54;
			this.label3.Text = "Apellido Materno";
			// 
			// txtM
			// 
			this.txtM.Location = new System.Drawing.Point(156, 179);
			this.txtM.Name = "txtM";
			this.txtM.Size = new System.Drawing.Size(100, 20);
			this.txtM.TabIndex = 53;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(49, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 52;
			this.label2.Text = "Nombre del autor";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(154, 101);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(100, 20);
			this.txtNombre.TabIndex = 51;
			// 
			// txtP
			// 
			this.txtP.Location = new System.Drawing.Point(155, 138);
			this.txtP.Name = "txtP";
			this.txtP.Size = new System.Drawing.Size(100, 20);
			this.txtP.TabIndex = 50;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(49, 141);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 49;
			this.label5.Text = "Apellido paterno";
			// 
			// frmAutores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(718, 358);
			this.Controls.Add(this.btnSeleccionar);
			this.Controls.Add(this.btnAgregarAutor);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtBusqueda);
			this.Controls.Add(this.dgvAutor);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPais);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtM);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtP);
			this.Controls.Add(this.label5);
			this.Name = "frmAutores";
			this.Text = "frmAutores";
			this.Load += new System.EventHandler(this.FrmAutoresLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvAutor)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
