/*
 * Created by SharpDevelop.
 * User: jfcha
 * Date: 17/07/2018
 * Time: 08:58 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Gestor_Bibliotecario
{
	
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		libros libro = new libros();
		libros datoslibros = new libros();
		
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
		
		void BtnRegistrarClick(object sender, EventArgs e)
		{
			
			libro.codigo= txtCodigo.Text;
			libro.titulo=txtTitulo.Text;
			libro.isbn= txtIsbn.Text;
			libro.genero=txtGenero.Text;
			libro.paginas=Convert.ToInt32(txtPaginas.Text);
			libro.edicion=txtEdicion.Text;
			libro.editorial=txtEditorial.Text;
			
			
			//oAuto.anio=Convert.ToInt32(txtAnio.Text);
			//oAuto.costo= Convert.ToDouble(txtCosto.Text);
			//libro.titulo= cmbFabricante.SelectedValue.ToString();
			
			libro.lib(cmbAutor.SelectedValue.ToString());
		
			
			
			if (txtCodigo.Text != "" && txtTitulo.Text != "" && txtIsbn.Text != "" && txtGenero.Text !="" && txtPaginas.Text != "" && txtEdicion.Text != "" && txtEditorial.Text != ""  ) 
			{
			
				}else
						MessageBox.Show("te falto dato");
					
			if (txtCodigo.Text != "" && txtTitulo.Text != "" && txtIsbn.Text != "" && txtGenero.Text !="" && txtPaginas.Text != "" && txtEdicion.Text != "" && txtEditorial.Text != "" )
			{
				btnNuevo.Enabled=true;
				
				
				}
			datoslibros.filtrarlibros(txtBusqueda.Text,dgvLibros);
			
	
		}
		
		void limpiarcampor()
		{
			txtTitulo.Clear();
			txtPaginas.Clear();
			txtGenero.Clear();
			txtEditorial.Clear();
			txtEdicion.Clear();
			
			txtTitulo.Focus();
		}
		
		
		
		void BtnNuevoClick(object sender, EventArgs e)
		{
			limpiarcampor();
			btnNuevo.Enabled=false;
	
		}
		void BtnEditarClick(object sender, EventArgs e)
		{
			txtCodigo.Text = dgvLibros["codigo",dgvLibros.CurrentCellAddress.Y].Value.ToString();
				//pasamos de dgv a los txt para poder editar un dato
				
			txtTitulo.Text = dgvLibros["titulo",dgvLibros.CurrentCellAddress.Y].Value.ToString();
			//pasamos fabricamte
			txtIsbn.Text = dgvLibros["isbn",dgvLibros.CurrentCellAddress.Y].Value.ToString();
			txtGenero.Text = dgvLibros["genero",dgvLibros.CurrentCellAddress.Y].Value.ToString();
			//pasamos modelo
			txtPaginas.Text = dgvLibros["paginas",dgvLibros.CurrentCellAddress.Y].Value.ToString();
			//pasamos anio
			txtEdicion.Text = dgvLibros["edicion",dgvLibros.CurrentCellAddress.Y].Value.ToString();
			//pasamos costo
			txtEditorial.Text = dgvLibros["editorial",dgvLibros.CurrentCellAddress.Y].Value.ToString();
			
		
	
		}
		void BtnEdicionClick(object sender, EventArgs e)
		{
			libro.actualizar(txtCodigo.Text,txtTitulo.Text,txtIsbn.Text,txtGenero.Text,txtPaginas.Text,txtEdicion.Text,txtEditorial.Text);
	
		}
		void BtnBajaClick(object sender, EventArgs e)
		{
			
			
			
			/*string codigo=dgvLibros["codigo",dgvLibros.CurrentCellAddress.Y].Value.ToString();
			if (MessageBox.Show("Esta Seguro de elimiar auto com placa:"+
			                   "cuidado",MessageBoxButtons.YesNo,
			                    MessageBoxIcon.Exclamation)==DialogResult.Yes)*/
			                   
				
			{
			//libro.destroy(codigo);
			
			}
			
			
			                   
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			
			datoslibros.filtrarlibros(txtBusqueda.Text,dgvLibros);
			datoslibros.getFabricantes(cmbAutor);
		}
		void BtnAutorClick(object sender, EventArgs e)
		{
			autor main = new autor();
			
			main.Show();
	
		}
		
		
				
			
	
		
		
		
			
		
		
		
		
		
		
		
		
		
		
		
	}
}
