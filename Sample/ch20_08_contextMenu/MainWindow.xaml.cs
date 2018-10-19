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

namespace ch20_08_contextMenu
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mnuCvs_Menu01_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("메뉴01");
        }

        private void mnuCvs_Menu02_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("메뉴02");
        }

        private void mnuCvs_Menu03_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("메뉴03");
        }

        private void btnCvsContextMenu_Click(object sender, RoutedEventArgs e)
        {
            //mnuCvs.IsOpen = true;

            ContextMenu cm = this.FindResource("mnuCvs") as ContextMenu;
            cm.IsOpen = true;
        }

        private void Canvas_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            ContextMenu cm = this.FindResource("mnuCvs") as ContextMenu;
            cm.IsOpen = true;
        }
    }
}
