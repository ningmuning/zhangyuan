using subway;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using subway.MyWindows;
using subway.Customer;
using subway.MyManage;
using Home.Customer;
using subway.EnterAndLeave;

namespace Home
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        bool flag;
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        
        }       

        void LoginWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.DialogResult != true)
            {
                App.Current.Shutdown();
            }
        }

        void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        void btnOK_Click(object sender, RoutedEventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                CustomerWindow cu = new CustomerWindow();
                cu.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
                 this.Close();
                cu.ShowDialog();
               
            }

            else
            {
                ManagerLogin ma = new ManagerLogin();
                ma.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
                this.Close();
                ma.ShowDialog();
                

            }
        

          
            }

        private void buttonEnter_Click(object sender, RoutedEventArgs e)
        {
            EnterWindow ma = new EnterWindow();
            ma.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.Close();
            ma.ShowDialog();
        }

        private void buttonLeave_Click(object sender, RoutedEventArgs e)
        {
            LeaveWindow ma = new LeaveWindow();
            ma.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.Close();
            ma.ShowDialog();
        }

        private void ChangLanguage_Click(object sender, RoutedEventArgs e)
        {
            ResourceDictionary rd = new ResourceDictionary();
            if (flag)
            {                               
                rd.Source = new Uri("DictionaryRegister.xaml", UriKind.Relative);
                label1.Resources.MergedDictionaries.Add(rd);
                buttonEnter.Resources.MergedDictionaries.Add(rd);
                buttonLeave.Resources.MergedDictionaries.Add(rd);
                btnOK.Resources.MergedDictionaries.Add(rd);
                btnCancel.Resources.MergedDictionaries.Add(rd);
                ChangLanguage.Resources.MergedDictionaries.Add(rd);
                comboBox1.Resources.MergedDictionaries.Add(rd);
            }
            else
            {
                //ResourceDictionary rd = new ResourceDictionary();            
                rd.Source = new Uri("DictionaryRegister1.xaml", UriKind.Relative);
                label1.Resources.MergedDictionaries.Add(rd);
                buttonEnter.Resources.MergedDictionaries.Add(rd);
                buttonLeave.Resources.MergedDictionaries.Add(rd);
                btnOK.Resources.MergedDictionaries.Add(rd);
                btnCancel.Resources.MergedDictionaries.Add(rd);
                ChangLanguage.Resources.MergedDictionaries.Add(rd);
                comboBox1.Resources.MergedDictionaries.Add(rd);
            }
            flag = !flag;
        }
    }
    
}
