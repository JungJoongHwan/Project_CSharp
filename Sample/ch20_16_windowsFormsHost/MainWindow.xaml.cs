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

namespace ch20_16_windowsFormsHost
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            wb.Navigate("http://www.naver.com");
        }

        private void wb_DocumentTitleChanged(object sender, EventArgs e)
        {
            // Forms 브라우저의 웹사이트 타이틀을 가져와서 화면의 타이틀에 넣는다.
            this.Title = (sender as System.Windows.Forms.WebBrowser).DocumentTitle;
        }
    }
}
