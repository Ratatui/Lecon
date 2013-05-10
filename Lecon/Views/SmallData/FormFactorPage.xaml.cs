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
	public partial class FormFactorPage : Page
	{
		public FormFactorPage()
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
			this.formFactorDomainDataSource.DataView.Remove(DataGrid.SelectedItem);
			this.formFactorDomainDataSource.SubmitChanges();
		}

		private void ModifyButton_Click(object sender, RoutedEventArgs e)
		{
			var wnd = new AddOneStringDialog();
			wnd.Closed += DialogClosed;
			wnd.EnteredData = (this.DataGrid.SelectedItem as FormFactor).Name;
			wnd.IsModify = true;
			wnd.Show();
		}

		private void FormFactorDomainDataSource_LoadedData(object sender, LoadedDataEventArgs e)
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
					(this.DataGrid.SelectedItem as FormFactor).Name = wnd.EnteredData;
				}
				else
					this.formFactorDomainDataSource.DataView.Add(new FormFactor() { Name = wnd.EnteredData });
				this.formFactorDomainDataSource.SubmitChanges();
			}
			else
				this.formFactorDomainDataSource.RejectChanges();
		}
	}
}
