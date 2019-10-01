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
	/// Description of SearchControl.
	/// </summary>
	public partial class SearchControl : UserControl
	{
		public NpgsqlConnection conexion = new NpgsqlConnection();
		
		
		public SearchControl()
		{
			InitializeComponent();
		}
		
		
		/// > Cuando se entra a las textbox para buscar se quita lo que dice y se cambia el color
		void TbSNameEnter(object sender, EventArgs e)
		{
			/*if(tbSName.Text == "Nombre"){
				tbSName.Text = "";
				tbSName.ForeColor = Color.FromArgb(24, 47, 88);
			}*/
		}
		
		void TbSNameLeave(object sender, EventArgs e)
		{
			/*if(tbSName.Text == ""){
				tbSName.Text = "Nombre";
				tbSName.ForeColor = Color.FromArgb(122, 189, 219);
			}*/
		}
		
		void TbSAuthorEnter(object sender, EventArgs e)
		{
			/*if(tbSAuthor.Text == "Autor"){
				tbSAuthor.Text = "";
				tbSAuthor.ForeColor = Color.FromArgb(24, 47, 88);
			}*/
		}
		
		void TbSAuthorLeave(object sender, EventArgs e)
		{
			/*if(tbSAuthor.Text == ""){
				tbSAuthor.Text = "Autor";
				tbSAuthor.ForeColor = Color.FromArgb(122, 189, 219);
			}*/
		}
		
		void TbSCodeEnter(object sender, EventArgs e)
		{
			/*if(tbSCode.Text == "ISBN, Código"){
				tbSCode.Text = "";
				tbSCode.ForeColor = Color.FromArgb(24, 47, 88);
			}*/
		}
		
		void TbSCodeLeave(object sender, EventArgs e)
		{
			/*if(tbSCode.Text == ""){
				tbSCode.Text = "ISBN, Código";
				tbSCode.ForeColor = Color.FromArgb(122, 189, 219);
			}*/
		}
		/// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// /// <
		
		//> Cuando le da click en buscar
		void BtnSearchClick(object sender, EventArgs e)
		{
			// TODO: Buscar datos en la BD los datos, ya sea por nombre, autor, codigo o ISBN y si encontro resultados
			//		  se añaden a la GRIDBIEW
			string sentencia = "SELECT *FROM libro;";
			
			conexion.ConnectionString = "Username = postgres; Password = 010999fco; Host = localhost;"+
					"Port = 5432; Database = Gonvill;";
				conexion.Open();
				NpgsqlCommand cmd = new NpgsqlCommand(sentencia, conexion);
				NpgsqlDataReader lector = cmd.ExecuteReader();
			
			if(tbSName.Text != "" || tbSAuthor.Text != "" || tbSCode.Text != ""){ // Si dabas a la lupa y no había datos crasheaba
				if(validarTextbox() == 1){
					sentencia = sentenciaISBN();
				}
				
				if(validarTextbox() == 2){
					sentencia = sentenciaNombre();
				}
				
				if(validarTextbox() == 3){
					sentencia = sentenciaAutor();
				}
					
				if(lector.Read()){
					
					conexion.Close();
					cargarDataView(conexion, sentencia, cmd, lector);
					
				} else{
					MessageBox.Show("No se encotro el libro");
				}
			}else{
					MessageBox.Show("Introduce un dato para buscar el libro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			conexion.Close();
		}
		
		///> Cuando le da click en el icono regresar volvemos a la form de cotizaciones
		void BtnReturnClick(object sender, EventArgs e)
		{
			// TODO: ...
			
			//> En lugar de mostrar el Quotation control simplemente oculto este para no perder la información que tenemos
			this.Hide();
			
			//> Busco la mainform en las formas y actualizo el label de hasta arriba y le pongo cotizaciones
			MainForm mForm;
			mForm = (MainForm)this.FindForm();
			
			mForm.labelPanelC.Text = "Cotizaciones"; // de priavado lo hago publico para poder acceder a el
			//<
		}
		
		void cargarDataView(NpgsqlConnection connect, string sentencia, NpgsqlCommand cmd, NpgsqlDataReader lector){
			
			dgvSearch.Rows.Clear();
			conexion.Open();
			cmd = new NpgsqlCommand(sentencia, conexion);
			lector = cmd.ExecuteReader();
			
			while(lector.Read()){
				int renglon = dgvSearch.Rows.Add();

				
				dgvSearch.Rows[renglon].Cells["isbn"].Value =
					lector.GetString(lector.GetOrdinal("isbn"));
				
				dgvSearch.Rows[renglon].Cells["nombre"].Value =
					lector.GetString(lector.GetOrdinal("nombre"));
				
				dgvSearch.Rows[renglon].Cells["autor"].Value =
					lector.GetString(2);
				
				dgvSearch.Rows[renglon].Cells["editorial"].Value =
					lector.GetString(3);
				
				
				dgvSearch.Rows[renglon].Cells["paginas"].Value =
					lector.GetInt32(4).ToString();
				
				dgvSearch.Rows[renglon].Cells["cantidad"].Value =
					lector.GetInt32(5).ToString();
				
				
				 dgvSearch.Rows[renglon].Cells["precio"].Value =
                	lector.GetInt32(6).ToString();
				
				
				dgvSearch.Rows[renglon].Cells["seccion"].Value =
					lector.GetString(lector.GetOrdinal("seccion"));
				
				dgvSearch.Rows[renglon].Cells["ubicacion"].Value =
					lector.GetString(lector.GetOrdinal("ubicacion"));
				
			}
			conexion.Close();
		}
		
		
		string sentenciaISBN(){
			
			string sentencia="SELECT libro.isbn, libro.nombre, autor.nombre, editorial.nombre, le.paginas, le.cantidad, libro.precio, area.seccion, area.ubicacion FROM libro " +
				"JOIN libro_autor ON libro.isbn=libro_autor.isbn JOIN autor ON autor.idAutor=libro_autor.idAutor JOIN libro_editorial as le ON  le.isbn=libro.isbn " +
				"JOIN editorial ON editorial.idEditorial=le.idEditorial JOIN area ON libro.idArea=area.idArea WHERE libro.isbn='"+tbSCode.Text+"';";
			
			return sentencia;
		}
		string sentenciaNombre(){
			
			string sentencia="SELECT libro.isbn, libro.nombre, autor.nombre, editorial.nombre, le.paginas, le.cantidad, libro.precio, area.seccion, area.ubicacion FROM libro " +
				"JOIN libro_autor ON libro.isbn=libro_autor.isbn JOIN autor ON autor.idAutor=libro_autor.idAutor JOIN libro_editorial as le ON  le.isbn=libro.isbn " +
				"JOIN editorial ON editorial.idEditorial=le.idEditorial JOIN area ON libro.idArea=area.idArea WHERE libro.nombre='"+tbSName.Text+"';";
			
			return sentencia;
		}
		string sentenciaAutor(){
			
			string sentencia="SELECT libro.isbn, libro.nombre, autor.nombre, editorial.nombre, le.paginas, le.cantidad, libro.precio, area.seccion, area.ubicacion FROM libro " +
				"JOIN libro_autor ON libro.isbn=libro_autor.isbn JOIN autor ON autor.idAutor=libro_autor.idAutor JOIN libro_editorial as le ON  le.isbn=libro.isbn " +
				"JOIN editorial ON editorial.idEditorial=le.idEditorial JOIN area ON libro.idArea=area.idArea WHERE autor.nombre='"+tbSAuthor.Text+"';";
			
			return sentencia;
		}
		
		int validarTextbox(){
			int bandera = 0;
			if(!String.IsNullOrEmpty(tbSCode.Text)){
				bandera =1;
			}
			if(!String.IsNullOrEmpty(tbSName.Text)){
				bandera=2;
			}
			if(!String.IsNullOrEmpty(tbSAuthor.Text)){
				bandera=3;
			}
			return bandera;
		}
	}
}
