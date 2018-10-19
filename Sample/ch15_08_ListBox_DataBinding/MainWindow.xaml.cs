using System;
using System.Collections;
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

namespace ch15_08_ListBox_DataBinding
{
    class Cust
    {
        public string strCustName { get; set; }
        public string strCustTel { get; set; }
        public int intPoint { get; set; }
    }

    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            lstCust.ItemsSource = GetCustData();
        }

        private List<Cust> GetCustData()
        {
            List<Cust> list = new List<Cust>();

            list.Add(new Cust() { strCustName = "홍길동", strCustTel = "010-1234-1234", intPoint=50 });
            list.Add(new Cust() { strCustName = "김유신", strCustTel = "010-1111-1111", intPoint=60 });
            list.Add(new Cust() { strCustName = "강감찬", strCustTel = "010-2222-2222", intPoint=20 });
            list.Add(new Cust() { strCustName = "이순신", strCustTel = "010-3333-3333", intPoint=10 });
            list.Add(new Cust() { strCustName = "유관순", strCustTel = "010-1234-5678", intPoint=80 });

            return list;
        }

        private void btnSelectCust_Click(object sender, RoutedEventArgs e)
        {
            if (lstCust.SelectedItem != null)
            {
                Cust cust = (Cust)lstCust.SelectedItem;
                MessageBox.Show(cust.strCustName + "님의 전화번호는 " + cust.strCustTel + "입니다.");
            }
            else
            {
                MessageBox.Show("고객을 먼저 선택해주세요!!");
            }
        }

        private void lstCust_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstCust.SelectedItem != null)
            {
                Cust cust = (Cust)lstCust.SelectedItem;
                this.Title = cust.strCustName;
            }
            else
            {
                MessageBox.Show("고객을 먼저 선택해주세요!!");
            }
        }

        private void btnPrevCust_Click(object sender, RoutedEventArgs e)
        {
            if (lstCust.SelectedItem != null)
            {
                int index = lstCust.SelectedIndex - 1;
                if (index < 0)
                {
                    index = lstCust.Items.Count-1;
                }

                lstCust.SelectedIndex = index;
            }
            else
            {
                MessageBox.Show("고객을 먼저 선택해주세요!!");
            }
        }

        private void btnNextCust_Click(object sender, RoutedEventArgs e)
        {
            if (lstCust.SelectedItem != null)
            {
                int index = lstCust.SelectedIndex + 1;
                if (index >= lstCust.Items.Count)
                {
                    index = 0;
                }

                lstCust.SelectedIndex = index;
            }
            else
            {
                MessageBox.Show("고객을 먼저 선택해주세요!!");
            }
        }

        private void btnAllCust_Click(object sender, RoutedEventArgs e)
        {
            lstCust.SelectAll();        // ListBox에서 SelectionMode="Extended" 해야한다.

        }

        private void btnViewAll_Click(object sender, RoutedEventArgs e)
        {
            foreach (Cust item in lstCust.SelectedItems)
            {
                Debug.WriteLine(item.strCustName + "(" + item.strCustTel + ")");
            }
        }
    }
}
