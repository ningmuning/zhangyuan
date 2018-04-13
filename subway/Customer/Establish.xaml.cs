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
        public Establish()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            DateTime date = DateTime.Now;
            using (var context=new MyDbEntities1())
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
            }
               
            
        }
    }
}
