/*
 * Creado por SharpDevelop.
 * Usuario: Oscar Diaz
 * Fecha: 03/05/2019
 * Hora: 10:36 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Gonvill
{
	partial class LoginControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginControl));
			this.btnChecker = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panelPass = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelLineUser = new System.Windows.Forms.Panel();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.tbUser = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnChecker
			// 
			this.btnChecker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
			this.btnChecker.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnChecker.FlatAppearance.BorderSize = 0;
			this.btnChecker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChecker.Font = new System.Drawing.Font("Montserrat", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnChecker.ForeColor = System.Drawing.Color.White;
			this.btnChecker.Location = new System.Drawing.Point(218, 350);
			this.btnChecker.Name = "btnChecker";
			this.btnChecker.Size = new System.Drawing.Size(150, 23);
			this.btnChecker.TabIndex = 0;
			this.btnChecker.Text = "Modo Verificador";
			this.btnChecker.UseVisualStyleBackColor = false;
			this.btnChecker.Click += new System.EventHandler(this.BtnCheckerClick);
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(189)))), ((int)(((byte)(219)))));
			this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLogin.FlatAppearance.BorderSize = 0;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(187, 278);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(198, 36);
			this.btnLogin.TabIndex = 0;
			this.btnLogin.Text = "Iniciar sesión";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.BtnLoginClick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(229)))));
			this.panel1.Controls.Add(this.panelPass);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.btnChecker);
			this.panel1.Controls.Add(this.btnLogin);
			this.panel1.Controls.Add(this.panelLineUser);
			this.panel1.Controls.Add(this.tbPassword);
			this.panel1.Controls.Add(this.tbUser);
			this.panel1.Location = new System.Drawing.Point(238, 29);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(573, 426);
			this.panel1.TabIndex = 1;
			// 
			// panelPass
			// 
			this.panelPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
			this.panelPass.Location = new System.Drawing.Point(168, 234);
			this.panelPass.Name = "panelPass";
			this.panelPass.Size = new System.Drawing.Size(250, 3);
			this.panelPass.TabIndex = 1;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(166, 188);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(46, 44);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(166, 72);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(46, 44);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// panelLineUser
			// 
			this.panelLineUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
			this.panelLineUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panelLineUser.Location = new System.Drawing.Point(166, 118);
			this.panelLineUser.Name = "panelLineUser";
			this.panelLineUser.Size = new System.Drawing.Size(250, 3);
			this.panelLineUser.TabIndex = 1;
			// 
			// tbPassword
			// 
			this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(229)))));
			this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbPassword.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(189)))), ((int)(((byte)(219)))));
			this.tbPassword.Location = new System.Drawing.Point(216, 197);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.PasswordChar = '*';
			this.tbPassword.Size = new System.Drawing.Size(150, 35);
			this.tbPassword.TabIndex = 0;
			this.tbPassword.Text = "Password";
			this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbPassword.Enter += new System.EventHandler(this.TbPasswordEnter);
			this.tbPassword.Leave += new System.EventHandler(this.TbPasswordLeave);
			// 
			// tbUser
			// 
			this.tbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(229)))));
			this.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbUser.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(189)))), ((int)(((byte)(219)))));
			this.tbUser.Location = new System.Drawing.Point(216, 81);
			this.tbUser.Name = "tbUser";
			this.tbUser.Size = new System.Drawing.Size(150, 35);
			this.tbUser.TabIndex = 0;
			this.tbUser.Text = "Usuario";
			this.tbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbUser.Enter += new System.EventHandler(this.TbUserEnter);
			this.tbUser.Leave += new System.EventHandler(this.TbUserLeave);
			// 
			// LoginControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(189)))), ((int)(((byte)(219)))));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.panel1);
			this.Name = "LoginControl";
			this.Size = new System.Drawing.Size(1048, 484);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TextBox tbUser;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Panel panelLineUser;
		private System.Windows.Forms.Panel panelPass;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Button btnChecker;
	}
}
