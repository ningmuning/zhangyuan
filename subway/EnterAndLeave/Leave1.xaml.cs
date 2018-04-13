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
    /// Leave1.xaml 的交互逻辑
    /// </summary>
    public partial class Leave1 : Window
    {
        MyTicket t1;
        public Leave1(MyTicket t1)
        {
            InitializeComponent();
            this.t1 = t1;
            for (int i = 0; i < MyClass.place.Length; i++)
            {
                comboBox.Items.Add(MyClass.place[i]);
            }
        }
        private void buttonOK_Click(object sender, RoutedEventArgs e)
        {
            int num = comboBox.SelectedIndex;
            if(t1.Price>=MyClass.pri[num])
            {
                MessageBox.Show("一路顺风");
                MainWindow ma = new MainWindow();
                this.Close();
                ma.ShowDialog();
            }
            else
            {
                MessageBox.Show("请补票");
                MainWindow ma = new MainWindow();
                this.Close();
                ma.ShowDialog();
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
