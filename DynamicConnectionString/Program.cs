using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DynamicConnectionString
{
	static class Program
	{
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );

			//接続文字列の切り替え
			Properties.Settings.Default.NewDBConnectionString = 
				Properties.Settings.Default.NewDBConnectionString.Replace( "dummy", "sa" );

			Application.Run( new Form1() );
		}
	}
}
