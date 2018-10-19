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

namespace ch20_03
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

        private void cvs01_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Mouse.Capture(cvs01);   // 마우스캡쳐시작
            Mouse.OverrideCursor = Cursors.AppStarting; // 마우스커서변경
        }

        private void cvs01_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = Mouse.GetPosition(cvs01);
            Debug.WriteLine("[MouseMove] x: " + p.X + " y: " + p.Y);
        }

        private void cvs01_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Mouse.Capture(null);    // 마우스캡쳐릴리즈
            Mouse.OverrideCursor = null;    // 마우스커서 환원
        }
    }
}
