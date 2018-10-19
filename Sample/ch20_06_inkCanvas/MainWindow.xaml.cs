using System;
using System.Collections.Generic;
using System.IO;
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

namespace ch20_06_inkCanvas
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

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            cvsMain.Strokes.Clear();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream("draw.data", FileMode.Create);
            cvsMain.Strokes.Save(fs);
            fs.Close();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            FileStream fs = new FileStream("draw.data", FileMode.Open);
            cvsMain.Strokes = new System.Windows.Ink.StrokeCollection(fs);
            fs.Close();
        }
    }
}
