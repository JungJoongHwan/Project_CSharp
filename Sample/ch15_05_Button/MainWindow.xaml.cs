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

namespace ch15_05_Button
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AddButton();
        }

        private void AddButton()
        {
            Button btn = new Button();
            btn.FontWeight = FontWeights.Bold;
            btn.Width = 100;
            btn.Height = 30;

            WrapPanel p = new WrapPanel();
            TextBlock txt = new TextBlock();
            txt.Text = "멀티";
            txt.Foreground = Brushes.Blue;
            p.Children.Add(txt);

            TextBlock txt2 = new TextBlock();
            txt2.Text = "색상";
            txt2.Foreground = Brushes.Red;
            p.Children.Add(txt2);

            btn.Content = p;
            spMain.Children.Add(btn);

            btn.Click += Btn_Click;

        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("사용자정의버튼이 클릭되었습니다.");
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("확인 버튼이 클릭되었습니다.");
        }
    }
}
