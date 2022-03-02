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
using ServiceStationWPF.Views;

namespace ServiceStationWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TbxWindow tbxWindow;
        public MainWindow()
        {
            InitializeComponent();
            tbxWindow = new TbxWindow();
        }

        private void MniOpenTbk_Click(object sender, RoutedEventArgs e)
        {
            if (tbxWindow == null)
                return;
            tbxWindow.ShowDialog();
        }
    }
}
