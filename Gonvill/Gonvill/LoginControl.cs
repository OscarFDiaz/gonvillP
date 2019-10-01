/*
 * Creado por SharpDevelop.
 * Usuario: Oscar Diaz
 * Fecha: 03/05/2019
 * Hora: 10:36 p. m.
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
	/// Description of LoginControl.
	/// </summary>
	public partial class LoginControl : UserControl
	{
		public NpgsqlConnection conexion = new NpgsqlConnection();
		public LoginControl()
		{
			InitializeComponent();
		}
		
		//> Cuando se le da click al incio de sesión
		void BtnLoginClick(object sender, EventArgs e)
		{
			// TODO: Verificar en la base de datos que el usuario y contraseña existen y comprobar si es un encargado o un empleado
			// 		 si es un empleado se abre el panel de cotizaciones, si es un encargado se abre el panel de "AdditionsControl",
			//		 para que pueda añadir libros o empleados, en caso de error mostrar mensaje de ello.
			
			/*string sentencia = "SELECT *FROM usuario WHERE username " +
				"= '"+tbUser.Text+"'AND password = '"+tbPassword.Text+"';";
			
			conexion.ConnectionString = "Username = postgres; Password = 010999fco; Host = localhost;"+
				"Port = 5432; Database = Gonvill;";
			
			conexion.Open();
			
			NpgsqlCommand cmd = new NpgsqlCommand(sentencia, conexion); // creamos nuestro objeto comando y le enviamos la conexion y la sentencia
			
			NpgsqlDataReader lector = cmd.ExecuteReader();//Ejecutamos el comando y declaramos un unbjeto de DataReader que obtiene el resultado del comando ejecutado
			
			//Si el resultado fue positivo
			if(lector.Read()){
				
				
				usuario = lector.GetString(0);*/
				//MessageBox.Show("Bienvenido: " + usuario + "", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				
				//> Añado el quotation control a esta usercontrol para poder mostrarlo
				QuotationControl qcontrol = new QuotationControl();
				this.Controls.Add(qcontrol);
				//<
				string usuario;
				//qcontrol.lbUserData.Text = "- Usuario: " + usuario + "\n"; 
				qcontrol.BringToFront(); // Muestro la forma de cortizaciones
				
				//> Busco la mainform en las formas y actualizo el label de hasta arriba y le pongo cotizaciones
				MainForm mForm;
				mForm = (MainForm)this.FindForm();
				
				mForm.labelPanelC.Text = "Cotizaciones"; // de priavado lo hago publico para poder acceder a el
				//<
				
			/*} else{
				MessageBox.Show("Verifique que el usuario o la contraseña existan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
			conexion.Close();//Es importante cerrar la conexion despues de ejecutar un comando.*/
		}
		
		//Cuando se le da click al boton de verificador
		void BtnCheckerClick(object sender, EventArgs e)
		{
			//> Añado el quotation control a esta usercontrol para poder mostrarlo
			// TODO: ...
			CheckerControl checkcontrol = new CheckerControl();
			this.Controls.Add(checkcontrol);
			//<
			
			//this.Hide();
			checkcontrol.BringToFront();
			
			//> Busco la mainform en las formas y actualizo el label de hasta arriba y le pongo verificador
			MainForm mForm;
			mForm = (MainForm)this.FindForm();
			
			mForm.labelPanelC.Text = "Verificador de precios"; // de priavado lo hago publico para poder acceder a el
			//<
		}
		
		///> Remuevo el texto del usuario y contraseña para que el usuaro escriba y cambio el color
		/// TODO: ...
		void TbUserEnter(object sender, EventArgs e)
		{
			if(tbUser.Text == "Usuario"){
				tbUser.Text = "";
				tbUser.ForeColor = Color.FromArgb(24, 47, 88);
			}
		}
		
		void TbUserLeave(object sender, EventArgs e)
		{
			if(tbUser.Text == ""){
				tbUser.Text = "Usuario";
				tbUser.ForeColor = Color.FromArgb(122, 189, 219);
			}
		}
		
		void TbPasswordEnter(object sender, EventArgs e)
		{
			if(tbPassword.Text == "Password"){
				tbPassword.Text = "";
				tbPassword.ForeColor = Color.FromArgb(24, 47, 88);
			}
		}
		
		void TbPasswordLeave(object sender, EventArgs e)
		{
			if(tbPassword.Text == ""){
				tbPassword.Text = "Password";
				tbPassword.ForeColor = Color.FromArgb(122, 189, 219);
			}
		}
		//<
	}
}
