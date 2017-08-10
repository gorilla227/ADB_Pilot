using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpAdbClient;

namespace ADB_Pilot
{
	public partial class Form1 : Form
	{
		public Form1 ()
		{
			InitializeComponent();

			var list = AdbClient.Instance.GetDevices().Where( d => d.State.Equals( DeviceState.Online ) );

			var ds = new BindingSource() { DataSource = list };
			listBox1.DataSource = ds;
			listBox1.DisplayMember = "Name";
			Refresh();
		}
	}
}
