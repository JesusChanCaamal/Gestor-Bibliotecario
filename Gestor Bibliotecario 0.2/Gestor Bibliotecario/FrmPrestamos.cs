/*
 * Created by SharpDevelop.
 * User: Crist
 * Date: 25/07/2018
 * Time: 10:54 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Gestor_Bibliotecario;

namespace Prestamos_softjace
{
	/// <summary>
	/// Description of FrmPrestamos.
	/// </summary>
	public partial class FrmPrestamos : Form
	{
		Prestamos oPrestamo = new Prestamos();
		libros oLibros = new libros();
		
		public FrmPrestamos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void FrmPrestamosLoad(object sender, EventArgs e)
		{
			oPrestamo.filtrarPrestamo(txtBuscar.Text,dgvPrestamos);
			oPrestamo.getUsuario(cmbUsuario);
		}
		void BtnVlibrosClick(object sender, EventArgs e)
		{
			oLibros.filtrarlibros(txtBuscar.Text,dgvPrestamos);
		}
		void BtnVprestamosClick(object sender, EventArgs e)
		{
			oPrestamo.filtrarPrestamo(txtBuscar.Text,dgvPrestamos);
			oPrestamo.getUsuario(cmbUsuario);
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			oPrestamo.Matricula=cmbUsuario.SelectedValue.ToString();;
			oPrestamo.Fecha_Prestamo=txtPrestamo.Text;
			oPrestamo.Fecha_Devolucion=txtDevolucion.Text;
			oPrestamo.Fecha_Max=txtMax.Text;
			oPrestamo.N_Libros=Convert.ToInt32(txtNlibros);
			oPrestamo.id_ejemplar=Convert.ToInt32(dgvPrestamos["id_ejemplar",dgvPrestamos.CurrentCellAddress.Y].Value);
			oPrestamo.id_prestamos=Convert.ToInt32(dgvPrestamos["id_prestamos",dgvPrestamos.CurrentCellAddress.Y].Value);
			oPrestamo.guardar();
			//oPrestamo.PrestamoEjemplar();
			
		}
		void BtnPrestarClick(object sender, EventArgs e)
		{
			//evitamos que pueda cambiar la placa
			
			//pasamos la placa al txtplaca
			/*txtPrestamo.Text= dgvPrestamos["Fecha_Prestamo",dgvPrestamos.CurrentCellAddress.Y].Value.ToString();
			txtDevolucion.Text= dgvPrestamos["Fecha_Devolucion",dgvPrestamos.CurrentCellAddress.Y].Value.ToString();
			txtMax.Text= dgvPrestamos["Fecha_maxDevolucion",dgvPrestamos.CurrentCellAddress.Y].Value.ToString();
			txtNlibros.Text= dgvPrestamos["N_libros",dgvPrestamos.CurrentCellAddress.Y].Value.ToString()
			//mover la clave del fabricante en el combobox
			cmbUsuario.SelectedValue=dgvPrestamos["Matricula",dgvPrestamos.CurrentCellAddress.Y].Value;*/
			txtLibro.Text= dgvPrestamos["titulo",dgvPrestamos.CurrentCellAddress.Y].Value.ToString();
		}
	}
}
