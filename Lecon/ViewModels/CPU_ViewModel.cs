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
using System.Windows.Data;
using System.Collections;
using System.ComponentModel;

namespace Lecon.ViewModels
{
	public class CPU_ViewModel : ViewModel
	{
		public ICollectionView CPUsView { get; set; }
		public ICollectionView GPUsView { get; set; }
		public ICollectionView SocketsView { get; set; }
		public ICollectionView ManufacturersView { get; set; }

		public CPU_ViewModel()
			: base()
		{
			Context.Load(Context.GetCPUsQuery());
			Context.Load(Context.GetGPUsQuery());
			Context.Load(Context.GetManufacturersQuery());
			Context.Load(Context.GetSocketsQuery());

			this.CPUsView = this.CreateView(Context.CPUs);
			this.GPUsView = this.CreateView(Context.GPUs);
			this.SocketsView = this.CreateView(Context.Sockets);
			this.ManufacturersView = this.CreateView(Context.Manufacturers);
		}

		public override void OnAddCommand()
		{
			var newCPU = new CPU();
			var newDevice = new Device();
			newCPU.Device = newDevice;

			this.Context.CPUs.Add(newCPU);
			this.CPUsView.MoveCurrentTo(newCPU);
		}

		public override void OnRefreshCommand()
		{
		}

		public override void OnDeleteCommand()
		{
		}
	}
}
