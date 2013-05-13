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
	public class Motherboard_ViewModel : ViewModel
	{
		public ICollectionView PowerTypesView { get; set; }
		public ICollectionView ChipsetsView { get; set; }
		public ICollectionView ManufacturersView { get; set; }
		public ICollectionView SocketsView { get; set; }
		public ICollectionView MemoryTypesView { get; set; }
		public ICollectionView FormFactorsView { get; set; }
		public ICollectionView MotherboardsView { get; set; }

		public Motherboard_ViewModel()
			: base()
		{
			Context.Load(Context.GetPowerTypesQuery());
			Context.Load(Context.GetChipsetsQuery());
			Context.Load(Context.GetManufacturersQuery());
			Context.Load(Context.GetMemoryTypesQuery());
			Context.Load(Context.GetMotherboardsQuery());
			Context.Load(Context.GetFormFactorsQuery());
			Context.Load(Context.GetSocketsQuery());

			this.PowerTypesView = this.CreateView(Context.PowerTypes);
			this.ChipsetsView = this.CreateView(Context.Chipsets);
			this.MemoryTypesView = this.CreateView(Context.MemoryTypes);
			this.MotherboardsView = this.CreateView(Context.Motherboards);
			this.FormFactorsView = this.CreateView(Context.FormFactors);
			this.ManufacturersView = this.CreateView(Context.Manufacturers);
			this.SocketsView = this.CreateView(Context.Sockets);
		}

		protected override void OnAddCommand()
		{
			var newMotherboard = new Motherboard();
			var newDevice = new Device();
			newMotherboard.Device = newDevice;

			this.Context.Motherboards.Add(newMotherboard);
			this.MotherboardsView.MoveCurrentTo(newMotherboard);
		}

		protected override void OnRefreshCommand()
		{
		}

		protected override void OnDeleteCommand()
		{
		}
	}
}
