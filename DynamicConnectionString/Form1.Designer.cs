namespace DynamicConnectionString
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.newDBDataSet = new DynamicConnectionString.NewDBDataSet();
			this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.table_1TableAdapter = new DynamicConnectionString.NewDBDataSetTableAdapters.Table_1TableAdapter();
			this.col1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.col2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.newDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1DataGridViewTextBoxColumn,
            this.col2DataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.table1BindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 86);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 21;
			this.dataGridView1.Size = new System.Drawing.Size(541, 226);
			this.dataGridView1.TabIndex = 0;
			// 
			// newDBDataSet
			// 
			this.newDBDataSet.DataSetName = "NewDBDataSet";
			this.newDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// table1BindingSource
			// 
			this.table1BindingSource.DataMember = "Table_1";
			this.table1BindingSource.DataSource = this.newDBDataSet;
			// 
			// table_1TableAdapter
			// 
			this.table_1TableAdapter.ClearBeforeFill = true;
			// 
			// col1DataGridViewTextBoxColumn
			// 
			this.col1DataGridViewTextBoxColumn.DataPropertyName = "col1";
			this.col1DataGridViewTextBoxColumn.HeaderText = "col1";
			this.col1DataGridViewTextBoxColumn.Name = "col1DataGridViewTextBoxColumn";
			// 
			// col2DataGridViewTextBoxColumn
			// 
			this.col2DataGridViewTextBoxColumn.DataPropertyName = "col2";
			this.col2DataGridViewTextBoxColumn.HeaderText = "col2";
			this.col2DataGridViewTextBoxColumn.Name = "col2DataGridViewTextBoxColumn";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(565, 324);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.newDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private NewDBDataSet newDBDataSet;
		private System.Windows.Forms.BindingSource table1BindingSource;
		private NewDBDataSetTableAdapters.Table_1TableAdapter table_1TableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn col1DataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn col2DataGridViewTextBoxColumn;
	}
}

