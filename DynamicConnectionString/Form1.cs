﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DynamicConnectionString
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load( object sender, EventArgs e )
		{
			// TODO: このコード行はデータを 'newDBDataSet.Table_1' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
			this.table_1TableAdapter.Fill( this.newDBDataSet.Table_1 );

		}
	}
}
