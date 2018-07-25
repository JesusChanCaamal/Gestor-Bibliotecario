/*
 * Created by SharpDevelop.
 * User: Crist
 * Date: 19/07/2018
 * Time: 07:57 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using AccesoADatos;

namespace softjace
{
	/// <summary>
	/// Description of frmUsuarios.
	/// </summary>
	public partial class frmUsuarios : Form
	{
		usuarios oUsuarios = new usuarios();
		public frmUsuarios()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void FrmUsuariosLoad(object sender, EventArgs e)
		{
			oUsuarios.filtrarUsuarios(txtBuscar.Text,dgvUsuarios);
			oUsuarios.getLocalidad(cmbLocalidad);
		}
		void BtnGuardarEClick(object sender, EventArgs e)
		{
			oUsuarios.Matricula=txtMatricula.Text;
			oUsuarios.nombre=txtNombre.Text;
			oUsuarios.apellidoP=txtApellidoP.Text;
			oUsuarios.apellidoM=txtApellidoM.Text;
			oUsuarios.genero=txtGenero.Text;
			oUsuarios.telefono=Convert.ToInt32(txtTelefono.Text);
			oUsuarios.edad=Convert.ToInt32(txtEdad.Text);
			oUsuarios.idlocalidad=cmbLocalidad.Text;
			
			oUsuarios.guardar();
			oUsuarios.filtrarUsuarios(txtBuscar.Text,dgvUsuarios);
			
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			oUsuarios.Matricula=txtMatricula.Text;
			oUsuarios.nombre=txtNombre.Text;
			oUsuarios.apellidoP=txtApellidoP.Text;
			oUsuarios.apellidoM=txtApellidoM.Text;
			oUsuarios.genero=txtGenero.Text;
			oUsuarios.telefono=Convert.ToInt32(txtTelefono.Text);
			oUsuarios.edad=Convert.ToInt32(txtEdad.Text);
			oUsuarios.idlocalidad=cmbLocalidad.SelectedValue.ToString();
			
			oUsuarios.guardar();
			oUsuarios.filtrarUsuarios(txtBuscar.Text,dgvUsuarios);
		}
		void Label4Click(object sender, EventArgs e)
		{
	
		}
	}
}
