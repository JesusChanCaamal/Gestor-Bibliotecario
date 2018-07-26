/*
 * Created by SharpDevelop.
 * User: Crist
 * Date: 19/07/2018
 * Time: 07:57 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using AccesoADatos;
using System.Windows.Forms;

namespace softjace
{
	/// <summary>
	/// Description of usuarios.
	/// </summary>
	public class usuarios
	{
		public string Matricula;
		public string nombre;
		public string apellidoP;
		public string apellidoM;
		public string telefono;
		public string genero;
		public int edad;
		public string idlocalidad;
		public usuarios()
		{
			
		}
		
		public void filtrarUsuarios(string nom,DataGridView dgv)
		{
			
			string sql="SELECT u.Matricula,u.nombre,u.apellidoP,u.apellidoM,u.telefono,u.genero,u.edad,l.localidad,l.id_localidad" +
				" FROM usuarios as u INNER JOIN localidades as l ON u.id_localidad=l.id_localidad" +
				" WHERE u.nombre LIKE '"+nom+"%'";
			dgv.DataSource= FrameBD.SQLSEL(sql);
			dgv.DataMember="datos";
			dgv.Columns["id_localidad"].Visible=false;
		}
		
		public void guardar()
		{
			string sql= string.Format("CALL addUsuario('{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}');",Matricula,nombre,apellidoP,apellidoM,telefono,genero,edad,idlocalidad);
			FrameBD.SQLIDU(sql);
		}
		public void update()
		{
			string sql= string.Format("CALL updUsuario('{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}');",Matricula,nombre,apellidoP,apellidoM,telefono,genero,edad,idlocalidad);
			FrameBD.SQLIDU(sql);
		}
		public void eliminarUsuario(string matri)
		{
			string sql="DELETE FROM Usuarios WHERE Matricula='"+matri+"';";
			FrameBD.SQLIDU(sql);
		}
		public void getLocalidad(ComboBox cmb)
		{
			string consulta="SELECT id_Localidad,Localidad From localidades";
			cmb.DataSource=FrameBD.SQLCOMBO(consulta);
			cmb.DisplayMember="Localidad";
			cmb.ValueMember="id_Localidad";
		}
		
	}
}
