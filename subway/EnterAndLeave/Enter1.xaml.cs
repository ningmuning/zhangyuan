using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Home;
namespace subway.EnterAndLeave
{
    /// <summary>
    /// Enter1.xaml 的交互逻辑
    /// </summary>
    public partial class Enter1 : Window
    {
        public Enter1(MyTicket t1,string ss)
        {
            InitializeComponent();
            textBlock.Text =  "起始车站:  " + t1.Start;
            textBlock1.Text = "目的车站:  " + t1.End;
            textBlock2.Text = "票    种:  " + ss;
            textBlock3.Text = "单    价:  " + t1.Price;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ma = new MainWindow();
            this.Close();
            ma.ShowDialog();
        }
    }
}
