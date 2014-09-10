using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDemoForKevin1
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		//For Binding to work against this class you add this to the MainWindow declaration in the XAML: DataContext="{RelativeSource Self}"

		//This property is backed by a dependency property, which allows Binding to work
		public string Message
		{
			get { return (string)GetValue(MessageProperty); }
			set { SetValue(MessageProperty, value); }
		}

		// Using a DependencyProperty as the backing store for Message.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty MessageProperty =
			DependencyProperty.Register("Message", typeof(string), typeof(MainWindow), new PropertyMetadata(string.Empty));



		//This property is backed by a dependency property, which allows Binding to work
		public string UserName
		{
			get { return (string)GetValue(UserNameProperty); }
			set { SetValue(UserNameProperty, value); }
		}

		// Using a DependencyProperty as the backing store for UserName.  This enables animation, styling, binding, etc...
		public static readonly DependencyProperty UserNameProperty =
			DependencyProperty.Register("UserName", typeof(string), typeof(MainWindow), new PropertyMetadata(string.Empty));



		public MainWindow()
		{
			InitializeComponent();
		}

		private void SayHelloButton_OnClick(object sender, RoutedEventArgs e)
		{
			Message = string.Format("Hello, {0}", UserName);
		}

		private void SayGoodbyeButton_OnClick(object sender, RoutedEventArgs e)
		{
			Message = string.Format("Goodbye, {0}", UserName);
		}
	}
}
