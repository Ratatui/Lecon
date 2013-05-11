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
	public class GPU_ViewModel : ViewModel
	{
		public ICollectionView GPUsView { get; set; }
		public ICollectionView CoolersView { get; set; }
		public ICollectionView GraphicChipsView { get; set; }
		public ICollectionView ManufacturersView { get; set; }

		public GPU_ViewModel()
			: base()
		{
			this.Context.Load(Context.GetGPUsQuery());
			this.Context.Load(Context.GetManufacturersQuery());
			this.Context.Load(Context.GetGraphicChipsQuery());
			this.Context.Load(Context.GetCoolersForDeviceTypeNameQuery("GPU"));

			this.GPUsView = this.CreateView(Context.GPUs);
			this.GraphicChipsView = this.CreateView(Context.GraphicChips);
			this.ManufacturersView = this.CreateView(Context.Manufacturers);
			this.CoolersView = this.CreateView(Context.Coolers);
		}

		protected override void OnAddCommand()
		{
			var newGPU = new GPU();
			var newDevice = new Device();
			newGPU.Device = newDevice;

			this.Context.GPUs.Add(newGPU);
			this.GPUsView.MoveCurrentTo(newGPU);
		}

		protected override void OnRefreshCommand()
		{

		}

		protected override void OnDeleteCommand()
		{

		}
	}
}
