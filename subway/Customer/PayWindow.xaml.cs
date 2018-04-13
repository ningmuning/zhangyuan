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

namespace Home.Customer
{
    /// <summary>
    /// PayWindow.xaml 的交互逻辑
    /// </summary>
    public partial class PayWindow : Window
    {
        private string YongHuMing;
        public PayWindow()
        {
            InitializeComponent();
        }

        private void Button_cancel_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow l = new LoginWindow(this);
            l.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            this.Close();
            l.ShowDialog();
        }
    }
}
