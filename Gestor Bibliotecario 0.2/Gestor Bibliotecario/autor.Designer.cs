/*
 * Created by SharpDevelop.
 * User: jfcha
 * Date: 23/07/2018
 * Time: 08:14 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Gestor_Bibliotecario
{
	partial class autor
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtM;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtP;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPais;
		private System.Windows.Forms.DataGridView dgvAutor;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtBusqueda;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		
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
			this.label3 = new System.Windows.Forms.Label();
			this.txtM = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtP = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPais = new System.Windows.Forms.TextBox();
			this.dgvAutor = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.txtBusqueda = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvAutor)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(51, 185);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 39;
			this.label3.Text = "Apellido Materno";
			// 
			// txtM
			// 
			this.txtM.Location = new System.Drawing.Point(156, 188);
			this.txtM.Name = "txtM";
			this.txtM.Size = new System.Drawing.Size(100, 20);
			this.txtM.TabIndex = 38;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(49, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 37;
			this.label2.Text = "Nombre del autor";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(154, 110);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(100, 20);
			this.txtNombre.TabIndex = 36;
			// 
			// txtP
			// 
			this.txtP.Location = new System.Drawing.Point(155, 147);
			this.txtP.Name = "txtP";
			this.txtP.Size = new System.Drawing.Size(100, 20);
			this.txtP.TabIndex = 35;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(49, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 34;
			this.label5.Text = "Apellido paterno";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(49, 230);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 41;
			this.label1.Text = "procedencia";
			// 
			// txtPais
			// 
			this.txtPais.Location = new System.Drawing.Point(154, 233);
			this.txtPais.Name = "txtPais";
			this.txtPais.Size = new System.Drawing.Size(100, 20);
			this.txtPais.TabIndex = 40;
			// 
			// dgvAutor
			// 
			this.dgvAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAutor.Location = new System.Drawing.Point(278, 110);
			this.dgvAutor.Name = "dgvAutor";
			this.dgvAutor.Size = new System.Drawing.Size(403, 150);
			this.dgvAutor.TabIndex = 42;
			this.dgvAutor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(242, 45);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 44;
			this.label4.Text = "Titulo del Libro";
			// 
			// txtBusqueda
			// 
			this.txtBusqueda.Location = new System.Drawing.Point(328, 42);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new System.Drawing.Size(353, 20);
			this.txtBusqueda.TabIndex = 43;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(37, 279);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(94, 37);
			this.button1.TabIndex = 46;
			this.button1.Text = "agregar autor";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(137, 279);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(104, 37);
			this.button2.TabIndex = 47;
			this.button2.Text = "Nuevo Autor";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(577, 279);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(104, 37);
			this.button3.TabIndex = 48;
			this.button3.Text = "selecionar Autor";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// autor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(776, 365);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
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
			this.Name = "autor";
			this.Text = "autor";
			this.Load += new System.EventHandler(this.AutorLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvAutor)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
