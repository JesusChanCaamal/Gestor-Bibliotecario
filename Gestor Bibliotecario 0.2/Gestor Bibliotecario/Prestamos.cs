/*
 * Created by SharpDevelop.
 * User: Crist
 * Date: 26/07/2018
 * Time: 08:03 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using AccesoADatos;
using System.Windows.Forms;
using Gestor_Bibliotecario;

namespace Prestamos_softjace
{
	
	/// <summary>
	/// Description of Prestamos.
	/// </summary>
	public class Prestamos
	{
		
		public int id_prestamos;
		public string Matricula;
		public string Fecha_Prestamo;
		public string Fecha_Devolucion;
		public int N_Libros;
		public string Fecha_Max;
		public int id_ejemplar;
		public Prestamos()
		{
		}
		public void filtrarPrestamo(string nom,DataGridView dgv)
		{
			
			string sql="SELECT u.Matricula,u.nombre,u.apellidoP,u.apellidoM,l.titulo,p.Fecha_prestamo,p.Fecha_Devolucion,p.N_libros,p.Fecha_maxDevolucion,p.id_prestamo,e.id_ejemplar" +
				" FROM (((usuarios as u INNER JOIN prestamos as p ON u.Matricula=p.Matricula) INNER JOIN Prestamos_Ejemplares as pe ON pe.id_prestamo=p.id_prestamo)" +
				" INNER JOIN Ejemplares as e ON e.id_ejemplar=pe.id_ejemplar)" +
				" INNER JOIN libros as l ON l.isbn=e.isbn" +
				" WHERE u.nombre LIKE '"+nom+"%'";
			dgv.DataSource= FrameBD.SQLSEL(sql);
			dgv.DataMember="datos";
			dgv.Columns["id_prestamo"].Visible=false;
			dgv.Columns["id_ejemplar"].Visible=false;
		}
		public void PrestamoEjemplar()
		{
			string sql=string.Format("INSER INTO Prestamos_ejemplares(id_prestamos,id_ejemplares) values({0},{1});",id_prestamos,id_ejemplar);
		}
			
			public void guardar()
		{
				string sql= string.Format("CALL addPrestamos('{0}','{1}','{2}',{3},'{4}');",Matricula,Fecha_Prestamo,Fecha_Devolucion,N_Libros,Fecha_Max);
			FrameBD.SQLIDU(sql);
		}
			public void getUsuario(ComboBox cmb,string matri)
		{
			string consulta="SELECT id_prestamos, From prestamos " +
				" where matricula=matri";
			cmb.DataSource=FrameBD.SQLCOMBO(consulta);
		 	cmb.ValueMember="id_prestamos";
		}
	}
}
