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

namespace ch20_04_keyboard
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

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            //-----------------------------------------------------------------

            //if (e.Key == Key.O)
            //{
            //    MessageBox.Show("O 키가 눌려짐");
            //}

            //-----------------------------------------------------------------

            //if (e.Key == Key.LeftCtrl || e.Key == Key.RightCtrl)
            //{
            //    MessageBox.Show("Ctrl키가 눌려짐");
            //}

            //-----------------------------------------------------------------

            //Debug.WriteLine((int)Keyboard.Modifiers);
            //    W  S  C  A   ->   Window, Shift, Control, Alt
            //    1  1  1  1
            // &  0  0  1  0
            //--------------------
            //    0  0  1  0

            //if ((Keyboard.Modifiers & ModifierKeys.Control) != 0)
            //{
            //    MessageBox.Show("Ctrl키가 눌려짐");
            //}

            //-----------------------------------------------------------------

            //if (Keyboard.IsKeyDown(Key.LeftAlt))
            //{
            //    MessageBox.Show("Alt키가 눌려짐");
            //}

            if (Keyboard.IsKeyDown(Key.LeftCtrl) && Keyboard.IsKeyDown(Key.S))
            {
                e.Handled = true;       // S자를 TextBox에 출력안함
                MessageBox.Show("Ctrl + S : 저장완료!");
            }
        }
    }
}
