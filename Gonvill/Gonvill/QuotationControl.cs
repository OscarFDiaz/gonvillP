/*
 * Creado por SharpDevelop.
 * Usuario: Oscar Diaz
 * Fecha: 03/05/2019
 * Hora: 10:38 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using Npgsql;

namespace Gonvill
{
	/// <summary>
	/// Description of QuotationControl.
	/// </summary>
	public partial class QuotationControl : UserControl
	{
		public NpgsqlConnection conexion = new NpgsqlConnection();
		
		List<String> listaDeCotizaciones;
		CotizacionesGuardadas ccontrol;
		int contadorCotizaciones;
		int precioMostrado;
		
		public QuotationControl()
		{
			InitializeComponent();
		}
		
		///> Cuando carga la form establezco la hora a la actual del sistema
		/// TODO: ...
		void QuotationControlLoad(object sender, EventArgs e)
		{
			//> Cambio el label de arriba y pongo la fecha y hora actuales del sistema.
			lbDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd h:mm tt");
			
			listaDeCotizaciones = new List<string>(); //Asigno memoria a las cotizaciones
			
			contadorCotizaciones = 0;
			
			precioMostrado = 0;
			lbTotal.Text = precioMostrado.ToString(); // Pongo el total de los productos en 0
			
			ccontrol = new CotizacionesGuardadas();
			this.Controls.Add(ccontrol);
			ccontrol.BringToFront();
			
		}
		//////////////////////////////////////////////////////////////////<
		
		//> Cada minuto actualizo la hora con un timer
		// TODO: ...
		void TimerDataTimeTick(object sender, EventArgs e)
		{
			lbDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd h:mm tt");
		}
		/////////////////////////////////////////////<
		
		//> Cuando dan click al botón de buscar se abre la form para buscar algun libro
		// TODO: ...
		void BtnSearchQClick(object sender, EventArgs e)
		{
			//> Añado el quotation control a esta usercontrol para poder mostrarlo
			SearchControl scontrol = new SearchControl();
			this.Controls.Add(scontrol);
			//<
			
			//this.Hide();// Oculto la forma login
			scontrol.BringToFront(); // Muestro la forma de cortizaciones
			
			//> Busco la mainform en las formas y actualizo el label de hasta arriba y le pongo cotizaciones
			MainForm mForm;
			mForm = (MainForm)this.FindForm();
			
			mForm.labelPanelC.Text = "Busqueda de articulos"; // de priavado lo hago publico para poder acceder a el
			//<
		}
		////////////////////////////////////////////////////////////////////////////////////<
		
		//> Aqui sólo permite que se quite el texto cuando se da en Introduce el ID para bucar un libro
		// TODO: ...
		void TbSearchQuotationEnter(object sender, EventArgs e)
		{
			if(tbSearchQuotation.Text == "Introduce ID"){
				tbSearchQuotation.Text = "";
				tbSearchQuotation.ForeColor = Color.FromArgb(24, 47, 88);
			}
		}
		
		void TbSearchQuotationLeave(object sender, EventArgs e)
		{
			if(tbSearchQuotation.Text == ""){
				tbSearchQuotation.Text = "Introduce ID";
				tbSearchQuotation.ForeColor = Color.FromArgb(122, 189, 219);
			}
		}
		////////////////////////////////////////////////////////////////////////////////////////////////<
		
		//> Cuando se le da click a salir regresa al usuario a la ventana de inicio de sesión
		// TODO: ...
		void BtnLeaveClick(object sender, EventArgs e)
		{
			//> Añado el quotation control a esta usercontrol para poder mostrarlo
			LoginControl logcontrol = new LoginControl();
			this.Controls.Add(logcontrol);
			//<
			
			//this.Hide();// Oculto la forma login
			logcontrol.BringToFront(); // Muestro la forma de cortizaciones
			
			//> Busco la mainform en las formas y actualizo el label de hasta arriba y le pongo cotizaciones
			MainForm mForm;
			mForm = (MainForm)this.FindForm();
			
			mForm.labelPanelC.Text = "Inicio de sesión"; // de priavado lo hago publico para poder acceder a el
			//<
		}
		////////////////////////////////////////////////////////////////////////////////////<
		
		//> Cuando se le da click al icono de codigo de barras
		void BtnBarCodeClick(object sender, EventArgs e)
		{
			// TODO: Buscar en la BD el código que esta en "tbSearchQuotation" y añadirlo a la GRIDVIEW, de no estar mostrar mensaje de error,
			// 	  actualizar el label del total con el precio de los libros en el GRIDVIEW
			
			string sentencia = "SELECT libro.isbn, libro.nombre, autor.nombre, editorial.nombre, le.paginas, le.cantidad, libro.precio, area.seccion, area.ubicacion FROM libro " +
				"JOIN libro_autor ON libro.isbn=libro_autor.isbn JOIN autor ON autor.idAutor=libro_autor.idAutor JOIN libro_editorial as le ON  le.isbn=libro.isbn " +
				"JOIN editorial ON editorial.idEditorial=le.idEditorial JOIN area ON libro.idArea=area.idArea WHERE libro.isbn='"+tbSearchQuotation.Text+"';";
			
			conexion.ConnectionString = "Username = postgres; Password = 010999fco; Host = localhost;"+
				"Port = 5432; Database = Gonvill;";
			conexion.Open();
			NpgsqlCommand cmd = new NpgsqlCommand(sentencia, conexion);
			NpgsqlDataReader lector = cmd.ExecuteReader();
			
			if(lector.Read()){
				conexion.Close();
				cargarDataView(conexion, sentencia, cmd, lector);
				lbTotal.Text = precioMostrado.ToString();
			} else{
				if(tbSearchQuotation.Text == "Introduce ISB"){
					MessageBox.Show("Introduce un ISBN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}else{
					MessageBox.Show("No se encontro ese ISBN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			
			conexion.Close();
			
		}
		
		void cargarDataView(NpgsqlConnection connect, string sentencia, NpgsqlCommand cmd, NpgsqlDataReader lector){
			
			//dgvQuotation.Rows.Clear();
			conexion.Open();
			cmd = new NpgsqlCommand(sentencia, conexion);
			lector = cmd.ExecuteReader();
			//int precioCargado = 0;
			
			while(lector.Read()){
				int renglon = dgvQuotation.Rows.Add();

				
				dgvQuotation.Rows[renglon].Cells["isbn"].Value =
					lector.GetString(lector.GetOrdinal("isbn"));
				
				dgvQuotation.Rows[renglon].Cells["nombre"].Value =
					lector.GetString(lector.GetOrdinal("nombre"));
				
				dgvQuotation.Rows[renglon].Cells["autor"].Value =
					lector.GetString(2);
				
				dgvQuotation.Rows[renglon].Cells["editorial"].Value =
					lector.GetString(3);
				
				precioMostrado += lector.GetInt32(6);
				dgvQuotation.Rows[renglon].Cells["precio"].Value =
					lector.GetInt32(6).ToString();
				
				dgvQuotation.Rows[renglon].Cells["cantidad"].Value =
					lector.GetInt32(5).ToString();
			}
			conexion.Close();
		}
		//////////////////////////////////////////////////////<
		/// 
		
		//> Cuando se le da click al botón de ELIMINAR
		void BtnDeleteClick(object sender, EventArgs e)
		{
			// TODO: ...
			string str = "";
			int restarAPrecio = 0;
			if (dgvQuotation.SelectedRows.Count > 0){
				str = dgvQuotation.Rows[dgvQuotation.SelectedRows[0].Index].Cells[4].Value.ToString(); // Obtengo el valor del libro a eliminar para restarlo al total
				dgvQuotation.Rows.RemoveAt(this.dgvQuotation.SelectedRows[0].Index); // Remueve la fila seleccionada
				
				restarAPrecio = Int32.Parse(str);
				precioMostrado -= restarAPrecio;
				lbTotal.Text = precioMostrado.ToString();
			}else{
				MessageBox.Show("No hay elementos para borrar o no has seleccionado una fila", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		//////////////////////////////////////////////////////<
		
		//> Cuando se le da click al botón de GUARDAR
		void BtnSaveQClick(object sender, EventArgs e)
		{
			if(dgvQuotation.Rows.Count == 0){
				MessageBox.Show("No hay elementos para añadir", "Error de cotización", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}else{
				contadorCotizaciones++; //Aumento el contador para las cotizaciones
				
				// Guardo las cotizaciones en un treeview y en cada nodo añado el ISBN de los libros
				TreeNode mainNode = new TreeNode();
				mainNode.Name = contadorCotizaciones.ToString();
				mainNode.Text = lbDateTime.Text + " -- $" + lbTotal.Text + " -- #" + contadorCotizaciones.ToString();
				ccontrol.tVCotizaciones.Nodes.Add(mainNode);
				
				foreach (DataGridViewRow row in dgvQuotation.Rows)
				{
					ccontrol.tVCotizaciones.Nodes[mainNode.Name].Nodes.Add(row.Cells[0].Value.ToString());
				}
				dgvQuotation.Rows.Clear(); //Limpio los elementos del datagrid
				
				precioMostrado -= precioMostrado; // Limpio el precio mostrado
				lbTotal.Text = "0";
				
				MessageBox.Show("Cotización guardada: " + contadorCotizaciones.ToString(), "Cotización añadida", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}
		
		void BtnSeeQuotationClick(object sender, EventArgs e)
		{
			ccontrol.Show();
		}
		//////////////////////////////////////////////////////<
	}
}
