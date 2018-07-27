/*
 * Created by SharpDevelop.
 * User: jfcha
 * Date: 23/07/2018
 * Time: 08:14 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Gestor_Bibliotecario
{
	/// <summary>
	/// Description of autor.
	/// </summary>
	public partial class autor : Form
	{
		Autores autores =new Autores();
		Autores auto = new Autores ();
		public autor()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void AutorLoad(object sender, EventArgs e)
		{
				autores.filtrarAutor(txtBusqueda.Text,dgvAutor);
	
		}
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			auto.nombre= txtNombre.Text;
			auto.apellidoP=txtP.Text;
			auto.apellidoM= txtM.Text;
			auto.pais=txtPais.Text;
			//libro.paginas=Convert.ToInt32(txtPaginas.Text);
			//libro.edicion=txtEdicion.Text;
			//libro.editorial=txtEditorial.Text;
			
			auto.autor();
			
			dgvAutor.Rows.Add(txtNombre.Text,txtP.Text,txtM.Text,txtPais.Text);
		
	
		}
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
	}
}
