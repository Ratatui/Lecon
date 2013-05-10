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
	public partial class MemoryTypePage : Page
	{
		public MemoryTypePage()
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
			this.memoryTypeDomainDataSource.DataView.Remove(DataGrid.SelectedItem);
			this.memoryTypeDomainDataSource.SubmitChanges();
		}

		private void ModifyButton_Click(object sender, RoutedEventArgs e)
		{
			var wnd = new AddOneStringDialog();
			wnd.Closed += DialogClosed;
			wnd.EnteredData = (this.DataGrid.SelectedItem as MemoryType).Name;
			wnd.IsModify = true;
			wnd.Show();
		}

		private void MemoryTypeDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
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
					(this.DataGrid.SelectedItem as MemoryType).Name = wnd.EnteredData;
				}
				else
					this.memoryTypeDomainDataSource.DataView.Add(new MemoryType() { Name = wnd.EnteredData });
				this.memoryTypeDomainDataSource.SubmitChanges();
			}
			else
				this.memoryTypeDomainDataSource.RejectChanges();
		}
	}
}
