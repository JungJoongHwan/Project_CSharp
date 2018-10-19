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

namespace ch15_11_ComboBox_event
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
            cboSiDo.ItemsSource = GetData_SiDo();
            cboGuGun.ItemsSource = null;
            cboDong.ItemsSource = null;
        }

        private List<SiDo> GetData_SiDo()
        {
            List<SiDo> list = new List<SiDo>();
            list.Add(new SiDo() { strCode = "02", strName = "서울" });
            list.Add(new SiDo() { strCode = "031", strName = "경기" });
            list.Add(new SiDo() { strCode = "032", strName = "인천" });

            return list;
        }

        private void cboSiDo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboSiDo.SelectedItem != null)
            {
                SiDo sido = (SiDo)cboSiDo.SelectedItem;
                cboGuGun.ItemsSource = GetData_GuGun(sido.strCode);
            }
        }

        private List<GuGun> GetData_GuGun(string strCode)
        {
            List<GuGun> list = new List<GuGun>();
            if (strCode == "02")
            {
                list.Add(new GuGun() { strCode = "101", strName = "강남구" });
                list.Add(new GuGun() { strCode = "102", strName = "강서구" });
                list.Add(new GuGun() { strCode = "103", strName = "강동구" });
                list.Add(new GuGun() { strCode = "104", strName = "광진구" });
            }
            else if (strCode == "031")
            {
                list.Add(new GuGun() { strCode = "201", strName = "안양시" });
                list.Add(new GuGun() { strCode = "202", strName = "성남시" });
                list.Add(new GuGun() { strCode = "203", strName = "수원시" });
                list.Add(new GuGun() { strCode = "204", strName = "부천시" });
            }

            return list;
        }
    }

    class SiDo
    {
        public string strCode { get; set; }
        public string strName { get; set; }
    }

    class GuGun
    {
        public string strSiDoCode { get; set; }
        public string strCode { get; set; }
        public string strName { get; set; }
    }

    class Dong
    {
        public string strSiDoCode { get; set; }
        public string strGuGunCode { get; set; }
        public string strCode { get; set; }
        public string strName { get; set; }
    }
}
