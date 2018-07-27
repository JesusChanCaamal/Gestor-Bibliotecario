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

namespace Prestamos_softjace
{
	/// <summary>
	/// Description of Prestamos.
	/// </summary>
	public class Prestamos
	{
		public string id_prestamos;
		public string Matricula;
		public string Fecha_Prestamo;
		public string Fecha_Devolucion;
		public int N_Libros;
		public string Fecha_Max;
		public Prestamos()
		{
		}
		public void filtrarPrestamo(string nom,DataGridView dgv)
		{
			
			string sql="SELECT u.Matricula,u.nombre,u.apellidoP,u.apellidoM,p.Fecha_prestamo,p.Fecha_Devolucion,p.N_libros,p.Fecha_maxDevolucion,p.id_prestamo" +
				" FROM usuarios as u INNER JOIN prestamos as p ON u.Matricula=p.Matricula" +
				" WHERE u.nombre LIKE '"+nom+"%'";
			dgv.DataSource= FrameBD.SQLSEL(sql);
			dgv.DataMember="datos";
			dgv.Columns["id_prestamo"].Visible=false;
		}
			public void filtrarlibros(string autor, DataGridView dgv)
		{
			string sql = "SELECT  a.ISBN,a.Titulo,a.id_Genero,n.genero,a.N_paginas,a.id_editorial,a.anio_edicion,m.editorial" +
                         " from (((libros as a INNER JOIN libros_autores as f ON f.ISBN=a.ISBN)" +
				         " INNER JOIN autores as s ON f.id_autor=s.id_autor)"+
				         " INNER JOIN generos as n ON a.id_genero=n.id_genero)"+
				         " INNER JOIN editoriales as m ON a.id_editorial=m.id_editorial "+
                         " WHERE s.nombre like '" + autor + "%'";

			
				dgv.DataSource=FrameBD.SQLSEL(sql);
			dgv.DataMember="datos";
			
			dgv.Columns["id_genero"].Visible=false;
			dgv.Columns["id_editorial"].Visible=false;
			
		}
			public void guardar()
		{
				string sql= string.Format("CALL addPrestamos('{0}','{1}','{2}',{3},'{4}');",Matricula,Fecha_Prestamo,Fecha_Devolucion,N_Libros,Fecha_Max);
			FrameBD.SQLIDU(sql);
		}
			public void getUsuario(ComboBox cmb)
		{
			string consulta="SELECT Matricula,Nombre From usuarios";
			cmb.DataSource=FrameBD.SQLCOMBO(consulta);
			cmb.DisplayMember="Nombre";
			cmb.ValueMember="Matricula";
		}
	}
}
