using System;
using System.Collections;
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

namespace ch15_10_ComboBox_Binding
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetData();
        }

        private void SetData()
        {
            // Binding시키는 코드..
            //cboCustGbn.ItemsSource = GetData();

            // IsEditable을 주기 위해 Binding을 쓰지 않고 하나씩 레코드를 추가한 경우...
            foreach (var item in GetData())
            {
                ComboBoxItem ci = new ComboBoxItem();

                ci.Content = item.strName;
                cboCustGbn.Items.Add(ci);
            }

            cboCustGbn.SelectedIndex = 0;
        }

        private List<CommonCode> GetData()
        {
            List<CommonCode> list = new List<CommonCode>();

            list.Add(new CommonCode() { strCode = "101", strName = "일반고객" });
            list.Add(new CommonCode() { strCode = "201", strName = "중요고객" });
            list.Add(new CommonCode() { strCode = "301", strName = "VIP" });
            list.Add(new CommonCode() { strCode = "901", strName = "휴고객" });

            return list;
        }
    }

    class CommonCode
    {
        public string strCode { get; set; }
        public string strName { get; set; }
    }
}
