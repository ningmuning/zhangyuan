using Home;
using subway.MyManage;
using subway.MyWindows;
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

namespace subway {
    /// <summary>
    /// Management.xaml 的交互逻辑
    /// </summary>
    public partial class Management : Window {
        System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
        bool flag = true;
        public Management() {

            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            timer.Tick += Timer_Tick;
            timer.Interval = TimeSpan.FromMilliseconds(1000);
            timer.Start();
           
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            label.Content = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-s");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            //string path = String.Format("/MyWindows/{0}.xaml", btn.Tag);
            //Uri source = new Uri(path, UriKind.Relative);
            frame.NavigationService.RemoveBackEntry();
            frame.Content = new Establish(this);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string path = String.Format("/MyWindows/{0}.xaml", btn.Tag);
            Uri source = new Uri(path, UriKind.Relative);
            frame.NavigationService.RemoveBackEntry();
            frame.Content = new Close(this);
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string path = String.Format("/MyWindows/{0}.xaml", btn.Tag);
            Uri source = new Uri(path, UriKind.Relative);
            frame.NavigationService.RemoveBackEntry();
            frame.Content = new Add(this);
        }
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string path = String.Format("/MyWindows/{0}.xaml", btn.Tag);
            Uri source = new Uri(path, UriKind.Relative);
            frame.NavigationService.RemoveBackEntry();
            frame.Content = new display(this);
        }
        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ma = new MainWindow();
            this.Close();
            ma.ShowDialog();
           
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            if (flag)
            {
                ResourceDictionary rd = new ResourceDictionary();
                rd.Source = new Uri("DictionaryEN.xaml", UriKind.Relative);
                button1.Resources.MergedDictionaries.Add(rd);
                button2.Resources.MergedDictionaries.Add(rd);
                button3.Resources.MergedDictionaries.Add(rd);
                button.Resources.MergedDictionaries.Add(rd);
                display.Resources.MergedDictionaries.Add(rd);
                label1.Resources.MergedDictionaries.Add(rd);
                button_Copy1.Resources.MergedDictionaries.Add(rd);
            }
            else
            {
                ResourceDictionary rd = new ResourceDictionary();
                rd.Source = new Uri("DictionaryCN.xaml", UriKind.Relative);
                button1.Resources.MergedDictionaries.Add(rd);
                button2.Resources.MergedDictionaries.Add(rd);
                button3.Resources.MergedDictionaries.Add(rd);
                button.Resources.MergedDictionaries.Add(rd);
                display.Resources.MergedDictionaries.Add(rd);
                label1.Resources.MergedDictionaries.Add(rd);
                button_Copy1.Resources.MergedDictionaries.Add(rd);
            }
            flag = !flag;
        }
    }
}
