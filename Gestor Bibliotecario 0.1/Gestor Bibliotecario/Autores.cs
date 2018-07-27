/*
 * Created by SharpDevelop.
 * User: jfcha
 * Date: 25/07/2018
 * Time: 11:51 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using AccesoADatos;
using System.Windows.Forms;

namespace Gestor_Bibliotecario
{
	/// <summary>
	/// Description of Autores.
	/// </summary>
	public class Autores
	{
		public string nombre {get; set;}
		public string apellidoP {get; set;}
		public string apellidoM {get; set;}
		public string pais {get; set;}
		public string id_autores{ get; set;}
		
		
		public Autores()
		{
		}
		
			
	//tabla de autor;

	
		
		public void filtrarAutor(string autor, DataGridView dgv)
		{
			string sql = "SELECT a.id_autor,a.nombre,a.apellidoP,a.apellidoM,a.pais,s.ISBN,s.Titulo" +
                         " from ( autor as a INNER JOIN libros_autores as f ON f.id_autor=a.id_autor)" +
				         " INNER JOIN libros as s ON f.ISBN=s.ISBN"+
                         " WHERE s.titulo like '" + autor + "%'";
			
	
			
				dgv.DataSource=FrameBD.SQLSEL(sql);
			dgv.DataMember="datos";
			
			dgv.Columns["Titulo"].Visible=true;
		}	
		
		
			public void getFabricantes(ComboBox cmb)
		{
			string consulta="SELECT id_autor,concat(apellidop,' ',apellidom,' ',nombre) as Escritor FROM autores";
			cmb.DataSource=FrameBD.SQLCOMBO(consulta);
			cmb.DisplayMember="Escritor";
			cmb.ValueMember= "id_autor";
		}
		
			
			
		public void autor()
		{
			//amacenamiento
			string sql =string.Format("INSERT INTO autor (nombre,apellidoP,apellidoM,pais)" +  
                                      " VALUES ('{0}','{1}','{2}','{3}');",nombre, apellidoP,apellidoM,pais);
			FrameBD.SQLIDU(sql);
		}
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
	}
}
