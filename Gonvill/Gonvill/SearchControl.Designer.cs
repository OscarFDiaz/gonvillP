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
	partial class SearchControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchControl));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panelLineSearch = new System.Windows.Forms.Panel();
			this.tbSName = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tbSAuthor = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tbSCode = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnReturn = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dgvSearch = new System.Windows.Forms.DataGridView();
			this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.paginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
			this.SuspendLayout();
			// 
			// panelLineSearch
			// 
			this.panelLineSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
			this.panelLineSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panelLineSearch.Location = new System.Drawing.Point(38, 73);
			this.panelLineSearch.Name = "panelLineSearch";
			this.panelLineSearch.Size = new System.Drawing.Size(250, 3);
			this.panelLineSearch.TabIndex = 8;
			// 
			// tbSName
			// 
			this.tbSName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(229)))));
			this.tbSName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbSName.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbSName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
			this.tbSName.Location = new System.Drawing.Point(42, 73);
			this.tbSName.Name = "tbSName";
			this.tbSName.Size = new System.Drawing.Size(250, 23);
			this.tbSName.TabIndex = 7;
			this.tbSName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbSName.Enter += new System.EventHandler(this.TbSNameEnter);
			this.tbSName.Leave += new System.EventHandler(this.TbSNameLeave);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel1.Location = new System.Drawing.Point(352, 109);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(250, 3);
			this.panel1.TabIndex = 11;
			// 
			// tbSAuthor
			// 
			this.tbSAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(229)))));
			this.tbSAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbSAuthor.Font = new System.Drawing.Font("Montserrat", 14.25F);
			this.tbSAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
			this.tbSAuthor.Location = new System.Drawing.Point(352, 73);
			this.tbSAuthor.Name = "tbSAuthor";
			this.tbSAuthor.Size = new System.Drawing.Size(250, 23);
			this.tbSAuthor.TabIndex = 10;
			this.tbSAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbSAuthor.Enter += new System.EventHandler(this.TbSAuthorEnter);
			this.tbSAuthor.Leave += new System.EventHandler(this.TbSAuthorLeave);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
			this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel2.Location = new System.Drawing.Point(650, 109);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(250, 3);
			this.panel2.TabIndex = 14;
			// 
			// tbSCode
			// 
			this.tbSCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(229)))));
			this.tbSCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbSCode.Font = new System.Drawing.Font("Montserrat", 14.25F);
			this.tbSCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
			this.tbSCode.Location = new System.Drawing.Point(650, 73);
			this.tbSCode.MaxLength = 13;
			this.tbSCode.Name = "tbSCode";
			this.tbSCode.Size = new System.Drawing.Size(250, 23);
			this.tbSCode.TabIndex = 13;
			this.tbSCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tbSCode.Enter += new System.EventHandler(this.TbSCodeEnter);
			this.tbSCode.Leave += new System.EventHandler(this.TbSCodeLeave);
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
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSearch.Location = new System.Drawing.Point(965, 46);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(46, 45);
			this.btnSearch.TabIndex = 21;
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.BtnSearchClick);
			// 
			// btnReturn
			// 
			this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(229)))));
			this.btnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.BackgroundImage")));
			this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReturn.FlatAppearance.BorderSize = 0;
			this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(189)))), ((int)(((byte)(219)))));
			this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReturn.Location = new System.Drawing.Point(38, 434);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(44, 37);
			this.btnReturn.TabIndex = 22;
			this.btnReturn.UseVisualStyleBackColor = false;
			this.btnReturn.Click += new System.EventHandler(this.BtnReturnClick);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
			this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel3.Location = new System.Drawing.Point(42, 109);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(250, 3);
			this.panel3.TabIndex = 12;
			// 
			// dgvSearch
			// 
			this.dgvSearch.AllowUserToAddRows = false;
			this.dgvSearch.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgvSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSearch.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.isbn,
									this.nombre,
									this.autor,
									this.editorial,
									this.paginas,
									this.cantidad,
									this.precio,
									this.seccion,
									this.ubicacion});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSearch.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvSearch.GridColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvSearch.Location = new System.Drawing.Point(38, 133);
			this.dgvSearch.Name = "dgvSearch";
			this.dgvSearch.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvSearch.Size = new System.Drawing.Size(973, 295);
			this.dgvSearch.TabIndex = 23;
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
			// paginas
			// 
			this.paginas.HeaderText = "Paginas";
			this.paginas.Name = "paginas";
			this.paginas.ReadOnly = true;
			// 
			// cantidad
			// 
			this.cantidad.HeaderText = "Cantidad";
			this.cantidad.Name = "cantidad";
			this.cantidad.ReadOnly = true;
			// 
			// precio
			// 
			this.precio.HeaderText = "Precio";
			this.precio.Name = "precio";
			this.precio.ReadOnly = true;
			// 
			// seccion
			// 
			this.seccion.HeaderText = "Seccion";
			this.seccion.Name = "seccion";
			this.seccion.ReadOnly = true;
			// 
			// ubicacion
			// 
			this.ubicacion.HeaderText = "Ubicacio";
			this.ubicacion.Name = "ubicacion";
			this.ubicacion.ReadOnly = true;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
			this.label1.Location = new System.Drawing.Point(123, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 23);
			this.label1.TabIndex = 24;
			this.label1.Text = "Nombre";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
			this.label2.Location = new System.Drawing.Point(446, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 23);
			this.label2.TabIndex = 25;
			this.label2.Text = "Autor";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(47)))), ((int)(((byte)(88)))));
			this.label3.Location = new System.Drawing.Point(745, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 23);
			this.label3.TabIndex = 26;
			this.label3.Text = "ISBN";
			// 
			// SearchControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(229)))));
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvSearch);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.tbSCode);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.tbSAuthor);
			this.Controls.Add(this.tbSName);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnReturn);
			this.Name = "SearchControl";
			this.Size = new System.Drawing.Size(1048, 484);
			((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnReturn;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox tbSCode;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox tbSAuthor;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox tbSName;
		private System.Windows.Forms.Panel panelLineSearch;
		private System.Windows.Forms.DataGridView dgvSearch;
		private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn autor;
		private System.Windows.Forms.DataGridViewTextBoxColumn editorial;
		private System.Windows.Forms.DataGridViewTextBoxColumn paginas;
		private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn precio;
		private System.Windows.Forms.DataGridViewTextBoxColumn seccion;
		private System.Windows.Forms.DataGridViewTextBoxColumn ubicacion;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}
