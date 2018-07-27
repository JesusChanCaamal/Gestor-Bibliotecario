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
		
		public string titulo {get; set;}
		public string isbn {get; set;}
		public string genero {get; set;}
		public int paginas {get; set;}
		public string edicion{get; set;}
		public string editorial {get; set;}
		public int id_autor {get; set;}
		public int n_ejemplares {get; set;}
		public int disponible {get; set;}
		
		
			
		
		
		
		public libros()
		{
		}
		
		
		
	     /*public void actualizar(string codigo, string titulo,string isbn, string genero, string paginas, string edicion, string editorial )
		{
		
			string sql =string.Format("UPDATE libros SET Titulo='{1}',ISBN='{2}',Genero='{3}',N_paginas='{4}',Anio_Edicion={5},id_editorial='{6}'"+
			                          " WHERE codigo='{0}';",codigo,titulo,isbn,genero,paginas,edicion,editorial);
			
			//MessageBox.Show(sql);
				
			FrameBD.SQLIDU(sql);
		}*/
		
		
		
		
		
		public void libro(string isb)
		{
			string sql = "DELETE FROM libros WHERE ISBN ='" + isb + "';";
			FrameBD.SQLIDU(sql);
			
		}
		
		public void vib(string isb)
		{
			string sql = "DELETE FROM libros_autores WHERE ISBN ='" + isb  + "';";
			FrameBD.SQLIDU(sql);
			
		}
		
		public void ejmepla(string isb)
		{
			string sql = "DELETE FROM ejemplares WHERE ISBN ='" + isb+ "';";
			FrameBD.SQLIDU(sql);
			
		}
		
			
		public void lib()
		{
			//amacenamiento
			string sql =string.Format("CALL addLibros('{0}','{1}',{2},{3},{4},'{5}');",isbn,titulo,genero,editorial,paginas,edicion);
			
			
		
			FrameBD.SQLIDU(sql);
			
		}
		
		
		
		
		
		
		
		/*public void lib()
		{
			//amacenamiento
			string sql =string.Format("INSERT INTO libros (ISBN,Titulo,id_Genero,id_editorial,N_Paginas,Anio_edicion)" +  
                                      " VALUES ('{0}','{1}',{2},{3},{4},'{5}');",isbn,titulo,genero,editorial,paginas,edicion);
			
			
			
		
			FrameBD.SQLIDU(sql);
			
		}*/
		
		public void pivo()
		{
			Autores o = new Autores();
			string pivote = string.Format("INSERT INTO libros_autores(isbn,id_autor) VALUES('{0}',{1});",isbn,id_autor);
			FrameBD.SQLIDU(pivote);
		}
		
		public void pivoejemplares()
		{
			string pivote = string.Format("INSERT INTO ejemplares(isbn,n_ejemplares,Disponible) VALUES('{0}',{1},{1});",isbn,n_ejemplares);
			FrameBD.SQLIDU(pivote);	
		}
		
		
		
	
			public void filtrarlibros(string titu, DataGridView dgv)
		{
			string sql = "SELECT  a.ISBN,a.Titulo,a.id_Genero,n.genero,a.N_paginas,a.id_editorial,a.anio_edicion,m.editorial" +
                         " from (((libros as a INNER JOIN libros_autores as f ON f.ISBN=a.ISBN)" +
				         " INNER JOIN autores as s ON f.id_autor=s.id_autor)"+
				         " INNER JOIN generos as n ON a.id_genero=n.id_genero)"+
				         " INNER JOIN editoriales as m ON a.id_editorial=m.id_editorial"+
				        
                         " WHERE a.titulo like '" + titu+ "%'";

			
				dgv.DataSource=FrameBD.SQLSEL(sql);
			dgv.DataMember="datos";
			
			dgv.Columns["id_genero"].Visible=false;
			dgv.Columns["id_editorial"].Visible=false;
			
		}
			
			
			public void getAutores(ComboBox cmb)
		{
			string consulta="SELECT id_autor,concat(apellidop,' ',apellidom,' ',nombre) as Escritor FROM autores";
			cmb.DataSource=FrameBD.SQLCOMBO(consulta);
			cmb.DisplayMember="Escritor";
			cmb.ValueMember= "id_autor";
		}
			
		
			public void getGeneros(ComboBox cmb)
		{
			string consulta="SELECT id_Genero,genero FROM generos";
			cmb.DataSource=FrameBD.SQLCOMBO(consulta);
			cmb.DisplayMember="genero";
			cmb.ValueMember= "id_Genero";
		}
			
		
			public void getEditorial(ComboBox cmb)
		{
			string consulta="SELECT id_Editorial,Editorial FROM Editoriales";
			cmb.DataSource=FrameBD.SQLCOMBO(consulta);
			cmb.DisplayMember="Editorial";
			cmb.ValueMember= "id_Editorial";
			
		}	

			
		
		
		
	
		
	}
}
