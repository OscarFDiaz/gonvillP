/*
 * Creado por SharpDevelop.
 * Usuario: Oscar Diaz
 * Fecha: 14/05/2019
 * Hora: 05:13 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Gonvill
{
	partial class CotizacionesGuardadas
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CotizacionesGuardadas));
			this.pictureBoxClose = new System.Windows.Forms.PictureBox();
			this.tVCotizaciones = new System.Windows.Forms.TreeView();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxClose
			// 
			this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxClose.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
			this.pictureBoxClose.Location = new System.Drawing.Point(414, 3);
			this.pictureBoxClose.Name = "pictureBoxClose";
			this.pictureBoxClose.Size = new System.Drawing.Size(32, 32);
			this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxClose.TabIndex = 2;
			this.pictureBoxClose.TabStop = false;
			this.pictureBoxClose.Click += new System.EventHandler(this.PictureBoxCloseClick);
			// 
			// tVCotizaciones
			// 
			this.tVCotizaciones.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tVCotizaciones.Location = new System.Drawing.Point(15, 13);
			this.tVCotizaciones.Name = "tVCotizaciones";
			this.tVCotizaciones.Size = new System.Drawing.Size(419, 433);
			this.tVCotizaciones.TabIndex = 3;
			// 
			// CotizacionesGuardadas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(229)))));
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.pictureBoxClose);
			this.Controls.Add(this.tVCotizaciones);
			this.Name = "CotizacionesGuardadas";
			this.Size = new System.Drawing.Size(449, 460);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
			this.ResumeLayout(false);
		}
		public System.Windows.Forms.TreeView tVCotizaciones;
		public System.Windows.Forms.PictureBox pictureBoxClose;
	}
}
