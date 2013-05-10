using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Lecon.Views
{
	public partial class AddOneStringDialog : ChildWindow
	{
		public string EnteredData { get; set; }
		public bool IsModify { get; set; }

		public AddOneStringDialog()
		{
			InitializeComponent();
			DataContext = this;
		}

		private void OKButton_Click(object sender, RoutedEventArgs e)
		{
			this.DialogResult = true;
		}

		private void CancelButton_Click(object sender, RoutedEventArgs e)
		{
			this.DialogResult = false;
		}
	}
}

