using System.Linq;
using System.Windows;
using Home;
namespace subway.EnterAndLeave
{
    /// <summary>
    /// EnterWindow.xaml 的交互逻辑
    /// </summary>
    public partial class EnterWindow : Window
    {
        public EnterWindow()
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
                if (x == 1 || x == 2)
                {
                    textBlock.Text = "";
                    MyClass.tickets.Remove(t1);
                    t1.isUseful = -x;
                    MyClass.tickets.Add(t1);
                    string ss;
                    ss = (x == 2 ? "双程票" : "单程票");
                    Enter1 lo = new Enter1(t1, ss);
                    lo.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    this.Close();
                    lo.ShowDialog();
                }
                else if (x == 0)
                {
                    textBlock.Text = "此卡已报销";

                    return;
                }
                else if (x < 0)
                {
                    textBlock.Text = "此卡为进站状态";
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
