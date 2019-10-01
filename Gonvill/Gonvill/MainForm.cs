/*
 * Creado por SharpDevelop.
 * Usuario: Oscar Diaz
 * Fecha: 02/05/2019
 * Hora: 07:57 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Npgsql;

namespace Gonvill
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		///> Me permite que la ventana tenga bordes redondos
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        //<
        
        //> Me permite mover la ventana, usando un estilo sin bordes
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]

		private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		
		void PanelTOPMouseDown(object sender, MouseEventArgs e)
		{
			//Panel donde esta el logo, el label y el botón cerrar
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		
		void LabelPanelCMouseDown(object sender, MouseEventArgs e)
		{
			//Texto que indica donde esta el usuario arriba
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		
		void PictureBox1MouseDown(object sender, MouseEventArgs e)
		{
			//Logo gonvill
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}
		//<
		
		public MainForm()
		{
			InitializeComponent();
			
			//> Me permite que la ventana tenga bordes redondos
			this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //<
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			// TODO: ...
			// Se ocultan todos los paneles y se muestra el de inicio de sesión, ademas se cambia el label superior
			
			loginControl1.BringToFront();
			
			labelPanelC.Text = "Inicio de sesión";
		}
		
		void PictureBoxCloseClick(object sender, EventArgs e)
		{
			// TODO: ...
			this.Close();
		}
	}
}
