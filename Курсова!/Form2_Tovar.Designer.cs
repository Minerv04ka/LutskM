namespace Курсова_
{
	partial class Form2_Tovar
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.вийтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.товарToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
			this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tovarBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataBaseDataSet = new Курсова_.DataBaseDataSet();
			this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
			this.tovarTableAdapter = new Курсова_.DataBaseDataSetTableAdapters.TovarTableAdapter();
			this.menuStrip1.SuspendLayout();
			this.guna2GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2BorderlessForm1
			// 
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проПрограмуToolStripMenuItem,
            this.вийтиToolStripMenuItem,
            this.товарToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// проПрограмуToolStripMenuItem
			// 
			this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
			this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
			this.проПрограмуToolStripMenuItem.Text = "Про програму";
			this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
			// 
			// вийтиToolStripMenuItem
			// 
			this.вийтиToolStripMenuItem.Name = "вийтиToolStripMenuItem";
			this.вийтиToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.вийтиToolStripMenuItem.Text = "Вийти";
			this.вийтиToolStripMenuItem.Click += new System.EventHandler(this.вийтиToolStripMenuItem_Click);
			// 
			// товарToolStripMenuItem
			// 
			this.товарToolStripMenuItem.Name = "товарToolStripMenuItem";
			this.товарToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
			this.товарToolStripMenuItem.Text = "Товар";
			// 
			// guna2GroupBox1
			// 
			this.guna2GroupBox1.Controls.Add(this.guna2Button3);
			this.guna2GroupBox1.Controls.Add(this.guna2Button2);
			this.guna2GroupBox1.Controls.Add(this.guna2Button1);
			this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.guna2GroupBox1.Location = new System.Drawing.Point(227, 27);
			this.guna2GroupBox1.Name = "guna2GroupBox1";
			this.guna2GroupBox1.Size = new System.Drawing.Size(561, 97);
			this.guna2GroupBox1.TabIndex = 8;
			this.guna2GroupBox1.Text = "Дія";
			this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// guna2Button3
			// 
			this.guna2Button3.BackColor = System.Drawing.Color.White;
			this.guna2Button3.BorderRadius = 10;
			this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button3.ForeColor = System.Drawing.Color.White;
			this.guna2Button3.Location = new System.Drawing.Point(378, 50);
			this.guna2Button3.Name = "guna2Button3";
			this.guna2Button3.Size = new System.Drawing.Size(180, 44);
			this.guna2Button3.TabIndex = 14;
			this.guna2Button3.Text = "Видалити";
			this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
			// 
			// guna2Button2
			// 
			this.guna2Button2.BackColor = System.Drawing.Color.White;
			this.guna2Button2.BorderRadius = 10;
			this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button2.ForeColor = System.Drawing.Color.White;
			this.guna2Button2.Location = new System.Drawing.Point(6, 50);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.Size = new System.Drawing.Size(180, 44);
			this.guna2Button2.TabIndex = 12;
			this.guna2Button2.Text = "Додати";
			this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
			// 
			// guna2Button1
			// 
			this.guna2Button1.BackColor = System.Drawing.Color.White;
			this.guna2Button1.BorderRadius = 10;
			this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.guna2Button1.ForeColor = System.Drawing.Color.White;
			this.guna2Button1.Location = new System.Drawing.Point(192, 50);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new System.Drawing.Size(180, 44);
			this.guna2Button1.TabIndex = 13;
			this.guna2Button1.Text = "Обновити";
			this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.firmDataGridViewTextBoxColumn});
			this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dataGridView1.DataSource = this.tovarBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(227, 133);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(561, 355);
			this.dataGridView1.TabIndex = 13;
			// 
			// iDDataGridViewTextBoxColumn
			// 
			this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// quantityDataGridViewTextBoxColumn
			// 
			this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
			this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
			this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
			// 
			// costDataGridViewTextBoxColumn
			// 
			this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
			this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
			this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
			// 
			// firmDataGridViewTextBoxColumn
			// 
			this.firmDataGridViewTextBoxColumn.DataPropertyName = "Firm";
			this.firmDataGridViewTextBoxColumn.HeaderText = "Firm";
			this.firmDataGridViewTextBoxColumn.Name = "firmDataGridViewTextBoxColumn";
			// 
			// tovarBindingSource
			// 
			this.tovarBindingSource.DataMember = "Tovar";
			this.tovarBindingSource.DataSource = this.dataBaseDataSet;
			// 
			// dataBaseDataSet
			// 
			this.dataBaseDataSet.DataSetName = "DataBaseDataSet";
			this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// guna2Button4
			// 
			this.guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.guna2Button4.ForeColor = System.Drawing.Color.White;
			this.guna2Button4.Location = new System.Drawing.Point(12, 27);
			this.guna2Button4.Name = "guna2Button4";
			this.guna2Button4.Size = new System.Drawing.Size(209, 100);
			this.guna2Button4.TabIndex = 14;
			this.guna2Button4.Text = "Управління працівниками";
			this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
			// 
			// guna2Button6
			// 
			this.guna2Button6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.guna2Button6.ForeColor = System.Drawing.Color.White;
			this.guna2Button6.Location = new System.Drawing.Point(12, 388);
			this.guna2Button6.Name = "guna2Button6";
			this.guna2Button6.Size = new System.Drawing.Size(209, 100);
			this.guna2Button6.TabIndex = 17;
			this.guna2Button6.Text = "Обновити базу данних";
			this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
			// 
			// guna2Button5
			// 
			this.guna2Button5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.guna2Button5.ForeColor = System.Drawing.Color.White;
			this.guna2Button5.Location = new System.Drawing.Point(12, 133);
			this.guna2Button5.Name = "guna2Button5";
			this.guna2Button5.Size = new System.Drawing.Size(209, 100);
			this.guna2Button5.TabIndex = 18;
			this.guna2Button5.Text = "Управління замовленнями";
			this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
			// 
			// tovarTableAdapter
			// 
			this.tovarTableAdapter.ClearBeforeFill = true;
			// 
			// Form2_Tovar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
			this.ClientSize = new System.Drawing.Size(800, 500);
			this.Controls.Add(this.guna2Button5);
			this.Controls.Add(this.guna2Button6);
			this.Controls.Add(this.guna2Button4);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.guna2GroupBox1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new System.Drawing.Size(800, 500);
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "Form2_Tovar";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Товар";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.guna2GroupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tovarBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem вийтиToolStripMenuItem;
		private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
		private Guna.UI2.WinForms.Guna2Button guna2Button3;
		private Guna.UI2.WinForms.Guna2Button guna2Button2;
		private Guna.UI2.WinForms.Guna2Button guna2Button1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private DataBaseDataSet dataBaseDataSet;
		private Guna.UI2.WinForms.Guna2Button guna2Button4;
		private Guna.UI2.WinForms.Guna2Button guna2Button6;
		private System.Windows.Forms.BindingSource tovarBindingSource;
		private DataBaseDataSetTableAdapters.TovarTableAdapter tovarTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn firmDataGridViewTextBoxColumn;
		private Guna.UI2.WinForms.Guna2Button guna2Button5;
		private System.Windows.Forms.ToolStripMenuItem товарToolStripMenuItem;
	}
}