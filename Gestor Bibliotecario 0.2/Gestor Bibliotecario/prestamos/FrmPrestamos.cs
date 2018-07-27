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

namespace Prestamos_softjace
{
	/// <summary>
	/// Description of FrmPrestamos.
	/// </summary>
	public partial class FrmPrestamos : Form
	{
		Prestamos oPrestamo = new Prestamos();
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
			oPrestamo.filtrarlibros(txtBuscar.Text,dgvPrestamos);
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
			
			oPrestamo.guardar();
			
		}
	}
}
