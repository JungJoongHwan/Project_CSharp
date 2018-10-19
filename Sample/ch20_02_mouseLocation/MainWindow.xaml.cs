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

namespace ch20_02_mouseLocation
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

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            Point p2 = Mouse.GetPosition(this);
            Debug.WriteLine("[Window] x: " + p2.X + " y: " + p2.Y);

            //Point p3 = cvsMain.TransformToAncestor(this).Transform(Mouse.GetPosition(cvsMain));
            Point p3 = cvsMain.TransformToAncestor(this).Transform(new Point(0,0));
            Debug.WriteLine("cvsMain(0,0) => Window: x: " + p2.X + " y: " + p2.Y);
        }

        private void cvsMain_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = Mouse.GetPosition(cvsMain);
            Debug.WriteLine("[cvsMain] x: " + p.X + " y: " + p.Y);

        }

        private void grdMain_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        
    }
}
