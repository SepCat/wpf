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
            this.password.Visibility = Visibility.Collapsed;
            this.usrName.Visibility = Visibility.Collapsed;
            this.label1.Visibility = Visibility.Collapsed;
            this.label2.Visibility = Visibility.Collapsed;

            // ʹ��һ��IntPtr����ֵ���洢�����ַ�������ʼ��  
            IntPtr p = System.Runtime.InteropServices.Marshal.SecureStringToBSTR(this.password.SecurePassword);

            // ʹ��.NET�ڲ��㷨��IntPtrָ�򴦵��ַ�����ת�����ַ���  
            string password = System.Runtime.InteropServices.Marshal.PtrToStringBSTR(p);
            MessageBox.Show(password);
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) 
        { 
            this.DragMove(); 
        }

    }
}