using subway;
using subway.Customer;
using subway.EnterAndLeave;
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
using System.Windows.Shapes;

namespace Home.Customer
{
    /// <summary>
    /// LoginWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindow : Window
    {
       
        int price,num;
        public LoginWindow(Window tu)
        {
            CustomerWindow cu = tu as CustomerWindow;
            InitializeComponent();
            textblock3.Text = cu.label3.Content.ToString();
            textblock4.Text = cu.textblock2.Text;
            textblock5.Text = cu.textbox1.Text;
            try
            {
                price = int.Parse(cu.textblock2.Text.Substring(0, cu.textblock2.Text.Length - 1));
                num = int.Parse(cu.textbox1.Text.Substring(0, cu.textbox1.Text.Length - 1));
            }
            catch(Exception et)
            {
                MessageBox.Show(et.Message+"LoginWindow类型转化失败！");
            }

            if (cu.comboBox1.SelectedIndex == 0)
            {
                textblock1.Text = "单程票";
                label1.Content = price * num + "元";
            }
            else
            {
                textblock1.Text = "双程票";
                label1.Content = price * num*2 + "元";
            }
        }
        public LoginWindow() { InitializeComponent(); }
        private void ButtonOK_Click(object sender, RoutedEventArgs e)
        {
            PayforWindow pa = new PayforWindow(this);                            
            pa.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            this.Close();
            pa.ShowDialog();
            
        }

        private void Button_cancel_Click(object sender, RoutedEventArgs e)
        {
            CustomerWindow cu = new CustomerWindow(this.price,this.num);
            cu.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            this.Close();
            cu.ShowDialog();
        }

        private void Button_zhifubao_Click_1(object sender, RoutedEventArgs e)
        {
            PayWindow p = new PayWindow();
            p.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            p.ShowDialog();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
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
      
    }
}
