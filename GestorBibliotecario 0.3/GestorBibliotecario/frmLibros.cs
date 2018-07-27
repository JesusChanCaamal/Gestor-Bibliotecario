/*
 * Created by SharpDevelop.
 * User: abril
 * Date: 26/07/2018
 * Time: 09:46 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestorBibliotecario
{
	/// <summary>
	/// Description of frmLibros.
	/// </summary>
	public partial class frmLibros : Form
	{
		
		Libros Libro = new Libros();
		Libros DatosLibros = new Libros();
		Autores o = new Autores();
		
		
		public frmLibros()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void FrmLibrosLoad(object sender, EventArgs e)
		{
			DatosLibros.filtrarlibros(txtBusqueda.Text,dgvLibros);
			DatosLibros.getAutores(cmbAutor);
			DatosLibros.getGeneros(cmbGenero);
			DatosLibros.getEditorial(cmbEditorial);
		}
		void BtnRegistrarClick(object sender, EventArgs e)
		{
			Libro.isbn= txtIsbn.Text;
			Libro.titulo=txtTitulo.Text;
			Libro.genero=cmbGenero.SelectedValue.ToString();
			Libro.paginas=Convert.ToInt32(txtPaginas.Text);
			Libro.editorial=cmbEditorial.SelectedValue.ToString();
			Libro.edicion=txtEdicion.Text;
			
			Libro.isbn=txtIsbn.Text;
			Libro.id_autor=Convert.ToInt32(cmbAutor.SelectedValue);
			
			Libro.lib();
			Libro.pivo();
		
			DatosLibros.filtrarlibros(txtBusqueda.Text,dgvLibros);
			
			if (txtTitulo.Text != "" && txtIsbn.Text != "" && txtPaginas.Text != "" && txtEdicion.Text != "" ) 
			{
			
			}else
			{
				MessageBox.Show("te falto dato");
			}
			
			if (txtTitulo.Text != "" && txtIsbn.Text != "" && txtPaginas.Text != "" && txtEdicion.Text != "")
			{
				btnNuevo.Enabled=true;
			}
		}
		
		void LimpiarCamp()
		{
			txtTitulo.Clear();
			txtPaginas.Clear();
			txtEdicion.Clear();
			txtTitulo.Focus();
		}
		
		void BtnAutorClick(object sender, EventArgs e)
		{
			frmAutores Main = new frmAutores();
			Main.Show();
		}
		
		void BtnNuevoClick(object sender, EventArgs e)
		{
			LimpiarCamp();
			btnNuevo.Enabled=false;
		}
		
		
		/*void BtnEditarClick(object sender, EventArgs e)
		{
			txtIsbn.Text = dgvLibros["isbn",dgvLibros.CurrentCellAddress.Y].Value.ToString();
		    txtTitulo.Text = dgvLibros["titulo",dgvLibros.CurrentCellAddress.Y].Value.ToString();
		    cmbGenero.Text = dgvLibros["id_genero",dgvLibros.CurrentCellAddress.Y].Value.ToString();
			
			txtPaginas.Text = dgvLibros["n_paginas",dgvLibros.CurrentCellAddress.Y].Value.ToString();
			cmbEditorial.Text= dgvLibros["id_editorial",dgvLibros.CurrentCellAddress.Y].Value.ToString();
			txtEdicion.Text = dgvLibros["anio_edicion",dgvLibros.CurrentCellAddress.Y].Value.ToString();
		
		}
		
		void BtnEdicionClick(object sender, EventArgs e)
		{
			libro.actualizar(txtTitulo.Text,txtIsbn.Text,txtPaginas.Text,txtEdicion.Text);
		}
		
		void BtnBajaClick(object sender, EventArgs e)
		{
			string codigo=dgvLibros["codigo",dgvLibros.CurrentCellAddress.Y].Value.ToString();
			if (MessageBox.Show("Esta Seguro de elimiar auto com placa:"+
			                   "cuidado",MessageBoxButtons.YesNo,
			                    MessageBoxIcon.Exclamation)==DialogResult.Yes)
			
			{
				libro.destroy(codigo);
			}
			                 
		}
		*/
		
	}
}
