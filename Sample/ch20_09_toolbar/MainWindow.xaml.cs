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

namespace ch20_09_toolbar
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

        
        private void tbTools_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("툴바의 이미지클릭");
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("플레이 버튼 클릭");
        }
    }
}
