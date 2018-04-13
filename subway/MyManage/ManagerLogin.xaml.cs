using Home;
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

namespace subway.MyManage
{
    /// <summary>
    /// ManagerLogin.xaml 的交互逻辑
    /// </summary>
    public partial class ManagerLogin : Window
    {
        bool flag;
        public ManagerLogin()
        {
            InitializeComponent();
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            using(var context=new MyDbEntities2())
            {
                var q = from t in context.Manager
                        where t.GuanLiYuanID == textBox.Text && t.password == passwordBox.Password
                        select t;
                if (q.Count() >= 1)
                {
                    Management ma = new Management();
                    this.Close();
                     ma.Show();
                }
                else
                {
                    MessageBox.Show("不存在此管理员");
                }
            }        
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ma = new MainWindow();
            this.Close();
            ma.ShowDialog();
           
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (flag)
            {
                ResourceDictionary rd = new ResourceDictionary();
                rd.Source = new Uri("DictionaryAdmin.xaml", UriKind.Relative);
                location.Resources.MergedDictionaries.Add(rd);
                label_Copy.Resources.MergedDictionaries.Add(rd);
                label_Copy1.Resources.MergedDictionaries.Add(rd);
                button.Resources.MergedDictionaries.Add(rd);
                button_Copy.Resources.MergedDictionaries.Add(rd);
                button1.Resources.MergedDictionaries.Add(rd);
            }
            else
            {
                ResourceDictionary rd = new ResourceDictionary();
                rd.Source = new Uri("DictionaryAdmin1.xaml", UriKind.Relative);
                location.Resources.MergedDictionaries.Add(rd);
                label_Copy.Resources.MergedDictionaries.Add(rd);
                label_Copy1.Resources.MergedDictionaries.Add(rd);
                button.Resources.MergedDictionaries.Add(rd);
                button_Copy.Resources.MergedDictionaries.Add(rd);
                button1.Resources.MergedDictionaries.Add(rd);
            }
            flag = !flag;
        }
    }
}
