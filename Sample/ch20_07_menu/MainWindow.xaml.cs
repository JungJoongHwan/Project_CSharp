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

namespace ch20_07_menu
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

        private void mnuNew_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("새 문서");
        }

        private void mnuSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("저장");
        }

        private void mnuCallReceive_Click(object sender, RoutedEventArgs e)
        {
            //mnuCallReceive.IsChecked = !mnuCallReceive.IsChecked;  --> 이거 안해도 체크가 변경된다..
        }
    }
}
