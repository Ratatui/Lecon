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
	public class Cooler_ViewModel : ViewModel
	{
		public ICollectionView DeviceTypesView { get; set; }
		public ICollectionView CoolersView { get; set; }
		public ICollectionView ManufacturersView { get; set; }

		public Cooler_ViewModel()
			: base()
		{
			Context.Load(Context.GetDeviceTypesQuery());
			Context.Load(Context.GetCoolersQuery());
			Context.Load(Context.GetManufacturersQuery());

			this.DeviceTypesView = this.CreateView(Context.DeviceTypes);
			this.CoolersView = this.CreateView(Context.Coolers);
			this.ManufacturersView = this.CreateView(Context.Manufacturers);
		}

		protected override void OnAddCommand()
		{
			var newCooler = new Cooler();
			var newDevice = new Device();
			newCooler.Device = newDevice;

			this.Context.Coolers.Add(newCooler);
			this.CoolersView.MoveCurrentTo(newCooler);
		}

		protected override void OnRefreshCommand()
		{
		}

		protected override void OnDeleteCommand()
		{
		}
	}
}
