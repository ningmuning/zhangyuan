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

namespace subway.EnterAndLeave
{
    /// <summary>
    /// LeaveWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LeaveWindow : Window
    {
        public LeaveWindow()
        {
            InitializeComponent();
        }
        private void buttonOK_Click(object sender, RoutedEventArgs e)
        {
            int n;
            if (int.TryParse(text.Text, out n) == false)
            {
                MessageBox.Show("请将票插入插口");
                return;
            }

            var q = from t in MyClass.tickets
                    where t.Number == n
                    select t;
            if (q.Count() == 0)
            {
                textBlock.Text = "无此卡";
                return;
            }
            foreach (var t1 in q)
            {
                int x = t1.isUseful;
                if (x == -1 || x == -2)
                {
                    textBlock.Text = "";
                    MyClass.tickets.Remove(t1);
                    string str = "";
                    if (x == -2)
                    {
                        t1.Price /= 2;
                        str = t1.End;
                        t1.End = t1.Start;
                        t1.Start = str;
                    }
                    t1.isUseful = -x - 1;
                    MyClass.tickets.Add(t1);

                    Leave1 lo = new Leave1(t1);
                    lo.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    this.Close();
                    lo.ShowDialog();
                }
                else if (x == 0)
                {
                    textBlock.Text = "此卡已报销";
                    return;
                }
                else if (x > 0)
                {
                    textBlock.Text = "此卡为新卡";
                }
                return;
            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ma = new MainWindow();
            this.Close();
            ma.ShowDialog();
        }
    }
}
