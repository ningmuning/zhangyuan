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
    /// Close.xaml 的交互逻辑
    /// </summary>
    public partial class Close : Page
    {
        public Close(Management ma)
        {
            InitializeComponent();
            button_OK.Click += Button_OK_Click;
            if (ma.button.Content.ToString() == "中文") changCN();
            else changEN();
        }
        private void changEN()
        {
            ResourceDictionary rd = new ResourceDictionary();
            rd.Source = new Uri("DictionaryEN.xaml", UriKind.Relative);
            label1.Resources.MergedDictionaries.Add(rd);
            label2.Resources.MergedDictionaries.Add(rd);      
            button_OK.Resources.MergedDictionaries.Add(rd);
            button_Cancel.Resources.MergedDictionaries.Add(rd);
        }

        public void changCN()
        {
            ResourceDictionary rd = new ResourceDictionary();
            rd.Source = new Uri("DictionaryCN.xaml", UriKind.Relative);
            label1.Resources.MergedDictionaries.Add(rd);
            label2.Resources.MergedDictionaries.Add(rd);
            button_OK.Resources.MergedDictionaries.Add(rd);
            button_Cancel.Resources.MergedDictionaries.Add(rd);   
        }
        private void Button_OK_Click(object sender, RoutedEventArgs e)
        {

            bool flag = false;
            using (var context = new MyDbEntities2())
            {
                var q = from t in context.Client
                        where t.YongHuMing == textBox1.Text
                        select t;
                if (q.Count() == 0)
                {
                    MessageBox.Show("该用户没有注册！");
                    return;
                }
                foreach (var v in q)
                {
                    if (v.PassWord.Equals(passwordBox.Password)) flag = true;
                    break;
                }
                if (!flag)
                {
                    MessageBox.Show("密码错误，请重新输入");
                    return;
                }
                foreach (var v in q)
                {
                    if (v.YuE > 0)
                    {
                        MessageBox.Show("您家有米,不许删除！");
                        return;
                    }
                    context.Client.Remove(v);
                    break;   
                }

                var q1 = from t in context.Ticket
                        where t.YongHuMing == textBox1.Text
                        select t;
                foreach (var v in q1)
                {
                    context.Ticket.Remove(v); 
                    break;
                }
                context.SaveChanges();
                MessageBox.Show("删除成功！");
            }
        }
    }    
}
