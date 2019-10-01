/*
 * Creado por SharpDevelop.
 * Usuario: Oscar Diaz
 * Fecha: 03/05/2019
 * Hora: 10:37 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace Gonvill
{
	/// <summary>
	/// Description of CheckerControl.
	/// </summary>
	public partial class CheckerControl : UserControl
	{
		public NpgsqlConnection conexion = new NpgsqlConnection();
		
		public CheckerControl()
		{
			InitializeComponent();
		}
		
		///> Cuando se entra a la textBox para buscar, cambio el texto y los colores, igual cuando se deja
		/// TODO: ...
		void TbSearchEnter(object sender, EventArgs e)
		{
			if(tbSearch.Text == "ISBN"){
				tbSearch.Text = "";
				tbSearch.ForeColor = Color.FromArgb(24, 47, 88);
			}
			
		}
		
		void TbSearchLeave(object sender, EventArgs e)
		{
			if(tbSearch.Text == ""){
				tbSearch.Text = "ISBN";
				tbSearch.ForeColor = Color.FromArgb(122, 189, 219);
			}
		}
		////////////////////////////////////////////////////////////////////////////////////////////////<
		
		//> Cuando da click a iniciar sesión, se muestra la forma de inicio de sesión
		// TODO: ...
		void BtnLoginClick(object sender, EventArgs e)
		{
			LoginControl lgControl = new LoginControl();
			this.Controls.Add(lgControl);
			
			lgControl.BringToFront();
			
			//> Busco la mainform en las formas y actualizo el label de hasta arriba y le pongo Iniciar Sesión
			MainForm mForm;
			mForm = (MainForm)this.FindForm();
			
			mForm.labelPanelC.Text = "Iniciar Sesión"; // de priavado lo hago publico para poder acceder a el
			//<
		}
		/////////////////////////////////////////////////////////////////////////////////<
		
		//> Cuando dan click a la lupa para buscar
		void BtnSearchClick(object sender, EventArgs e)
		{
			//TODO: Buscar en la BD los datos que se ingresaron y mostrar los datos del libro encontrado o un error sino se ha encontrado
			
			lbNameBook.Text = "";
			lbAuthorBook.Text = "";
			lbISBN.Text = "";
			lbSec.Text = "";
			lbPrice.Text = "----";
			
			string sentencia;
			sentencia="SELECT libro.isbn, libro.nombre, autor.nombre, editorial.nombre, le.paginas, le.cantidad, libro.precio, area.seccion, area.ubicacion FROM libro " +
				"JOIN libro_autor ON libro.isbn=libro_autor.isbn JOIN autor ON autor.idAutor=libro_autor.idAutor JOIN libro_editorial as le ON  le.isbn=libro.isbn " +
				"JOIN editorial ON editorial.idEditorial=le.idEditorial JOIN area ON libro.idArea=area.idArea WHERE libro.isbn='"+tbSearch.Text+"';";
			
			conexion.ConnectionString = "Username = postgres; Password = 010999fco; Host = localhost;"+
				"Port = 5432; Database = Gonvill;";
			conexion.Open();
			NpgsqlCommand cmd = new NpgsqlCommand(sentencia, conexion);
			NpgsqlDataReader lector = cmd.ExecuteReader();
			
			if(lector.Read()){
				lbNameBook.Text = lector.GetString(lector.GetOrdinal("nombre"));
				lbAuthorBook.Text = lector.GetString(2);;
				lbISBN.Text = lector.GetString(lector.GetOrdinal("isbn"));
				lbSec.Text = lector.GetString(lector.GetOrdinal("seccion"));
				lbPrice.Text = lector.GetInt32(6).ToString();
				
			}else{
				if(tbSearch.Text == "ISBN"){
					MessageBox.Show("Introduzca un ISBN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}else{
					MessageBox.Show("No se encontro ese ISBN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			conexion.Close();
		}
		
		void CheckerControlLoad(object sender, EventArgs e)
		{
			lbNameBook.Text = "";
			lbAuthorBook.Text = "";
			lbISBN.Text = "";
			lbSec.Text = "";
			lbPrice.Text = "----";
		}
	}
}
