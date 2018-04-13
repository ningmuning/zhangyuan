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
    /// Add.xaml 的交互逻辑
    /// </summary>
    public partial class Add : Page
    {
        public Add(Management ma)
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
            label3.Resources.MergedDictionaries.Add(rd);
            button_OK.Resources.MergedDictionaries.Add(rd);
            button_Cancel.Resources.MergedDictionaries.Add(rd);
        }

        public void changCN()
        {
            ResourceDictionary rd = new ResourceDictionary();
            rd.Source = new Uri("DictionaryCN.xaml", UriKind.Relative);
            label1.Resources.MergedDictionaries.Add(rd);
            label2.Resources.MergedDictionaries.Add(rd);
            label3.Resources.MergedDictionaries.Add(rd);
            button_OK.Resources.MergedDictionaries.Add(rd);
            button_Cancel.Resources.MergedDictionaries.Add(rd);
        }

        private void Button_OK_Click(object sender, RoutedEventArgs e)
        {
            bool flag = false;
            using(var context =new MyDbEntities2())
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
                    if (v.PassWord.Equals(passBox.Password)) flag = true; 
                    break;
                }
                if (!flag) {
                    MessageBox.Show("密码错误，请重新输入");
                    return;
                }

                int num = 0;
                var q1 = from t1 in context.Company
                         where t1.ZhanghuId == "0001"
                         select t1;
                int coumt = q1.Count();
                Company c = new Company();
                c.Value = int.Parse(textBox3.Text);
                num = (int)c.Value;
                c.YuE += c.Value;
                c.Laiziyu = textBox1.Text;
                c.ZhanghuId = "0001";
                DateTime date = new DateTime();
                c.Modifydate = date;
                c.Index = q1.Count() + 1;
                context.Company.Add(c);
                foreach (var v in q1)
                {
                    v.Addordec = "打入";
                    try
                    {
                        v.Value = int.Parse(textBox3.Text);
                        num = (int)v.Value;
                        v.YuE += v.Value;
                        v.Laiziyu = textBox1.Text;
                        DateTime date1 = new DateTime();
                        v.Modifydate = date1;
                    }
                    catch
                    {
                        MessageBox.Show("充值金额为整数");
                        return;
                    }
                    break;
                }
                var q2 = from t in context.Client
                         where t.YongHuMing == textBox1.Text
                         select t;
                foreach(var v in q2)
                {
                    //if (v.YongHuMing.Equals("阿波罗")) MessageBox.Show("阿波罗");
                    v.YuE += num;
                    break;
                }
                context.SaveChanges();
                MessageBox.Show("充值成功！");
            }
        }
    }
}
