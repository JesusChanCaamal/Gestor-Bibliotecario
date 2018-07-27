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
		Autores o = new Autores();
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
			libro.isbn= txtIsbn.Text;
			libro.titulo=txtTitulo.Text;
			libro.genero=cmbGenero.SelectedValue.ToString();
			libro.paginas=Convert.ToInt32(txtPaginas.Text);
			libro.editorial=cmbEditorial.SelectedValue.ToString();
			libro.edicion=txtEdicion.Text;
			libro.n_ejemplares=Convert.ToInt32(txtEjemplares.Text);
			
			libro.isbn=txtIsbn.Text;
			libro.id_autor=Convert.ToInt32(cmbAutor.SelectedValue);
			
			
			
			
			//oAuto.anio=Convert.ToInt32(txtAnio.Text);
			//oAuto.costo= Convert.ToDouble(txtCosto.Text);
			//libro.titulo= cmbFabricante.SelectedValue.ToString();
			
			libro.lib();
			libro.pivo();
			libro.pivoejemplares();
		
			datoslibros.filtrarlibros(txtBusqueda.Text,dgvLibros);
			
			if (txtTitulo.Text != "" && txtIsbn.Text != "" && txtPaginas.Text != "" && txtEdicion.Text != "" ) 
			{
			
				}else
						MessageBox.Show("te falto dato");
					
			if (txtTitulo.Text != "" && txtIsbn.Text != "" && txtPaginas.Text != "" && txtEdicion.Text != "")
			{
				btnNuevo.Enabled=true;
				
				
				}
			
			
	
		}
		
		void limpiarcampor()
		{
			txtTitulo.Clear();
			txtPaginas.Clear();
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

		   txtIsbn.Text = dgvLibros["isbn",dgvLibros.CurrentCellAddress.Y].Value.ToString();
		   txtTitulo.Text = dgvLibros["titulo",dgvLibros.CurrentCellAddress.Y].Value.ToString();
		   cmbGenero.Text = dgvLibros["id_genero",dgvLibros.CurrentCellAddress.Y].Value.ToString();
		   txtPaginas.Text = dgvLibros["n_paginas",dgvLibros.CurrentCellAddress.Y].Value.ToString();
		   cmbEditorial.Text= dgvLibros["id_editorial",dgvLibros.CurrentCellAddress.Y].Value.ToString();
		   txtEdicion.Text = dgvLibros["anio_edicion",dgvLibros.CurrentCellAddress.Y].Value.ToString();
		   cmbGenero.SelectedValue=dgvLibros["id_genero",dgvLibros.CurrentCellAddress.Y].Value.ToString();
		   cmbEditorial.SelectedValue=dgvLibros["id_editorial",dgvLibros.CurrentCellAddress.Y].Value.ToString();
		   txtEjemplares.Text=dgvLibros["id_ejemplares",dgvLibros.CurrentCellAddress.Y].Value.ToString();
		
	
		}
		void BtnEdicionClick(object sender, EventArgs e)
		{
			//libro.actualizar(txtTitulo.Text,txtIsbn.Text,txtPaginas.Text,txtEdicion.Text);
	
		}
		void BtnBajaClick(object sender, EventArgs e)
		{
			
			
		string isbn=dgvLibros[0,dgvLibros.CurrentCellAddress.Y].Value.ToString();
			if (MessageBox.Show("Esta Seguro de elimiar libro com ISBN:"
			                    + isbn,"cuidado",MessageBoxButtons.YesNo,
			                    MessageBoxIcon.Exclamation)==DialogResult.Yes)
			                   
			                   
				
			{
			libro.libro(isbn);
			libro.vib(isbn);
			libro.ejmepla(isbn);
			libro.filtrarlibros(txtBusqueda.Text,dgvLibros);
			}
			
			
			                   
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			
			datoslibros.filtrarlibros(txtBusqueda.Text,dgvLibros);
			datoslibros.getAutores(cmbAutor);
			datoslibros.getGeneros(cmbGenero);
			datoslibros.getEditorial(cmbEditorial);
		}
		void BtnAutorClick(object sender, EventArgs e)
		{
			autor main = new autor();
			
			main.Show();
	
		}
		void TxtBusquedaTextChanged(object sender, EventArgs e)
		{
			libro.filtrarlibros(txtBusqueda.Text,dgvLibros);
	
		}
		
		
		
				
			
	
		
		
		
			
		
		
		
		
		
		
		
		
		
		
		
	}
}
