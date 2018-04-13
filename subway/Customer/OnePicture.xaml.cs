using subway;
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

namespace Home.Customer
{
    /// <summary>
    /// OnePicture.xaml 的交互逻辑
    /// </summary>
    public partial class OnePicture : Page
    {
        CustomerWindow cu;
        
        public OnePicture(CustomerWindow tu)
        {
            InitializeComponent();
            this.cu = tu;
        }
        private void Button_Click(object sender, RoutedEventArgs e)//张数
        {
            
            Button btn = sender as Button;
            string str = btn.Name;
                switch (str)
            {
                case "st":

                    cu.label3.Content = "  市体育中心";
                    cu.textblock2.Text = "2元";

                    break;
                case "bx": cu.label3.Content = "博学路"; cu.textblock2.Text = "2元"; break;
                case "zz": cu.label3.Content = "郑州东站"; cu.textblock2.Text = "2元"; break;
                case "df": cu.label3.Content = "东风南路"; cu.textblock2.Text = "2元"; break;
                case "ny": cu.label3.Content = "农业南路"; cu.textblock2.Text = "3元"; break;
                case "hh": cu.label3.Content = "黄河南路"; cu.textblock2.Text = "3元"; break;
                case "hz": cu.label3.Content = "会展中心"; cu.textblock2.Text = "3元"; break;
                case "mh": cu.label3.Content = "民航路"; cu.textblock2.Text = "3元"; break;
                case "yz": cu.label3.Content = "燕庄"; cu.textblock2.Text = "4元"; break;
                case "zj": cu.label3.Content = "紫荆山"; cu.textblock2.Text = "4元"; break;
                case "rm": cu.label3.Content = "人民路"; cu.textblock2.Text = "4元"; break;
                case "eq": cu.label3.Content = "二七广场"; cu.textblock2.Text = "4元"; break;
                case "zzh": cu.label3.Content = "郑州火车站"; cu.textblock2.Text = "5元"; break;
                case "yxy": cu.label3.Content = "医学院"; cu.textblock2.Text = "5元"; break;
                case "lcgc": cu.label3.Content = "绿城广场"; cu.textblock2.Text = "5元"; break;
                case "bsg": cu.label3.Content = "碧沙岗"; cu.textblock2.Text = "5元"; break;
                case "tbl": cu.label3.Content = "桐柏路"; cu.textblock2.Text = "6元"; break;
                case "qll": cu.label3.Content = "秦林路"; cu.textblock2.Text = "6元"; break;
                case "xsh": cu.label3.Content = "西三环"; cu.textblock2.Text = "6元"; break;
                case "xlh": cu.label3.Content = "西流湖"; cu.textblock2.Text = "6元"; break;
            }

        }
    }
}

