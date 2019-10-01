/*
 * Creado por SharpDevelop.
 * Usuario: Oscar Diaz
 * Fecha: 03/05/2019
 * Hora: 10:37 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Gonvill
{
	partial class CheckerControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckerControl));
			this.btnLogin = new System.Windows.Forms.Button();
			this.lbNameBook = new System.Windows.Forms.Label();
			this.lbAuthorBook = new System.Windows.Forms.Label();
			this.lbISBN = new System.Windows.Forms.Label();
			this.lbPrice = new System.Windows.Forms.Label();
			this.lbSec = new System.Windows.Forms.Label();
			this.panelLineSearch = new System.Windows.Forms.Panel();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(189)))), ((int)(((byte)(219)))));
			this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLogin.FlatAppearance.BorderSize = 0;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(889, 3);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(156, 36);
			this.btnLogin.TabIndex = 1;
			this.btnLogin.Text = "Iniciar sesión";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.BtnLoginClick);
			// 
			// lbNameBook
			// 
			this.lbNameBook.Cursor = System.Windows.Forms.Cursors.Default;
			this.lbNameBook.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNameBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
			this.lbNameBook.Location = new System.Drawing.Point(208, 140);
			this.lbNameBook.Name = "lbNameBook";
			this.lbNameBook.Size = new System.Drawing.Size(630, 41);
			this.lbNameBook.TabIndex = 3;
			this.lbNameBook.Text = "Strategy -Your Thrilling Subtitle Here -";
			// 
			// lbAuthorBook
			// 
			this.lbAuthorBook.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbAuthorBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
			this.lbAuthorBook.Location = new System.Drawing.Point(208, 197);
			this.lbAuthorBook.Name = "lbAuthorBook";
			this.lbAuthorBook.Size = new System.Drawing.Size(630, 41);
			this.lbAuthorBook.TabIndex = 3;
			this.lbAuthorBook.Text = "Author Name";
			// 
			// lbISBN
			// 
			this.lbISBN.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
			this.lbISBN.Location = new System.Drawing.Point(208, 254);
			this.lbISBN.Name = "lbISBN";
			this.lbISBN.Size = new System.Drawing.Size(630, 41);
			this.lbISBN.TabIndex = 3;
			this.lbISBN.Text = "9786073179966";
			// 
			// lbPrice
			// 
			this.lbPrice.Font = new System.Drawing.Font("Montserrat", 60F, System.Drawing.FontStyle.Bold);
			this.lbPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
			this.lbPrice.Location = new System.Drawing.Point(625, 260);
			this.lbPrice.Name = "lbPrice";
			this.lbPrice.Size = new System.Drawing.Size(404, 114);
			this.lbPrice.TabIndex = 3;
			this.lbPrice.Text = "299.00";
			// 
			// lbSec
			// 
			this.lbSec.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
			this.lbSec.Location = new System.Drawing.Point(208, 311);
			this.lbSec.Name = "lbSec";
			this.lbSec.Size = new System.Drawing.Size(630, 41);
			this.lbSec.TabIndex = 3;
			this.lbSec.Text = "25481365";
			// 
			// panelLineSearch
			// 
			this.panelLineSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
			this.panelLineSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panelLineSearch.Location = new System.Drawing.Point(399, 55);
			this.panelLineSearch.Name = "panelLineSearch";
			this.panelLineSearch.Size = new System.Drawing.Size(250, 3);
			this.panelLineSearch.TabIndex = 5;
			// 
			// tbSearch
			// 
			this.tbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(229)))));
			this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbSearch.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(189)))), ((int)(((byte)(219)))));
			this.tbSearch.Location = new System.Drawing.Point(399, 21);
			this.tbSearch.MaxLength = 13;
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(200, 29);
			this.tbSearch.TabIndex = 4;
			this.tbSearch.Text = "ISBN";
			this.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbSearch.Enter += new System.EventHandler(this.TbSearchEnter);
			this.tbSearch.Leave += new System.EventHandler(this.TbSearchLeave);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Montserrat", 21.75F);
			this.label1.Location = new System.Drawing.Point(20, 140);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(170, 41);
			this.label1.TabIndex = 7;
			this.label1.Text = "Nombre:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Montserrat", 21.75F);
			this.label2.Location = new System.Drawing.Point(20, 197);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(170, 41);
			this.label2.TabIndex = 7;
			this.label2.Text = "Autor:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Montserrat", 21.75F);
			this.label3.Location = new System.Drawing.Point(20, 254);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(170, 41);
			this.label3.TabIndex = 7;
			this.label3.Text = "ISBN:";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Montserrat", 21.75F);
			this.label4.Location = new System.Drawing.Point(20, 311);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(170, 41);
			this.label4.TabIndex = 7;
			this.label4.Text = "Nombre:";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Montserrat", 21.75F);
			this.label6.Location = new System.Drawing.Point(20, 311);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(170, 41);
			this.label6.TabIndex = 7;
			this.label6.Text = "Sección:";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Montserrat", 60F);
			this.label8.Location = new System.Drawing.Point(567, 260);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(67, 90);
			this.label8.TabIndex = 7;
			this.label8.Text = "$";
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(229)))));
			this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
			this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSearch.FlatAppearance.BorderSize = 0;
			this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(189)))), ((int)(((byte)(219)))));
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSearch.Location = new System.Drawing.Point(605, 18);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(44, 37);
			this.btnSearch.TabIndex = 22;
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.BtnSearchClick);
			// 
			// CheckerControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(229)))));
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panelLineSearch);
			this.Controls.Add(this.tbSearch);
			this.Controls.Add(this.lbPrice);
			this.Controls.Add(this.lbSec);
			this.Controls.Add(this.lbISBN);
			this.Controls.Add(this.lbAuthorBook);
			this.Controls.Add(this.lbNameBook);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.btnSearch);
			this.Name = "CheckerControl";
			this.Size = new System.Drawing.Size(1048, 484);
			this.Load += new System.EventHandler(this.CheckerControlLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.Panel panelLineSearch;
		private System.Windows.Forms.Label lbSec;
		private System.Windows.Forms.Label lbPrice;
		private System.Windows.Forms.Label lbISBN;
		private System.Windows.Forms.Label lbAuthorBook;
		private System.Windows.Forms.Label lbNameBook;
		private System.Windows.Forms.Button btnLogin;
	}
}
