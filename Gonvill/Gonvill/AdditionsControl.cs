/*
 * Creado por SharpDevelop.
 * Usuario: Oscar Diaz
 * Fecha: 10/05/2019
 * Hora: 10:50 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Gonvill
{
	/// <summary>
	/// Description of AdditionsControl.
	/// </summary>
	public partial class AdditionsControl : UserControl
	{
		public AdditionsControl()
		{
			InitializeComponent();
		}
		
		//Cuando se le da click en añadir empleado
		void BtnAddPersonClick(object sender, EventArgs e)
		{
			//TODO: Añadir a la base de datos los datos ingresados en las textBox, mandar un mensaje de que se ha añadido correctamente
			// 		a la base de datos o que no se ha podido ingresar.	
		}
		
		//>Cuando se le da click en añadir libro
		void BtnAddBookClick(object sender, EventArgs e)
		{
			//TODO: Añadir a la base de datos los datos ingresados en las textBox, mandar un mensaje de que se ha añadido correctamente
			// 		a la base de datos o que no se ha podido ingresar.
		}
		
		//Si se le da click en salir se muestra el panel para iniciar sesión
		void BtnLeaveClick(object sender, EventArgs e)
		{
			//TODO: ...
			
			LoginControl lgControl = new LoginControl();
			this.Controls.Add(lgControl);
			
			lgControl.BringToFront();
			
			//> Busco la mainform en las formas y actualizo el label de hasta arriba y le pongo verificador
			MainForm mForm;
			mForm = (MainForm)this.FindForm();
		
			mForm.labelPanelC.Text = "Iniciar Sesión"; // de priavado lo hago publico para poder acceder a el
			///<
		}
	}
}
