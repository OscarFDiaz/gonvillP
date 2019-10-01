using System;
/*
 * Creado por SharpDevelop.
 * Usuario: Oscar Diaz
 * Fecha: 03/05/2019
 * Hora: 10:38 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Gonvill
{
	partial class QuotationControl
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuotationControl));
			this.dgvQuotation = new System.Windows.Forms.DataGridView();
			this.lbDateTime = new System.Windows.Forms.Label();
			this.timerDataTime = new System.Windows.Forms.Timer(this.components);
			this.btnSearchQ = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSaveQ = new System.Windows.Forms.Button();
			this.panelLineUser = new System.Windows.Forms.Panel();
			this.tbSearchQuotation = new System.Windows.Forms.TextBox();
			this.btnBarCode = new System.Windows.Forms.Button();
			this.btnLeave = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lbTotal = new System.Windows.Forms.Label();
			this.lbUserData = new System.Windows.Forms.Label();
			this.btnSeeQuotation = new System.Windows.Forms.Button();
			this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvQuotation)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvQuotation
			// 
			this.dgvQuotation.AllowUserToAddRows = false;
			this.dgvQuotation.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
			dataGridViewCellStyle1.NullValue = "---";
			this.dgvQuotation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvQuotation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvQuotation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(189)))), ((int)(((byte)(219)))));
			this.dgvQuotation.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvQuotation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvQuotation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvQuotation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.isbn,
									this.nombre,
									this.autor,
									this.editorial,
									this.precio,
									this.cantidad});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvQuotation.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvQuotation.Location = new System.Drawing.Point(23, 44);
			this.dgvQuotation.Name = "dgvQuotation";
			this.dgvQuotation.ReadOnly = true;
			this.dgvQuotation.Size = new System.Drawing.Size(702, 423);
			this.dgvQuotation.TabIndex = 17;
			// 
			// lbDateTime
			// 
			this.lbDateTime.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDateTime.Location = new System.Drawing.Point(257, 15);
			this.lbDateTime.Name = "lbDateTime";
			this.lbDateTime.Size = new System.Drawing.Size(234, 29);
			this.lbDateTime.TabIndex = 19;
			this.lbDateTime.Text = "lbDateTime";
			// 
			// timerDataTime
			// 
			this.timerDataTime.Enabled = true;
			this.timerDataTime.Interval = 60000;
			this.timerDataTime.Tick += new System.EventHandler(this.TimerDataTimeTick);
			// 
			// btnSearchQ
			// 
			this.btnSearchQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(189)))), ((int)(((byte)(219)))));
			this.btnSearchQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSearchQ.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSearchQ.FlatAppearance.BorderSize = 0;
			this.btnSearchQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearchQ.Font = new System.Drawing.Font("Montserrat", 12F);
			this.btnSearchQ.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchQ.Image")));
			this.btnSearchQ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSearchQ.Location = new System.Drawing.Point(793, 219);
			this.btnSearchQ.Name = "btnSearchQ";
			this.btnSearchQ.Size = new System.Drawing.Size(198, 45);
			this.btnSearchQ.TabIndex = 20;
			this.btnSearchQ.Text = "Buscar";
			this.btnSearchQ.UseVisualStyleBackColor = false;
			this.btnSearchQ.Click += new System.EventHandler(this.BtnSearchQClick);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(189)))), ((int)(((byte)(219)))));
			this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDelete.FlatAppearance.BorderSize = 0;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Montserrat", 12F);
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDelete.Location = new System.Drawing.Point(793, 275);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(198, 45);
			this.btnDelete.TabIndex = 20;
			this.btnDelete.Text = "Eliminar";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// btnSaveQ
			// 
			this.btnSaveQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
			this.btnSaveQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSaveQ.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSaveQ.FlatAppearance.BorderSize = 0;
			this.btnSaveQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveQ.Font = new System.Drawing.Font("Montserrat", 12F);
			this.btnSaveQ.ForeColor = System.Drawing.Color.White;
			this.btnSaveQ.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveQ.Image")));
			this.btnSaveQ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSaveQ.Location = new System.Drawing.Point(793, 107);
			this.btnSaveQ.Name = "btnSaveQ";
			this.btnSaveQ.Size = new System.Drawing.Size(198, 45);
			this.btnSaveQ.TabIndex = 21;
			this.btnSaveQ.Text = "Guardar";
			this.btnSaveQ.UseVisualStyleBackColor = false;
			this.btnSaveQ.Click += new System.EventHandler(this.BtnSaveQClick);
			// 
			// panelLineUser
			// 
			this.panelLineUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
			this.panelLineUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panelLineUser.Location = new System.Drawing.Point(793, 391);
			this.panelLineUser.Name = "panelLineUser";
			this.panelLineUser.Size = new System.Drawing.Size(198, 3);
			this.panelLineUser.TabIndex = 23;
			// 
			// tbSearchQuotation
			// 
			this.tbSearchQuotation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(229)))));
			this.tbSearchQuotation.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbSearchQuotation.Font = new System.Drawing.Font("Montserrat", 12F);
			this.tbSearchQuotation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(189)))), ((int)(((byte)(219)))));
			this.tbSearchQuotation.Location = new System.Drawing.Point(793, 366);
			this.tbSearchQuotation.MaxLength = 13;
			this.tbSearchQuotation.Name = "tbSearchQuotation";
			this.tbSearchQuotation.Size = new System.Drawing.Size(150, 20);
			this.tbSearchQuotation.TabIndex = 22;
			this.tbSearchQuotation.Text = "Introduce ID";
			this.tbSearchQuotation.Enter += new System.EventHandler(this.TbSearchQuotationEnter);
			this.tbSearchQuotation.Leave += new System.EventHandler(this.TbSearchQuotationLeave);
			// 
			// btnBarCode
			// 
			this.btnBarCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(189)))), ((int)(((byte)(219)))));
			this.btnBarCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBarCode.BackgroundImage")));
			this.btnBarCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnBarCode.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBarCode.FlatAppearance.BorderSize = 0;
			this.btnBarCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBarCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBarCode.Location = new System.Drawing.Point(958, 365);
			this.btnBarCode.Name = "btnBarCode";
			this.btnBarCode.Size = new System.Drawing.Size(33, 23);
			this.btnBarCode.TabIndex = 20;
			this.btnBarCode.UseVisualStyleBackColor = false;
			this.btnBarCode.Click += new System.EventHandler(this.BtnBarCodeClick);
			// 
			// btnLeave
			// 
			this.btnLeave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(229)))));
			this.btnLeave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLeave.BackgroundImage")));
			this.btnLeave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnLeave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLeave.FlatAppearance.BorderSize = 0;
			this.btnLeave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(189)))), ((int)(((byte)(219)))));
			this.btnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLeave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLeave.Location = new System.Drawing.Point(958, 422);
			this.btnLeave.Name = "btnLeave";
			this.btnLeave.Size = new System.Drawing.Size(46, 45);
			this.btnLeave.TabIndex = 20;
			this.btnLeave.UseVisualStyleBackColor = false;
			this.btnLeave.Click += new System.EventHandler(this.BtnLeaveClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F);
			this.label1.Location = new System.Drawing.Point(731, 432);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 28);
			this.label1.TabIndex = 24;
			this.label1.Text = "Total: $";
			// 
			// lbTotal
			// 
			this.lbTotal.Font = new System.Drawing.Font("Montserrat", 14.25F);
			this.lbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
			this.lbTotal.Location = new System.Drawing.Point(807, 432);
			this.lbTotal.Name = "lbTotal";
			this.lbTotal.Size = new System.Drawing.Size(145, 28);
			this.lbTotal.TabIndex = 25;
			this.lbTotal.Text = "1284.00";
			// 
			// lbUserData
			// 
			this.lbUserData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbUserData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
			this.lbUserData.Location = new System.Drawing.Point(793, 44);
			this.lbUserData.Name = "lbUserData";
			this.lbUserData.Size = new System.Drawing.Size(198, 60);
			this.lbUserData.TabIndex = 26;
			// 
			// btnSeeQuotation
			// 
			this.btnSeeQuotation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
			this.btnSeeQuotation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSeeQuotation.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSeeQuotation.FlatAppearance.BorderSize = 0;
			this.btnSeeQuotation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSeeQuotation.Font = new System.Drawing.Font("Montserrat", 12F);
			this.btnSeeQuotation.ForeColor = System.Drawing.Color.White;
			this.btnSeeQuotation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSeeQuotation.Location = new System.Drawing.Point(793, 163);
			this.btnSeeQuotation.Name = "btnSeeQuotation";
			this.btnSeeQuotation.Size = new System.Drawing.Size(198, 45);
			this.btnSeeQuotation.TabIndex = 27;
			this.btnSeeQuotation.Text = "Ver cotizaciones";
			this.btnSeeQuotation.UseVisualStyleBackColor = false;
			this.btnSeeQuotation.Click += new System.EventHandler(this.BtnSeeQuotationClick);
			// 
			// isbn
			// 
			this.isbn.HeaderText = "ISBN";
			this.isbn.Name = "isbn";
			this.isbn.ReadOnly = true;
			// 
			// nombre
			// 
			this.nombre.HeaderText = "Nombre";
			this.nombre.Name = "nombre";
			this.nombre.ReadOnly = true;
			// 
			// autor
			// 
			this.autor.HeaderText = "Autor";
			this.autor.Name = "autor";
			this.autor.ReadOnly = true;
			// 
			// editorial
			// 
			this.editorial.HeaderText = "Editorial";
			this.editorial.Name = "editorial";
			this.editorial.ReadOnly = true;
			// 
			// precio
			// 
			this.precio.HeaderText = "Precio";
			this.precio.Name = "precio";
			this.precio.ReadOnly = true;
			// 
			// cantidad
			// 
			this.cantidad.HeaderText = "Existencias";
			this.cantidad.Name = "cantidad";
			this.cantidad.ReadOnly = true;
			// 
			// QuotationControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(229)))));
			this.Controls.Add(this.btnSeeQuotation);
			this.Controls.Add(this.lbUserData);
			this.Controls.Add(this.lbTotal);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panelLineUser);
			this.Controls.Add(this.tbSearchQuotation);
			this.Controls.Add(this.btnSaveQ);
			this.Controls.Add(this.btnBarCode);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnSearchQ);
			this.Controls.Add(this.lbDateTime);
			this.Controls.Add(this.dgvQuotation);
			this.Controls.Add(this.btnLeave);
			this.Name = "QuotationControl";
			this.Size = new System.Drawing.Size(1048, 484);
			this.Load += new System.EventHandler(this.QuotationControlLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvQuotation)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn precio;
		private System.Windows.Forms.DataGridViewTextBoxColumn editorial;
		private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn autor;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
		public System.Windows.Forms.Button btnSeeQuotation;
		public System.Windows.Forms.Label lbUserData;
		public System.Windows.Forms.Label lbTotal;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.Button btnLeave;
		public System.Windows.Forms.Button btnBarCode;
		public System.Windows.Forms.TextBox tbSearchQuotation;
		public System.Windows.Forms.Panel panelLineUser;
		public System.Windows.Forms.Button btnSaveQ;
		public System.Windows.Forms.Button btnDelete;
		public System.Windows.Forms.Button btnSearchQ;
		public System.Windows.Forms.Timer timerDataTime;
		public System.Windows.Forms.Label lbDateTime;
		public System.Windows.Forms.DataGridView dgvQuotation;
	}
}
