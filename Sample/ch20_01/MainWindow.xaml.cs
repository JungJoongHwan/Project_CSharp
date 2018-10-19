using System;
using System.Collections.Generic;
using System.Diagnostics;
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

// 라우팅이벤트
// 컨트롤의 이벤트는 부모에서 자식으로 가는 이벤트터널링과 자식에서 부모로 가는 이벤트버블링이 연속으로 일어난다.

namespace ch20_01
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

        private void sp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("스택 패널");
        }

        private void btn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("버튼");
        }

        private void grd_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("그리드");
        }

        private void cvs_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("캔버스");
            e.Handled = true;       // 더이상 이벤트가 가지 않는다.
        }

        private void elp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("타원");
        }

        private void txt_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("텍스트");
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine("버튼클릭");
        }

        private void grd_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("preview 그리드");
        }

        private void cvs_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("preview 캔버스");
        }

        private void elp_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("preview 타원");
        }
    }
}
