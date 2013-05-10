using Lecon.Web;
using System;
using System.Collections.ObjectModel;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Lecon.ViewModels
{
	public class CPU_ViewModel : ViewModel
	{
		ObservableCollection<CPU> CPUView { get; set; }

		public CPU_ViewModel()
		{
			Context.Load(Context.GetCPUsQuery());
			Context.Load(Context.GetGPUsQuery());
			Context.Load(Context.GetManufacturersQuery());
			Context.Load(Context.GetSocketsQuery());
		}

		public override void OnAddCommand()
		{
		}
		public override void OnRefreshCommand()
		{
		}
		public override void OnDeleteCommand()
		{
		}
	}
}
