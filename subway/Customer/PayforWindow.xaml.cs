using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using subway.Customer;
using subway;
using Home.Customer;
using System.Timers;
using subway.MyWindows;


namespace subway.Customer
{
    /// <summary>
    /// PayforWindow.xaml 的交互逻辑
    /// </summary>
    public partial class PayforWindow : Window
    {
        System.Windows.Threading.DispatcherTimer timer1 = new System.Windows.Threading.DispatcherTimer();
        private int tryCount = 3;
        private bool isUserNameError = false; //用户名有错时为true
        private bool isPasswordError = false; //密码有错时为true
        private bool isShowError = false;  //错误图标是否可见
        private Timer timer;  //定时器
        int min = 100;

        private string issingle;
        private string start;
        private string end;
        private int price;
        private int num;
        private int allprice;
        private string Password;



        public PayforWindow(Window win)
        {
            InitializeComponent();
            LoginWindow lw = win as LoginWindow;
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            this.issingle = lw.textblock1.Text;
            this.start = lw.textblock2.Text;
            this.end = lw.textblock3.Text;
            try
            {
                this.price = int.Parse(lw.textblock4.Text.Substring(0,lw.textblock4.Text.Length-1));
                this.num = int.Parse(lw.textblock5.Text.Substring(0, lw.textblock5.Text.Length - 1));
                this.allprice = int.Parse(lw.label1.Content.ToString().Substring(0, lw.label1.Content.ToString().Length - 1));
            }
            catch(Exception ee)
            {
                MessageBox.Show("类型转换失败！"+ee.Message);
            }
            


            errorTip1.Visibility = System.Windows.Visibility.Hidden;
            errorTip2.Visibility = System.Windows.Visibility.Hidden;
            timer = new Timer(200);

            timer1.Tick += Timer1_Tick;
            timer1.Interval = TimeSpan.FromMilliseconds(1000);
            timer1.Start();

            timer.Elapsed += timer_Elapsed;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (min > 0)
            {
                min--;
                label2.Content = min + "秒";
            }
            else
            {
                LoginWindow lo = new LoginWindow(this);
                this.Close();
                lo.ShowDialog();
                
            }
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.Dispatcher.InvokeAsync(TimerAction);
        }

        private void TimerAction()
        {
            if (isShowError == true)
            {
                if (isUserNameError)
                {
                    errorTip1.Visibility = System.Windows.Visibility.Visible;
                }
                if (isPasswordError)
                {
                    errorTip2.Visibility = System.Windows.Visibility.Visible;
                }
                isShowError = false;
            }
            else
            {
                errorTip1.Visibility = System.Windows.Visibility.Hidden;
                errorTip2.Visibility = System.Windows.Visibility.Hidden;
                isShowError = true;
            }
        }

        private void LoginWindow_Closing(object sender, CancelEventArgs e)
        {
            if (this.DialogResult != true)
            {
                App.Current.Shutdown();
            }
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new MyDbEntities2())
            {
                var q = from t in context.Ticket
                        where t.YongHuMing == textBoxUserName.Text
                        select t;
                if (q.Count() == 0)
                {
                    MessageBox.Show("该用户没有注册！");
                    errorTip1.Visibility = System.Windows.Visibility.Visible;
                    errorTip2.Visibility = System.Windows.Visibility.Visible;
                    return;
                }
                
                foreach (var v in q)
                {
                    if (!v.Password.Equals(password.Password))
                    {
                        MessageBox.Show("密码错误，请重新输入！");
                        errorTip1.Visibility = System.Windows.Visibility.Hidden;
                        errorTip2.Visibility = System.Windows.Visibility.Visible;
                        break;
                    }

                    //MessageBox.Show(this.issingle+"  "+this.start+ "  " + this.issingle+ "  " + this.start+ "  " + this.end+ "  " + this.price+ "  " + this.num+ "  " + password.Password);
                    DataUpClass da = new DataUpClass(v, textBoxUserName.Text,this.issingle,this.start,this.end,this.price,this.num,password.Password);
                    
                    //MessageBox.Show(v.YongHuMing+" "+v.PassWord);
                    if (v.YongHuMing.ToString().Equals(textBoxUserName.Text) && v.Password.ToString().Equals(password.Password))
                    {
                        MessageWindow w = new MessageWindow(textBoxUserName.Text);
                        w.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;
                        //w.Owner = this;
                        this.Close();
                        w.Show();
                        
                    }
                    break;
                }
                var q1 = from t1 in context.Client
                         where t1.YongHuMing == textBoxUserName.Text
                         select t1;
                foreach (var v in q1)
                {

                    if (v.YuE < this.allprice)
                    {
                        MessageBox.Show("账户余额不足！购票失败！");
                        return;
                    }
                    v.YuE -= this.allprice;
                    v.Date = DateTime.Now;
                    break;
                }

                var q2 = from t2 in context.Company
                         where t2.ZhanghuId == "0001"
                         select t2;
                Company cp = new Company();
                cp.ZhanghuId = "0001";
                cp.YuE += this.price;
                cp.Addordec = "打入";
                cp.Value = this.price;
                cp.Laiziyu = textBoxUserName.Text;
                cp.Modifydate = DateTime.Now;
                 
                context.SaveChanges();
            } 
            if (isUserNameError == true || isPasswordError == true) //登录失败
            {
                timer.Start();
                tryCount--;
                if (tryCount == 0)
                {
                    App.Current.Shutdown();
                }
                textBlockErrorInfo.Text = "登录失败（还有" + tryCount + "次机会）";
            }
            else                                                       //成功
            {
                timer.Close();
                tryCount = 3;
                textBlockErrorInfo.Text = "";
            }
            //ShowTable st = new ShowTable();
            //st.Show();
        }
        private void btnOK_Register(object sender, RoutedEventArgs e)
        {
            UserRegister ur = new UserRegister();
            ur.Show();
        }

        private void btnCancel_Click_1(object sender, RoutedEventArgs e)
        {
            CustomerWindow cu = new CustomerWindow();
            this.Close();
            cu.ShowDialog();
        }
    }
}
