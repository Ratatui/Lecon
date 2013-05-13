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
	public class Memory_ViewModel : ViewModel
	{
		public ICollectionView MemoriesView { get; set; }
		public ICollectionView ManufacturersView { get; set; }
		public ICollectionView MemoryTypesView { get; set; }

		public Memory_ViewModel()
			: base()
		{
			Context.Load(Context.GetMemoryTypesQuery());
			Context.Load(Context.GetMemorysQuery());
			Context.Load(Context.GetManufacturersQuery());

			this.MemoryTypesView = this.CreateView(Context.MemoryTypes);
			this.MemoriesView = this.CreateView(Context.Memories);
			this.ManufacturersView = this.CreateView(Context.Manufacturers);
		}

		protected override void OnAddCommand()
		{
			var newMemory = new Memory();
			var newDevice = new Device();
			newMemory.Device = newDevice;

			this.Context.Memories.Add(newMemory);
			this.MemoriesView.MoveCurrentTo(newMemory);
		}

		protected override void OnRefreshCommand()
		{
		}

		protected override void OnDeleteCommand()
		{
		}
	}
}
