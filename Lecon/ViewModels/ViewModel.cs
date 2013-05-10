using Lecon.Web;
using System;
using System.ComponentModel;
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
	public abstract class ViewModel : INotifyPropertyChanged
	{
		public LeconDomainContext Context { get; set; }

		public UICommand SubmitCommand { get; set; }
		public UICommand RejectCommand { get; set; }

		public UICommand AddCommand { get; set; }
		public UICommand RefreshCommand { get; set; }
		public UICommand DeleteCommand { get; set; }

		public ViewModel()
		{
			this.Context = new LeconDomainContext();

			this.SubmitCommand = new UICommand(OnSubmitCommand);
			this.RejectCommand = new UICommand(OnRejectCommand);
		}

		public void OnSubmitCommand()
		{
			this.Context.SubmitChanges();
		}
		public void OnRejectCommand()
		{
			this.Context.RejectChanges();
		}

		public abstract void OnAddCommand();
		public abstract void OnDeleteCommand();
		public abstract void OnRefreshCommand();

		public event PropertyChangedEventHandler PropertyChanged;

		public void RaisePropertyChanged(string propertyName)
		{
			var e = PropertyChanged;
			if (e != null)
				e(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
