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

namespace ch20_14_webBrowser
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            wb.Navigate("http://naver.com");
        }

        private void txtUrl_KeyUp(object sender, KeyEventArgs e)
        {
            //wb.Navigate(txtUrl.Text);  --> 바로 이렇게 하면 'http://' 문자열이 없을경우 에러가 난다.

            if (e.Key == Key.Enter)
            {
                string str = txtUrl.Text.Trim();
                if (str.Length >= 4 && str.Substring(0,4) != "http")
                {
                    str = "http://" + str;
                }

                wb.Navigate(str);
            }
        }
    }
}
