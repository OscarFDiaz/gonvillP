/*
 * Creado por SharpDevelop.
 * Usuario: Oscar Diaz
 * Fecha: 02/05/2019
 * Hora: 07:57 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Gonvill
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panelTOP = new System.Windows.Forms.Panel();
			this.labelPanelC = new System.Windows.Forms.Label();
			this.pictureBoxClose = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.loginControl1 = new Gonvill.LoginControl();
			this.cotizacionesGuardadas1 = new Gonvill.CotizacionesGuardadas();
			this.panelTOP.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelTOP
			// 
			this.panelTOP.BackColor = System.Drawing.Color.White;
			this.panelTOP.Controls.Add(this.labelPanelC);
			this.panelTOP.Controls.Add(this.pictureBoxClose);
			this.panelTOP.Controls.Add(this.pictureBox1);
			this.panelTOP.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTOP.Location = new System.Drawing.Point(0, 0);
			this.panelTOP.Name = "panelTOP";
			this.panelTOP.Size = new System.Drawing.Size(1048, 53);
			this.panelTOP.TabIndex = 0;
			this.panelTOP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTOPMouseDown);
			// 
			// labelPanelC
			// 
			this.labelPanelC.BackColor = System.Drawing.Color.Transparent;
			this.labelPanelC.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPanelC.Location = new System.Drawing.Point(250, 4);
			this.labelPanelC.Name = "labelPanelC";
			this.labelPanelC.Size = new System.Drawing.Size(605, 40);
			this.labelPanelC.TabIndex = 2;
			this.labelPanelC.Text = "PanelControl";
			this.labelPanelC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelPanelC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelPanelCMouseDown);
			// 
			// pictureBoxClose
			// 
			this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxClose.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
			this.pictureBoxClose.Location = new System.Drawing.Point(1004, 12);
			this.pictureBoxClose.Name = "pictureBoxClose";
			this.pictureBoxClose.Size = new System.Drawing.Size(32, 32);
			this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxClose.TabIndex = 1;
			this.pictureBoxClose.TabStop = false;
			this.pictureBoxClose.Click += new System.EventHandler(this.PictureBoxCloseClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(186, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1MouseDown);
			// 
			// loginControl1
			// 
			this.loginControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(189)))), ((int)(((byte)(219)))));
			this.loginControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginControl1.BackgroundImage")));
			this.loginControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.loginControl1.Location = new System.Drawing.Point(0, 50);
			this.loginControl1.Name = "loginControl1";
			this.loginControl1.Size = new System.Drawing.Size(1048, 484);
			this.loginControl1.TabIndex = 1;
			// 
			// cotizacionesGuardadas1
			// 
			this.cotizacionesGuardadas1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(229)))));
			this.cotizacionesGuardadas1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cotizacionesGuardadas1.Location = new System.Drawing.Point(300, 59);
			this.cotizacionesGuardadas1.Name = "cotizacionesGuardadas1";
			this.cotizacionesGuardadas1.Size = new System.Drawing.Size(451, 462);
			this.cotizacionesGuardadas1.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(229)))));
			this.ClientSize = new System.Drawing.Size(1048, 533);
			this.Controls.Add(this.panelTOP);
			this.Controls.Add(this.loginControl1);
			this.Controls.Add(this.cotizacionesGuardadas1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Gonvill";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panelTOP.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private Gonvill.CotizacionesGuardadas cotizacionesGuardadas1;
		private Gonvill.LoginControl loginControl1;
		public System.Windows.Forms.Label labelPanelC;
		public System.Windows.Forms.PictureBox pictureBoxClose;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.Panel panelTOP;
	}
}
