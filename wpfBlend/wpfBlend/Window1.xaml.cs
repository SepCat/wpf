using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace wpfBlend
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>

    public partial class Window1 : System.Windows.Window
    {

        public Window1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender,RoutedEventArgs e) 
        {
            // 使用一个IntPtr类型值来存储加密字符串的起始点  
            IntPtr p = System.Runtime.InteropServices.Marshal.SecureStringToBSTR(this.password.SecurePassword);

            // 使用.NET内部算法把IntPtr指向处的字符集合转换成字符串  
            string password = System.Runtime.InteropServices.Marshal.PtrToStringBSTR(p);
            MessageBox.Show(password);
        }

    }
}