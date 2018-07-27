/*
 * Created by SharpDevelop.
 * User: abril
 * Date: 21/07/2018
 * Time: 06:32 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GestorBibliotecario
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void RegistrarNuevoLibroToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmLibros oLibros = new frmLibros();
			oLibros.MdiParent = this;
			oLibros.Show();
		}
		void RegistrarAutorToolStripMenuItemClick(object sender, EventArgs e)
		{
			frmAutores oAutores = new frmAutores();
			oAutores.MdiParent = this;
			oAutores.Show();
		}
	}
}
