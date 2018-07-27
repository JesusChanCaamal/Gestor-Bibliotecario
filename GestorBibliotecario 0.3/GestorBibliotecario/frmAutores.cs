/*
 * Created by SharpDevelop.
 * User: abril
 * Date: 26/07/2018
 * Time: 09:32 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestorBibliotecario
{
	/// <summary>
	/// Description of frmAutores.
	/// </summary>
	public partial class frmAutores : Form
	{
		Autores oAutores =new Autores();
		Autores oAutor = new Autores ();
		
		public frmAutores()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void FrmAutoresLoad(object sender, EventArgs e)
		{
			oAutores.filtrarAutor(txtBusqueda.Text,dgvAutor);
		}
		void DgvAutorCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
		void BtnAgregarAutorClick(object sender, EventArgs e)
		{
			oAutor.nombre= txtNombre.Text;
			oAutor.apellidoP=txtP.Text;
			oAutor.apellidoM= txtM.Text;
			oAutor.pais=txtPais.Text;
			//libro.paginas=Convert.ToInt32(txtPaginas.Text);
			//libro.edicion=txtEdicion.Text;
			//libro.editorial=txtEditorial.Text;
			
			oAutor.Autor();
			
			dgvAutor.Rows.Add(txtNombre.Text,txtP.Text,txtM.Text,txtPais.Text);
		}
		
		
		
		
	}
}
