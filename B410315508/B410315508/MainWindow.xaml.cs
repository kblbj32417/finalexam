using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace B410315508
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            menuwin.mydraw = this.ink1;
            menuwin.Show();
        }
        Window1 menuwin = new Window1();
    
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            DirectoryInfo dirinfo = new DirectoryInfo(@"C:\Users\Public\Pictures\Sample Pictures ");
            FileInfo[] files = dirinfo.GetFiles();
            foreach (FileInfo fi in files)
            {
                if (fi.FullName.EndsWith(".jpg"))
                {
                    Image img = new Image();
                    BitmapSource src = new BitmapImage(new Uri(fi.FullName));
                    img.Source = src;
                    img.Width = 80;
                    img.Margin = new Thickness(10);
                    this.wrapPanel1.Children.Add(img);
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}