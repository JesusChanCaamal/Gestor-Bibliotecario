/*
 * Created by SharpDevelop.
 * User: abril
 * Date: 21/07/2018
 * Time: 06:35 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GestorBibliotecario
{
	partial class frmPrestamos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtId_Prestamo;
		private System.Windows.Forms.TextBox txtMatricula;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dtpFecha_Prestamo;
		private System.Windows.Forms.DateTimePicker dtpFecha_Devolucion;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dgvPrestamos;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.DateTimePicker dtpFecha_maxDevolucion;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtId_Prestamo = new System.Windows.Forms.TextBox();
			this.txtMatricula = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.dtpFecha_Prestamo = new System.Windows.Forms.DateTimePicker();
			this.dtpFecha_Devolucion = new System.Windows.Forms.DateTimePicker();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dgvPrestamos = new System.Windows.Forms.DataGridView();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.dtpFecha_maxDevolucion = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(22, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Núm. Prestamo.";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(22, 122);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Matrícula.";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(22, 151);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Fecha.";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(22, 180);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(159, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Fecha de devolución.";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(22, 209);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(135, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Núm. de libros.";
			// 
			// txtId_Prestamo
			// 
			this.txtId_Prestamo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtId_Prestamo.Location = new System.Drawing.Point(143, 90);
			this.txtId_Prestamo.Name = "txtId_Prestamo";
			this.txtId_Prestamo.Size = new System.Drawing.Size(137, 23);
			this.txtId_Prestamo.TabIndex = 5;
			// 
			// txtMatricula
			// 
			this.txtMatricula.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMatricula.Location = new System.Drawing.Point(143, 119);
			this.txtMatricula.Name = "txtMatricula";
			this.txtMatricula.Size = new System.Drawing.Size(137, 23);
			this.txtMatricula.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(22, 238);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(135, 45);
			this.label6.TabIndex = 10;
			this.label6.Text = "Fecha máxima de devolución.";
			// 
			// dtpFecha_Prestamo
			// 
			this.dtpFecha_Prestamo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFecha_Prestamo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha_Prestamo.Location = new System.Drawing.Point(143, 149);
			this.dtpFecha_Prestamo.Name = "dtpFecha_Prestamo";
			this.dtpFecha_Prestamo.Size = new System.Drawing.Size(137, 23);
			this.dtpFecha_Prestamo.TabIndex = 12;
			// 
			// dtpFecha_Devolucion
			// 
			this.dtpFecha_Devolucion.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFecha_Devolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha_Devolucion.Location = new System.Drawing.Point(143, 178);
			this.dtpFecha_Devolucion.Name = "dtpFecha_Devolucion";
			this.dtpFecha_Devolucion.Size = new System.Drawing.Size(137, 23);
			this.dtpFecha_Devolucion.TabIndex = 13;
			// 
			// txtBuscar
			// 
			this.txtBuscar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBuscar.Location = new System.Drawing.Point(286, 29);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(496, 23);
			this.txtBuscar.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(22, 29);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(258, 23);
			this.label7.TabIndex = 15;
			this.label7.Text = "Buscar libro por Titulo o por código ISBN.";
			// 
			// dgvPrestamos
			// 
			this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPrestamos.Location = new System.Drawing.Point(314, 90);
			this.dgvPrestamos.Name = "dgvPrestamos";
			this.dgvPrestamos.Size = new System.Drawing.Size(468, 150);
			this.dgvPrestamos.TabIndex = 16;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDown1.Location = new System.Drawing.Point(143, 207);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(137, 23);
			this.numericUpDown1.TabIndex = 17;
			this.numericUpDown1.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// dtpFecha_maxDevolucion
			// 
			this.dtpFecha_maxDevolucion.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFecha_maxDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha_maxDevolucion.Location = new System.Drawing.Point(143, 236);
			this.dtpFecha_maxDevolucion.Name = "dtpFecha_maxDevolucion";
			this.dtpFecha_maxDevolucion.Size = new System.Drawing.Size(137, 23);
			this.dtpFecha_maxDevolucion.TabIndex = 18;
			// 
			// frmPrestamos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(804, 288);
			this.Controls.Add(this.dtpFecha_maxDevolucion);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.dgvPrestamos);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.dtpFecha_Devolucion);
			this.Controls.Add(this.dtpFecha_Prestamo);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtMatricula);
			this.Controls.Add(this.txtId_Prestamo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "frmPrestamos";
			this.Text = "frmPrestamos";
			((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
