/*
 * Created by SharpDevelop.
 * User: abril
 * Date: 26/07/2018
 * Time: 09:27 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using AccesoADatos;
using System.Windows.Forms;

namespace GestorBibliotecario
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
		
		// Tabla Autores.
		
		public void filtrarAutor(string autor, DataGridView dgv)
		{
			string sql = "SELECT a.id_autor,a.nombre,a.apellidoP,a.apellidoM,a.pais,s.ISBN,s.Titulo" +
                         " from ( autores as a INNER JOIN libros_autores as f ON f.id_autor=a.id_autor)" +
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
			
		public void Autor()
		{
			//amacenamiento
			string sql =string.Format("INSERT INTO autores (nombre,apellidoP,apellidoM,pais)" +  
                                      " VALUES ('{0}','{1}','{2}','{3}');",nombre, apellidoP,apellidoM,pais);
			FrameBD.SQLIDU(sql);
		}
		
		
	}
}
