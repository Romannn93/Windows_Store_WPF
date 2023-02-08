using MahApps.Metro.Controls;
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
using WindowsStoreClone.Pages;
using WindowsStoreClone.UserControls;

namespace WindowsStoreClone
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : MetroWindow
	{
		private Main MainWindowContentPage;
		private TopAppsWrapped MyTopAppsWrappedPage;
		private DownloadsAndUpdates DownloadsAndUpdatesPage;
		public MainWindow()
		{
			InitializeComponent();
			MainWindowContentPage = new Main();
			MainWindowContentPage.AppClicked += MainWindowContentPage_AppClicked;

			MainWindowContentPage.TopAppButtonClicked += MainWindowContentPage_TopAppButtonClicked;

			MainWindowContentPage.DownloadsAndUpdatesClicked += MainWindowContentPage_DownloadsAndUpdatesClicked;

			MyTopAppsWrappedPage = new TopAppsWrapped();
			MyTopAppsWrappedPage.AnAppClicked += MainWindowContentPage_AppClicked;

			MyTopAppsWrappedPage.BackButtonClicked += BackButtonClicked;
			DownloadsAndUpdatesPage = new DownloadsAndUpdates();
			DownloadsAndUpdatesPage.BackButtonClicked += BackButtonClicked;
		}

		private void MainWindowContentPage_TopAppButtonClicked(object sender,RoutedEventArgs e)
		{
			MainWindowFrame.Content = MyTopAppsWrappedPage;
		}

		private void MainWindowContentPage_DownloadsAndUpdatesClicked()
		{
			MainWindowFrame.Content = DownloadsAndUpdatesPage;
		}
		private void MainWindowContentPage_AppClicked(AnApp sender, RoutedEventArgs e)
		{
			AppDetails myAppDetails = new AppDetails(sender);
			myAppDetails.BackButtonClicked += BackButtonClicked;
			myAppDetails.AppClicked += MainWindowContentPage_AppClicked;
			MainWindowFrame.Content = myAppDetails;
		}

		private void MainWindowFrame_Loaded(object sender, RoutedEventArgs e)
		{
			MainWindowFrame.Content= MainWindowContentPage;
        }

		private void BackButtonClicked(object sender, RoutedEventArgs e)
		{
			if (MainWindowFrame.NavigationService.CanGoBack)
			{
				MainWindowFrame.NavigationService.GoBack();
			}
		}
	}
}
