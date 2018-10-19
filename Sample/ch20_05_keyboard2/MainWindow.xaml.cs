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

namespace ch20_05_keyboard2
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

        private void btnFind_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            find();
        }

        private void find()
        {
            MessageBox.Show(txtFind.Text + "문자(열)로 검색을 완료했습니다.");
        }

        private void txtFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.LeftCtrl) && Keyboard.IsKeyDown(Key.F))
            {
                e.Handled = true;   // 이벤트가 확산되는 것을 막는다.
                find();
            }
        }
    }
}
