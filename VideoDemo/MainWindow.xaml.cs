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

namespace VideoDemo
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void panel1_MediaOpened(object sender, RoutedEventArgs e)
		{
			Console.WriteLine("Opened: "+((MediaElement)sender).Source);
		}

		private void panel1_MediaFailed(object sender, ExceptionRoutedEventArgs e)
		{
			Console.WriteLine("Failed:"+((MediaElement)sender).Source);
		}

		private void panel1_MediaEnded(object sender, RoutedEventArgs e)
		{
			Console.WriteLine("Ended:"+((MediaElement)sender).Source);
		}
	}
}
