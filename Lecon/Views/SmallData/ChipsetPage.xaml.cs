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
using System.Windows.Navigation;
using Lecon.Web;

namespace Lecon.Views
{
	public partial class ChipsetPage : Page
	{
		public ChipsetPage()
		{
			InitializeComponent();
		}

		// Executes when the user navigates to this page.
		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
		}

		private void AddButton_Click(object sender, RoutedEventArgs e)
		{
			var wnd = new AddOneStringDialog();
			wnd.Closed += DialogClosed;
			wnd.Show();
		}

		private void DeleteButton_Click(object sender, RoutedEventArgs e)
		{
			this.chipsetDomainDataSource.DataView.Remove(DataGrid.SelectedItem);
			this.chipsetDomainDataSource.SubmitChanges();
		}

		private void ModifyButton_Click(object sender, RoutedEventArgs e)
		{
			var wnd = new AddOneStringDialog();
			wnd.Closed += DialogClosed;
			wnd.EnteredData = (this.DataGrid.SelectedItem as Chipset).Name;
			wnd.IsModify = true;
			wnd.Show();
		}

		private void ChipsetDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
		{
			if (e.HasError)
			{
				System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
				e.MarkErrorAsHandled();
			}
		}

		private void DialogClosed(object sender, EventArgs e)
		{
			var wnd = sender as AddOneStringDialog;
			if (wnd.DialogResult == true)
			{
				if (wnd.IsModify)
				{
					(this.DataGrid.SelectedItem as Chipset).Name = wnd.EnteredData;
				}
				else
					this.chipsetDomainDataSource.DataView.Add(new Chipset() { Name = wnd.EnteredData });
				this.chipsetDomainDataSource.SubmitChanges();
			}
			else
				this.chipsetDomainDataSource.RejectChanges();
		}

	}
}
