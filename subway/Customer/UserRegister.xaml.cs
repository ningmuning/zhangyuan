﻿using System;
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
    /// UserRegister.xaml 的交互逻辑
    /// </summary>
    public partial class UserRegister : Window
    {
        public UserRegister()
        {
            InitializeComponent();
            Uri uri = new Uri("/MyWindows/Establish.xaml", UriKind.Relative);
            frame.Source = uri;
        }
    }
}
