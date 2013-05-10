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
	public partial class GraphicChipPage : Page
	{
		public GraphicChipPage()
		{
			InitializeComponent();
		}

		// Executes when the user navigates to this page.
		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
		}

		private void AddButton_Click(object sender, RoutedEventArgs e)
		{
			var wnd = new GraphicChipWindow();
			wnd.Closed += DialogClosed;
			wnd.DataContext = new GraphicChip();
			graphicChipDomainDataSource.DataView.Add(wnd.DataContext);
			wnd.Show();
		}

		private void DeleteButton_Click(object sender, RoutedEventArgs e)
		{
			this.graphicChipDomainDataSource.DataView.Remove(DataGrid.SelectedItem);
			this.graphicChipDomainDataSource.SubmitChanges();
		}

		private void ModifyButton_Click(object sender, RoutedEventArgs e)
		{
			var wnd = new GraphicChipWindow();
			wnd.Closed += DialogClosed;
			wnd.DataContext = this.DataGrid.SelectedItem as GraphicChip;
			wnd.Show();
		}

		private void graphicChipDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
		{
			if (e.HasError)
			{
				System.Windows.MessageBox.Show(e.Error.ToString(), "Load Error", System.Windows.MessageBoxButton.OK);
				e.MarkErrorAsHandled();
			}
		}

		private void DialogClosed(object sender, EventArgs e)
		{
			var wnd = sender as GraphicChipWindow;
			if (wnd.DialogResult == true)
			{
				this.graphicChipDomainDataSource.SubmitChanges();
			}
			else
				this.graphicChipDomainDataSource.RejectChanges();
		}

	}
}
