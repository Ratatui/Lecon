﻿using System;
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
using Lecon.ViewModels;

namespace Lecon.Views
{
	public partial class GPUPage : Page
	{
		public GPU_ViewModel ViewModel { get; set; }

		public GPUPage()
		{
			InitializeComponent();

			this.ViewModel = this.Resources["ViewModel"] as GPU_ViewModel;

		}

		// Executes when the user navigates to this page.
		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
		}
	}
}
