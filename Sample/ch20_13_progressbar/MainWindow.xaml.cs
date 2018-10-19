using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace ch20_13_progressbar
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            pb.Value += 10;
        }

        private void btnAutoAdd_Click(object sender, RoutedEventArgs e)
        {
            //-----------------------------------------------------------
            // 이렇게 처리하면 안된다... 
            //pb.Value = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    pb.Value += 1;
            //    Thread.Sleep(100);
            //}

            //-----------------------------------------------------------
            // 아래와 같이 별도의 쓰레드로 처리해야 한다...

            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += Bw_DoWork;

            bw.WorkerReportsProgress = true;
            bw.ProgressChanged += Bw_ProcessChanged;
            bw.RunWorkerCompleted += Bw_RunWorkerCompleted;
            bw.RunWorkerAsync();
        }

        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //throw new NotImplementedException();
            pb.Value = pb.Maximum;
            MessageBox.Show("다운로드가 완료되었습니다.");
        }

        private void Bw_ProcessChanged(object sender, ProgressChangedEventArgs e)
        {
            //throw new NotImplementedException();
            pb.Value = e.ProgressPercentage;
        }

        private void Bw_DoWork(object sender, DoWorkEventArgs e)
        {
            //throw new NotImplementedException();
            for (int i = 0; i < 100; i++)
            {
                ((BackgroundWorker)sender).ReportProgress(i);
                Thread.Sleep(100);
            }
        }
    }
}
