/*
 * Creado por SharpDevelop.
 * Usuario: Oscar Diaz
 * Fecha: 14/05/2019
 * Hora: 05:13 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Gonvill
{
	/// <summary>
	/// Description of CotizacionesGuardadas.
	/// </summary>
	public partial class CotizacionesGuardadas : UserControl
	{
		
		public CotizacionesGuardadas()
		{
			InitializeComponent();
			this.Location = new Point(300, 0);
		}
		
		void PictureBoxCloseClick(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
