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
    /// display.xaml 的交互逻辑
    /// </summary>
    public partial class display : Page
    {
        public display(Management ma)
        {
            InitializeComponent();
            using (var context = new MyDbEntities2())
            {
                if (ma.button.Content.ToString() == "中文")
                {
                    var q = from t in context.Client
                            select new
                            {
                                用户名 = t.YongHuMing,
                                姓名 = t.XingMing,
                                省份证号 = t.Identify,
                                手机号 = t.Tel,
                                账户余额 = t.YuE,
                                开户日期 = t.Date,
                                密码 = t.PassWord
                            };

                    dataGrid.ItemsSource = q.ToList();
                    var q1 = from t in context.Company
                             select new
                             {
                                 账户 = t.ZhanghuId,
                                 余额 = t.YuE,
                                 更改日期 = t.Modifydate,
                                 收入或支出 = t.Addordec,
                                 更改的值 = t.Value,
                                 来源账户 = t.Laiziyu,
                                 序列 = t.Index
                             };
                    dataGrid1.ItemsSource = q1.ToList();
                    var q2 = from t in context.Ticket
                             select new
                             {
                                 用户名 = t.YongHuMing,
                                 购票数量 = t.Num,
                                 购票单价 = t.Cost,
                                 目的地 = t.Destination,
                                 票种 = t.Issigle,
                                 出发站 = t.StartP,
                                 购票时间 = t.Time,
                                 密码 = t.Password
                             };
                    dataGrid2.ItemsSource = q2.ToList();
                }
                else
                {
                    var q = from t in context.Client
                            select new
                            {
                                UserName = t.YongHuMing,
                                Name = t.XingMing,
                                ID = t.Identify,
                                Tele = t.Tel,
                                Remain = t.YuE,
                                DateOpened = t.Date,
                                PassWord = t.PassWord
                            };

                    dataGrid.ItemsSource = q.ToList();
                    var q1 = from t in context.Company
                             select new
                             {
                                 Account = t.ZhanghuId,
                                 Remain = t.YuE,
                                ChangeDate= t.Modifydate,
                                Inorexpense = t.Addordec,
                                 value = t.Value,
                                 From = t.Laiziyu,
                                 Index = t.Index
                             };
                    dataGrid1.ItemsSource = q1.ToList();
                    var q2 = from t in context.Ticket
                             select new
                             {
                                 UserName = t.YongHuMing,
                                 Number = t.Num,
                                 Price = t.Cost,
                                 Destination = t.Destination,
                                 Ticket = t.Issigle,
                                 Start = t.StartP,
                                 BuyDate = t.Time,
                                 Password = t.Password
                             };
                    dataGrid2.ItemsSource = q2.ToList();
                }
            }
        }
    }
}
