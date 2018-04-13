using Home;
using Home.Customer;
using subway.EnterAndLeave;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace subway.Customer
{
    /// <summary>
    /// MessageWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MessageWindow : Window
    { 
        private string YongHuMing;
        public MessageWindow(string yonghuming)
        {
            InitializeComponent();
            this.YongHuMing = yonghuming;
            using(var context=new MyDbEntities2())
            {
                var q = from t in context.Ticket
                        where t.YongHuMing == this.YongHuMing
                        select t;
                foreach(var v in q)
                {
                    textblock0.Text = v.YongHuMing;
                    textblock1.Text = v.Issigle;
                    textblock3.Text = v.Destination;
                    textblock4.Text = v.Cost+"元";
                    textblock5.Text = v.Num+"张";
                    if (textblock1.Text.Equals("单程票")) label1.Content = v.Num * v.Cost;
                    else label1.Content = v.Num * v.Cost * 2;
                    //MessageBox.Show(v.Cost+"database "+v.Num);
                    break;
                }
                var q1 = from t in context.Client
                         where t.YongHuMing ==this.YongHuMing
                         select t;
                foreach(var v in q1)
                {
                    //label2.Content = v.YuE;
                    break;
                }

            }
        }

        private void ButtonOK_Click(object sender, RoutedEventArgs e)
        {

            using (var context = new MyDbEntities2())
            {   
                    
                var q1 = from t in context.Client
                         where t.YongHuMing == this.YongHuMing
                         select t;
                foreach (var v in q1)
                {
                    label2.Content = v.YuE;
                    break;
                }

            }
            MessageBox.Show("购票成功");

            int num = 2;
            if (textblock1.Text.Equals("单程票"))
            {
                num = 1;
            }
            string str = textblock4.Text;
            string str1 = str.Substring(0, str.Length - 1);
            int money = int.Parse(str1);

            string str2 = textblock5.Text;
            string str3 = str.Substring(0, str.Length - 2);
            int number = int.Parse(str1);
            for (int i = 0; i < number; i++)
            {
                MyClass.my(textblock3.Text, money, num);
            }

            MainWindow ma = new MainWindow();
            this.Close();
            ma.ShowDialog();
        }

        private void Button_cancel_Click(object sender, RoutedEventArgs e)
        {
            CustomerWindow pa = new CustomerWindow();
            //PayforWindow pa = new PayforWindow(this);
            this.Close();
            pa.ShowDialog();
            
        }
    }
}
