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
			oUsuarios.telefono=txtTelefono.Text;
			oUsuarios.edad=Convert.ToInt32(txtEdad.Text);
			oUsuarios.idlocalidad=cmbLocalidad.SelectedValue.ToString();
			
			oUsuarios.update();
			oUsuarios.filtrarUsuarios(txtBuscar.Text,dgvUsuarios);
			btnGuardar.Visible=true;
			btnGuardarE.Visible=false;
			txtMatricula.ReadOnly=false;
			limpiar();
			
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			oUsuarios.Matricula=txtMatricula.Text;
			oUsuarios.nombre=txtNombre.Text;
			oUsuarios.apellidoP=txtApellidoP.Text;
			oUsuarios.apellidoM=txtApellidoM.Text;
			oUsuarios.genero=txtGenero.Text;
			oUsuarios.telefono=txtTelefono.Text;
			oUsuarios.edad=Convert.ToInt32(txtEdad.Text);
			oUsuarios.idlocalidad=cmbLocalidad.SelectedValue.ToString();
			
			oUsuarios.guardar();
			oUsuarios.filtrarUsuarios(txtBuscar.Text,dgvUsuarios);
			limpiar();
		}
		void Label4Click(object sender, EventArgs e)
		{
	
		}
		void BtnEliminarClick(object sender, EventArgs e)
		{
			string Matricula=dgvUsuarios[0,dgvUsuarios.CurrentCellAddress.Y].Value.ToString();
			if (MessageBox.Show("Esta seguro de eliminar auto con MATRICULA :"+
			                    Matricula,"cuidado",MessageBoxButtons.YesNo,
			                    MessageBoxIcon.Exclamation)==DialogResult.Yes) 
			{
				oUsuarios.eliminarUsuario(Matricula);
				oUsuarios.filtrarUsuarios(txtBuscar.Text,dgvUsuarios);
			}
		}
		void BtnEditarClick(object sender, EventArgs e)
		{
				//se oculta el boton de guardar
			btnGuardar.Visible=false;
			//asemos visible el boton de actualizar
			btnGuardarE.Visible=true;
			
			//evitamos que pueda cambiar la placa
			txtMatricula.ReadOnly=true;
			
			//pasamos la placa al txtplaca
			txtMatricula.Text= dgvUsuarios[0,dgvUsuarios.CurrentCellAddress.Y].Value.ToString();
			txtNombre.Text= dgvUsuarios["nombre",dgvUsuarios.CurrentCellAddress.Y].Value.ToString();
			txtApellidoP.Text= dgvUsuarios["apellidoP",dgvUsuarios.CurrentCellAddress.Y].Value.ToString();
			txtApellidoM.Text= dgvUsuarios["apellidoM",dgvUsuarios.CurrentCellAddress.Y].Value.ToString();
			txtTelefono.Text=dgvUsuarios["telefono",dgvUsuarios.CurrentCellAddress.Y].Value.ToString();
			txtGenero.Text=dgvUsuarios["genero",dgvUsuarios.CurrentCellAddress.Y].Value.ToString();
			txtEdad.Text=dgvUsuarios["edad",dgvUsuarios.CurrentCellAddress.Y].Value.ToString();
			//mover la clave del fabricante en el combobox
			cmbLocalidad.SelectedValue=dgvUsuarios["id_Localidad",dgvUsuarios.CurrentCellAddress.Y].Value;
		}
		void TxtBuscarTextChanged(object sender, EventArgs e)
		{
			oUsuarios.filtrarUsuarios(txtBuscar.Text,dgvUsuarios);
		}
		void limpiar()
		{
			txtNombre.Clear();
			txtApellidoP.Clear();
			txtApellidoM.Clear();
			txtGenero.Clear();
			txtTelefono.Clear();
			txtEdad.Clear();
			txtMatricula.Clear();
			txtMatricula.Focus();
		}
	}
}
