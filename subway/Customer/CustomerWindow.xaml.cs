using subway;
using subway.Customer;
using subway.MyManage;
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
    /// CustomerWindow.xaml 的交互逻辑
    /// </summary>
    public partial class CustomerWindow : Window
    {
        bool flag;
        System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
        public CustomerWindow()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Start();
        }
        public CustomerWindow(int price,int num)
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Start();
            textbox1.Text = num + "张";
            textblock2.Text = price + "元";
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            label.Content = DateTime.Now.ToString(" MM:dd:HH:mm:ss");
        }

        private void Button_Click(object sender, RoutedEventArgs e)//张数
        {
            Button bt = sender as Button;
            textbox1.Text = bt.Content.ToString();                                     
        }
        private void Button2_Click(object sender, RoutedEventArgs e)//金额
        {
            Button bt = sender as Button;
            textblock2.Text = bt.Content.ToString();
            string str = bt.Content.ToString();
            switch (str)
            {
                case "2元":
                    label3.Content = "东风南路";
                    break;
                case "3元":
                    label3.Content = "民航路";
                    break;
                case "4元":
                    label3.Content = "二七广场";
                    break;
                case "5元":
                    label3.Content = "碧沙岗";
                    break;
                case "6元":
                    label3.Content = "西流湖";
                    break;

            }
        }
        private void ButtonOK_Click(object sender, RoutedEventArgs e)
        {
            //ShowTable st = new ShowTable();
            //st.Show();

            LoginWindow lo = new LoginWindow(this);
            //CustomerWindow cu = new CustomerWindow();
            lo.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            this.Close();
            lo.ShowDialog();
            
            lo.textblock4.Text = this.textblock2.Text;            
        }

        private void buttonG_Click(object sender, RoutedEventArgs e)
        {
            string path = "/Customer/GeneralPicture.xaml";
            Uri source = new Uri(path,UriKind.Relative);
            
            frame2.NavigationService.RemoveBackEntry();
           
            frame2.Source = source;
        }

        private void buttonO_Click(object sender, RoutedEventArgs e)
        {
            frame2.Content = new OnePicture(this);
            //string path = "/Customer/OnePicture.xaml";
            //Uri source = new Uri(path, UriKind.Relative);

            //frame2.NavigationService.RemoveBackEntry();

            //frame2.Source = source;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textbox1.Text = "0张" ;
            textblock2.Text = "0元";
            label3.Content = "郑州地铁";
        }

        private void Button_cancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ma = new MainWindow();
            this.Close();
            ma.ShowDialog();
           

        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            ResourceDictionary rd = new ResourceDictionary();
            if (flag)
            {
                rd.Source = new Uri("DictionaryCustomer.xaml", UriKind.Relative);
                label3.Resources.MergedDictionaries.Add(rd);
                label1.Resources.MergedDictionaries.Add(rd);
                label2.Resources.MergedDictionaries.Add(rd);
                buttonG.Resources.MergedDictionaries.Add(rd);
                buttonO.Resources.MergedDictionaries.Add(rd);
                m1.Resources.MergedDictionaries.Add(rd);
                m2.Resources.MergedDictionaries.Add(rd);
                m3.Resources.MergedDictionaries.Add(rd);
                m4.Resources.MergedDictionaries.Add(rd);
                m5.Resources.MergedDictionaries.Add(rd);
                b1.Resources.MergedDictionaries.Add(rd);
                b2.Resources.MergedDictionaries.Add(rd);
                b3.Resources.MergedDictionaries.Add(rd);
                b4.Resources.MergedDictionaries.Add(rd);
                b5.Resources.MergedDictionaries.Add(rd);
                b6.Resources.MergedDictionaries.Add(rd);
                b7.Resources.MergedDictionaries.Add(rd);
                b8.Resources.MergedDictionaries.Add(rd);
                b9.Resources.MergedDictionaries.Add(rd);
                b10.Resources.MergedDictionaries.Add(rd);
                ButtonOK.Resources.MergedDictionaries.Add(rd);
                Button_cancel.Resources.MergedDictionaries.Add(rd);
                button.Resources.MergedDictionaries.Add(rd);
                textblock2.Resources.MergedDictionaries.Add(rd);
                textbox1.Resources.MergedDictionaries.Add(rd);
                labelm.Resources.MergedDictionaries.Add(rd);
                ylabel.Resources.MergedDictionaries.Add(rd);
                ylabelm.Resources.MergedDictionaries.Add(rd);
                comboBox1.Resources.MergedDictionaries.Add(rd);
            }
            else
            {
                //ResourceDictionary rd = new ResourceDictionary();
                rd.Source = new Uri("DictionaryCustomer1.xaml", UriKind.Relative);
                label3.Resources.MergedDictionaries.Add(rd);
                label1.Resources.MergedDictionaries.Add(rd);
                label2.Resources.MergedDictionaries.Add(rd);
                buttonG.Resources.MergedDictionaries.Add(rd);
                buttonO.Resources.MergedDictionaries.Add(rd);
                m1.Resources.MergedDictionaries.Add(rd);
                m2.Resources.MergedDictionaries.Add(rd);
                m3.Resources.MergedDictionaries.Add(rd);
                m4.Resources.MergedDictionaries.Add(rd);
                m5.Resources.MergedDictionaries.Add(rd);
                b1.Resources.MergedDictionaries.Add(rd);
                b2.Resources.MergedDictionaries.Add(rd);
                b3.Resources.MergedDictionaries.Add(rd);
                b4.Resources.MergedDictionaries.Add(rd);
                b5.Resources.MergedDictionaries.Add(rd);
                b6.Resources.MergedDictionaries.Add(rd);
                b7.Resources.MergedDictionaries.Add(rd);
                b8.Resources.MergedDictionaries.Add(rd);
                b9.Resources.MergedDictionaries.Add(rd);
                b10.Resources.MergedDictionaries.Add(rd);
                ButtonOK.Resources.MergedDictionaries.Add(rd);
                Button_cancel.Resources.MergedDictionaries.Add(rd);
                button.Resources.MergedDictionaries.Add(rd);
                textblock2.Resources.MergedDictionaries.Add(rd);
                textbox1.Resources.MergedDictionaries.Add(rd);
                labelm.Resources.MergedDictionaries.Add(rd);
                ylabel.Resources.MergedDictionaries.Add(rd);
                ylabelm.Resources.MergedDictionaries.Add(rd);
                comboBox1.Resources.MergedDictionaries.Add(rd);
            }
            flag = !flag;
        }
    }
}
