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
		
		
		
		public void lib()
		{
			//amacenamiento
			string sql =string.Format("INSERT INTO libros (codigo,Titulo,ISBN,Genero,N_paginas,Anio_Edicion,id_editorial)" +  
                                      " VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}');",codigo,titulo,isbn,genero,paginas,edicion,editorial);
			FrameBD.SQLIDU(sql);
		}
		
	
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
	}
}
