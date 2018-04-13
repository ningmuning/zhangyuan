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

namespace subway.MyWindows
{
    /// <summary>
    /// Establish.xaml 的交互逻辑
    /// </summary>
    public partial class Establish : Page
    {
        public Establish(Management ma)
        {
            InitializeComponent();
            if (ma.button.Content.ToString() == "中文") changCN();
            else changEN();
        }

        private void changEN()
        {
            ResourceDictionary rd = new ResourceDictionary();
            rd.Source = new Uri("DictionaryEN.xaml", UriKind.Relative);
            label1.Resources.MergedDictionaries.Add(rd);
            label2.Resources.MergedDictionaries.Add(rd);
            label3.Resources.MergedDictionaries.Add(rd);
            label4.Resources.MergedDictionaries.Add(rd);
            label5.Resources.MergedDictionaries.Add(rd);
            button1.Resources.MergedDictionaries.Add(rd);
            button2.Resources.MergedDictionaries.Add(rd);
        }

        public void changCN()
        {
            ResourceDictionary rd = new ResourceDictionary();
            rd.Source = new Uri("DictionaryCN.xaml", UriKind.Relative);
            label1.Resources.MergedDictionaries.Add(rd);
            label2.Resources.MergedDictionaries.Add(rd);
            label3.Resources.MergedDictionaries.Add(rd);
            label4.Resources.MergedDictionaries.Add(rd);
            label5.Resources.MergedDictionaries.Add(rd);
            button1.Resources.MergedDictionaries.Add(rd);
            button2.Resources.MergedDictionaries.Add(rd);
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MyDbEntities2())
            {
                var q = from t1 in context.Client
                        where t1.YongHuMing == username.Text
                        select t1;
                if (q.Count() >= 1)
                {
                    MessageBox.Show("用户名已存在，请直接登陆！");
                    return;
                }
            }
            DateTime date = DateTime.Now;
            using (var context=new MyDbEntities2())
            {
                Client client = new Client()
                {
                    YongHuMing = username.Text,
                    XingMing = name.Text,
                    PassWord = passwordBox.Password,
                    Identify = identify.Text,
                    Tel = telephone.Text,
                    Date = date,
                    YuE = 0
                };
                try
                {
                    context.Client.Add(client);
                    context.SaveChanges();
                } catch (Exception ex)
                {
                    MessageBox.Show("信息不合法！");
                }

                Ticket t = new Ticket();
                t.YongHuMing = username.Text;
                t.Password = passwordBox.Password;
                t.Time = DateTime.Now;
                try
                {
                    context.Ticket.Add(t);
                    context.SaveChanges();
                    MessageBox.Show("创建成功，请登录！");
                }
                catch (Exception ee)
                { 
                    MessageBox.Show(ee.Message+"   ticket");
                }


            }
               
            
        }
    }
}
