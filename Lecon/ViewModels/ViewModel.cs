using Lecon.Web;
using System;
using System.Collections;
using System.ComponentModel;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
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

			this.AddCommand = new UICommand(OnAddCommand);
			this.DeleteCommand = new UICommand(OnDeleteCommand);
			this.RefreshCommand = new UICommand(OnRefreshCommand);
		}

		public void OnSubmitCommand()
		{
			this.Context.SubmitChanges();
		}
		public void OnRejectCommand()
		{
			this.Context.RejectChanges();
		}

		protected abstract void OnAddCommand();
		protected abstract void OnDeleteCommand();
		protected abstract void OnRefreshCommand();

		protected ICollectionView CreateView(IEnumerable source)
		{
			var cvs = new CollectionViewSource { Source = source };
			return cvs.View;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public void RaisePropertyChanged(string propertyName)
		{
			var e = PropertyChanged;
			if (e != null)
				e(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
