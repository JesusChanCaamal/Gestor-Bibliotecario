﻿/*
 * Created by SharpDevelop.
 * User: Crist
 * Date: 25/07/2018
 * Time: 10:54 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Prestamos_softjace
{
	partial class FrmPrestamos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtLibro;
		private System.Windows.Forms.ComboBox cmbUsuario;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnGuardarE;
		private System.Windows.Forms.Button btnPrestar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMax;
		private System.Windows.Forms.TextBox txtDevolucion;
		private System.Windows.Forms.TextBox txtNlibros;
		private System.Windows.Forms.TextBox txtPrestamo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.DataGridView dgvPrestamos;
		private System.Windows.Forms.Button btnVlibros;
		
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
			this.label9 = new System.Windows.Forms.Label();
			this.txtLibro = new System.Windows.Forms.TextBox();
			this.cmbUsuario = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.btnGuardarE = new System.Windows.Forms.Button();
			this.btnPrestar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMax = new System.Windows.Forms.TextBox();
			this.txtDevolucion = new System.Windows.Forms.TextBox();
			this.txtNlibros = new System.Windows.Forms.TextBox();
			this.txtPrestamo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.dgvPrestamos = new System.Windows.Forms.DataGridView();
			this.btnVlibros = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
			this.SuspendLayout();
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(7, 244);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(81, 23);
			this.label9.TabIndex = 65;
			this.label9.Text = "Libro";
			// 
			// txtLibro
			// 
			this.txtLibro.Location = new System.Drawing.Point(94, 244);
			this.txtLibro.Name = "txtLibro";
			this.txtLibro.Size = new System.Drawing.Size(116, 20);
			this.txtLibro.TabIndex = 6;
			// 
			// cmbUsuario
			// 
			this.cmbUsuario.FormattingEnabled = true;
			this.cmbUsuario.Location = new System.Drawing.Point(94, 104);
			this.cmbUsuario.Name = "cmbUsuario";
			this.cmbUsuario.Size = new System.Drawing.Size(121, 21);
			this.cmbUsuario.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(22, 337);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(116, 35);
			this.button1.TabIndex = 62;
			this.button1.Text = "Guardar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// btnGuardarE
			// 
			this.btnGuardarE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardarE.Location = new System.Drawing.Point(169, 337);
			this.btnGuardarE.Name = "btnGuardarE";
			this.btnGuardarE.Size = new System.Drawing.Size(116, 35);
			this.btnGuardarE.TabIndex = 61;
			this.btnGuardarE.Text = "Guardar";
			this.btnGuardarE.UseVisualStyleBackColor = true;
			this.btnGuardarE.Visible = false;
			// 
			// btnPrestar
			// 
			this.btnPrestar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPrestar.Location = new System.Drawing.Point(172, 378);
			this.btnPrestar.Name = "btnPrestar";
			this.btnPrestar.Size = new System.Drawing.Size(116, 35);
			this.btnPrestar.TabIndex = 60;
			this.btnPrestar.Text = "Prestar";
			this.btnPrestar.UseVisualStyleBackColor = true;
			this.btnPrestar.Click += new System.EventHandler(this.BtnPrestarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.Location = new System.Drawing.Point(294, 380);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(116, 35);
			this.btnEliminar.TabIndex = 59;
			this.btnEliminar.Text = "Guardar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			// 
			// btnGuardar
			// 
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(21, 378);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(116, 35);
			this.btnGuardar.TabIndex = 58;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 211);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 23);
			this.label6.TabIndex = 57;
			this.label6.Text = "Fecha Max";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 153);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 23);
			this.label5.TabIndex = 56;
			this.label5.Text = "Fecha Devolucion";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 179);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 23);
			this.label4.TabIndex = 55;
			this.label4.Text = "N_libros";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 133);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 23);
			this.label3.TabIndex = 54;
			this.label3.Text = "Fecha Prestamo";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 23);
			this.label2.TabIndex = 53;
			this.label2.Text = "Matricula: ";
			// 
			// txtMax
			// 
			this.txtMax.Location = new System.Drawing.Point(95, 211);
			this.txtMax.Name = "txtMax";
			this.txtMax.Size = new System.Drawing.Size(116, 20);
			this.txtMax.TabIndex = 5;
			// 
			// txtDevolucion
			// 
			this.txtDevolucion.Location = new System.Drawing.Point(94, 156);
			this.txtDevolucion.Name = "txtDevolucion";
			this.txtDevolucion.Size = new System.Drawing.Size(116, 20);
			this.txtDevolucion.TabIndex = 3;
			// 
			// txtNlibros
			// 
			this.txtNlibros.Location = new System.Drawing.Point(95, 182);
			this.txtNlibros.Name = "txtNlibros";
			this.txtNlibros.Size = new System.Drawing.Size(116, 20);
			this.txtNlibros.TabIndex = 4;
			// 
			// txtPrestamo
			// 
			this.txtPrestamo.Location = new System.Drawing.Point(95, 133);
			this.txtPrestamo.Name = "txtPrestamo";
			this.txtPrestamo.Size = new System.Drawing.Size(116, 20);
			this.txtPrestamo.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(22, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 23);
			this.label1.TabIndex = 52;
			this.label1.Text = "Usuario";
			// 
			// txtBuscar
			// 
			this.txtBuscar.Location = new System.Drawing.Point(123, 45);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(389, 20);
			this.txtBuscar.TabIndex = 51;
			// 
			// dgvPrestamos
			// 
			this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPrestamos.Location = new System.Drawing.Point(229, 88);
			this.dgvPrestamos.Name = "dgvPrestamos";
			this.dgvPrestamos.ReadOnly = true;
			this.dgvPrestamos.Size = new System.Drawing.Size(513, 216);
			this.dgvPrestamos.TabIndex = 50;
			// 
			// btnVlibros
			// 
			this.btnVlibros.Location = new System.Drawing.Point(518, 48);
			this.btnVlibros.Name = "btnVlibros";
			this.btnVlibros.Size = new System.Drawing.Size(75, 23);
			this.btnVlibros.TabIndex = 67;
			this.btnVlibros.Text = "Libros";
			this.btnVlibros.UseVisualStyleBackColor = true;
			this.btnVlibros.Click += new System.EventHandler(this.BtnVlibrosClick);
			// 
			// FrmPrestamos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(749, 463);
			this.Controls.Add(this.btnVlibros);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtLibro);
			this.Controls.Add(this.cmbUsuario);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnGuardarE);
			this.Controls.Add(this.btnPrestar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtMax);
			this.Controls.Add(this.txtDevolucion);
			this.Controls.Add(this.txtNlibros);
			this.Controls.Add(this.txtPrestamo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.dgvPrestamos);
			this.Name = "FrmPrestamos";
			this.Text = "FrmPrestamos";
			this.Load += new System.EventHandler(this.FrmPrestamosLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
