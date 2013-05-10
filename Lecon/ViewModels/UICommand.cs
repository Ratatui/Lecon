using System;
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
	public class UICommand : ICommand
	{
		#region Member

		private readonly Action action;
		private readonly Action<object> actionWithParameter;

		#endregion

		#region Ctor

		public UICommand()
		{
			this.IsEnabled = false;
		}

		public UICommand(Action action)
		{
			this.action = action;
			this.IsEnabled = true;
		}

		public UICommand(Action<object> action)
		{
			this.actionWithParameter = action;
			this.IsEnabled = true;
		}

		#endregion

		#region Events

		public event EventHandler<UICommandExecutedEventArgs> Executed;

		public event EventHandler IsEnabledChanged;

		protected void OnExecuted(object parameter)
		{
			EventHandler<UICommandExecutedEventArgs> handler = this.Executed;
			if (handler != null)
			{
				handler(this, new UICommandExecutedEventArgs(parameter));
			}
		}

		public event EventHandler<UICommandExecutingEventArgs> Executing;

		protected void OnExecuting(UICommandExecutingEventArgs args)
		{
			EventHandler<UICommandExecutingEventArgs> handler = this.Executing;
			if (handler != null)
			{
				handler(this, args);
			}
		}

		#endregion

		#region ICommand

		public virtual bool CanExecute(object parameter)
		{
			return this.IsEnabled;
		}

		public event EventHandler CanExecuteChanged;

		protected void OnCanExecuteChanged()
		{
			EventHandler handler = this.CanExecuteChanged;
			if (handler != null)
			{
				handler(this, EventArgs.Empty);
			}
		}

		public virtual void Execute(object parameter)
		{
			UICommandExecutingEventArgs args = new UICommandExecutingEventArgs(parameter);
			this.OnExecuting(args);

			if (!this.Handled)
			{
				parameter = args.Parameter;

				if (this.action != null)
					this.action();
				if (this.actionWithParameter != null)
					this.actionWithParameter(parameter);

				this.OnExecuted(parameter);
			}
			else
				this.Handled = false;
		}

		public void Execute()
		{
			this.Execute(null);
		}

		#endregion

		#region Property

		private bool isEnabled;

		public virtual bool IsEnabled
		{
			get { return this.isEnabled; }
			set
			{
				if (value != this.isEnabled)
				{
					this.isEnabled = value;
					this.OnCanExecuteChanged();
					if (IsEnabledChanged != null) IsEnabledChanged(this, new EventArgs());
				}
			}
		}

		public bool Handled { get; set; }

		#endregion
	}

	public class UICommandExecutedEventArgs : EventArgs
	{
		public object Parameter { get; set; }

		public UICommandExecutedEventArgs()
		{ }

		public UICommandExecutedEventArgs(object Parameter)
		{
			this.Parameter = Parameter;
		}
	}

	public class UICommandExecutingEventArgs : EventArgs
	{
		public object Parameter { get; set; }
		public bool Handled { get; set; }

		public UICommandExecutingEventArgs()
		{
			this.Handled = false;
		}

		public UICommandExecutingEventArgs(object Parameter)
		{
			this.Parameter = Parameter;
			this.Handled = false;
		}
	}

}
