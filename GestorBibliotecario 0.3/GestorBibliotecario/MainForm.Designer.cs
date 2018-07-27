/*
 * Created by SharpDevelop.
 * User: abril
 * Date: 21/07/2018
 * Time: 06:32 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace GestorBibliotecario
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem registrarNuevoLibroToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem registrarAutorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem registarUsuarioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nuevoPrestamoToolStripMenuItem;
		
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevoPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.registrarNuevoLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.registrarAutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.registarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.prestamosToolStripMenuItem,
			this.librosToolStripMenuItem,
			this.usuariosToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(627, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// prestamosToolStripMenuItem
			// 
			this.prestamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.nuevoPrestamoToolStripMenuItem});
			this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
			this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
			this.prestamosToolStripMenuItem.Text = "Prestamos.";
			// 
			// nuevoPrestamoToolStripMenuItem
			// 
			this.nuevoPrestamoToolStripMenuItem.Name = "nuevoPrestamoToolStripMenuItem";
			this.nuevoPrestamoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
			this.nuevoPrestamoToolStripMenuItem.Text = "Nuevo prestamo.";
			// 
			// librosToolStripMenuItem
			// 
			this.librosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.registrarNuevoLibroToolStripMenuItem,
			this.registrarAutorToolStripMenuItem});
			this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
			this.librosToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.librosToolStripMenuItem.Text = "Libros.";
			// 
			// registrarNuevoLibroToolStripMenuItem
			// 
			this.registrarNuevoLibroToolStripMenuItem.Name = "registrarNuevoLibroToolStripMenuItem";
			this.registrarNuevoLibroToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.registrarNuevoLibroToolStripMenuItem.Text = "Registrar libro.";
			this.registrarNuevoLibroToolStripMenuItem.Click += new System.EventHandler(this.RegistrarNuevoLibroToolStripMenuItemClick);
			// 
			// registrarAutorToolStripMenuItem
			// 
			this.registrarAutorToolStripMenuItem.Name = "registrarAutorToolStripMenuItem";
			this.registrarAutorToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.registrarAutorToolStripMenuItem.Text = "Registrar autor.";
			this.registrarAutorToolStripMenuItem.Click += new System.EventHandler(this.RegistrarAutorToolStripMenuItemClick);
			// 
			// usuariosToolStripMenuItem
			// 
			this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.registarUsuarioToolStripMenuItem});
			this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
			this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.usuariosToolStripMenuItem.Text = "Usuarios.";
			// 
			// registarUsuarioToolStripMenuItem
			// 
			this.registarUsuarioToolStripMenuItem.Name = "registarUsuarioToolStripMenuItem";
			this.registarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
			this.registarUsuarioToolStripMenuItem.Text = "Registar usuario.";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(627, 276);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "GestorBibliotecario";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
