/*
 * Created by SharpDevelop.
 * User: jfcha
 * Date: 21/07/2018
 * Time: 01:08 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using AccesoADatos;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Gestor_Bibliotecario
{
	/// <summary>
	/// Description of libros.
	/// </summary>
	public class libros
	{
		public string codigo {get; set;}
		public string titulo {get; set;}
		public string isbn {get; set;}
		public string genero {get; set;}
		public double paginas {get; set;}
		public string edicion{get; set;}
		public string editorial {get; set;}
		public double precio {get; set;}
		
			public string nombre {get; set;}
		public string apellidoP {get; set;}
		public string apellidoM {get; set;}
		public string pais {get; set;}
		
		
		
		public libros()
		{
		}
		
		
		public void actualizar(string codigo, string titulo,string isbn, string genero, string paginas, string edicion, string editorial )
		{
		
			string sql =string.Format("UPDATE libros SET Titulo='{1}',ISBN='{2}',Genero='{3}',N_paginas='{4}',Anio_Edicion={5},id_editorial='{6}'"+
			                          " WHERE codigo='{0}';",codigo,titulo,isbn,genero,paginas,edicion,editorial);
			
			//MessageBox.Show(sql);
				
			FrameBD.SQLIDU(sql);
		}
		
		
		
		
		
		public void destroy(string placa)
		{
			string sql = "DELETE FROM libros WHERE codigo '" + codigo + "';";
			FrameBD.SQLIDU(sql);
			
		}
		
		
		
		public void lib(string idautor)
		{
			//amacenamiento
			string sql =string.Format("INSERT INTO libros (codigo,Titulo,ISBN,Genero,N_paginas,Anio_Edicion,id_editorial)" +  
                                      " VALUES ('{0}','{1}','{2}','{3}',{4},'{5}','{6}');",codigo,titulo,isbn,genero,paginas,edicion,editorial);
			
			string pivote = string.Format("INSERT INTO libro_autor VALUES('{0}','{1}')",isbn,idautor);
			
		
			FrameBD.SQLIDU(sql +  pivote);
		}
		
	
			public void filtrarlibros(string autor, DataGridView dgv)
		{
			string sql = "SELECT  a.codigo,a.Titulo,a.ISBN,a.Genero,a.N_paginas,a.Anio_Edicion,a.id_editorial,s.id_autor" +
                         " from (libros as a INNER JOIN libro_autor as f ON f.ISBN=a.ISBN)" +
				         " INNER JOIN autor as s ON f.id_autor=s.id_autor"+
                         " WHERE s.nombre like '" + autor + "%'";

			
				dgv.DataSource=FrameBD.SQLSEL(sql);
			dgv.DataMember="datos";
			
			
		}
		
		
		
		
	//tabla de autor;

	
		
		public void filtrarAutor(string autor, DataGridView dgv)
		{
			string sql = "SELECT a.id_autor,a.nombre,a.apellidoP,a.apellidoM,a.pais,s.ISBN,s.Titulo" +
                         " from ( autor as a INNER JOIN libro_autor as f ON f.id_autor=a.id_autor)" +
				         " INNER JOIN libros as s ON f.ISBN=s.ISBN"+
                         " WHERE s.titulo like '" + autor + "%'";
			
	
			
				dgv.DataSource=FrameBD.SQLSEL(sql);
			dgv.DataMember="datos";
			
			dgv.Columns["Titulo"].Visible=true;
		}	
		
		
			public void getFabricantes(ComboBox cmb)
		{
			string consulta="SELECT id_autor,concat(apellidop,' ',apellidom,' ',nombre) as Escritor FROM autor";
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
