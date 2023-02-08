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

namespace WPF_MC.UserControls
{
    /// <summary>
    /// Interaction logic for HeaderRightButtons.xaml
    /// </summary>
    public partial class HeaderRightButtons : UserControl
    {
        public delegate void OnDownloadButtonClick(object sender, RoutedEventArgs e);
        public event OnDownloadButtonClick HeaderRightButtonsDownloadButtonClick;

        public HeaderRightButtons()
        {
            InitializeComponent();
        }
        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Visibility = Visibility.Collapsed;
            SeachTextBox.Visibility = Visibility.Visible;
        }
        public void MouseDown_OutsideOfHeaderRightButtons()
        {
            if (!SeachTextBox.IsMouseOver)
            {
                SeachTextBox.Visibility = Visibility.Collapsed;
                SearchButton.Visibility = Visibility.Visible;
            }
        }
        private void DownloadButton_Click(object sender, RoutedEventArgs e)
        {
            HeaderRightButtonsDownloadButtonClick(sender, e);
        }
        private void DownloadsAndUpdatesMenuItem_Click(object sender, RoutedEventArgs e)
        {
            HeaderRightButtonsDownloadButtonClick(sender, e);
        }
    }
}
