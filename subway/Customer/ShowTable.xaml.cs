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

namespace subway.Customer
{
    /// <summary>
    /// ShowTable.xaml 的交互逻辑
    /// </summary>
    public partial class ShowTable : Window
    {
        public ShowTable()
        {
            InitializeComponent();
            using (var context = new MyDbEntities2())
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
                             来源账户 = t.Laiziyu
                         };
                dataGrid1.ItemsSource = q1.ToList();
                var q2 = from t in context.Ticket
                         select new
                         {
                             用户名 = t.YongHuMing,
                             购票数量 = t.Num,
                             购票单价 = t.Cost,
                             目的地 = t.Destination
                         };
                dataGrid2.ItemsSource = q2.ToList();
            }
        }
    }
}
