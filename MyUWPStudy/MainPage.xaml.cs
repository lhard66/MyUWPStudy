using MyUWPStudy.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace MyUWPStudy
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Student stu;
        private ObservableCollection<Product> products = new ObservableCollection<Product>();
        public MainPage()
        {
            this.InitializeComponent();

            stu = new Student() { Name = "lucy", Age = 18 };
            stu.BelongClass = new StuClass() { ClassAge = 2, ClassName = "二级神龙班", ClassNum = 888 };
            this.DataContext = stu;

            //---------------------演示使用集合绑定listview-----------------------------//            
            for (int i = 0; i < 8; i++)
            {
                products.Add(new Product() { ID = i + 1, Name = "pro" + i });
            }
            lvStu.DataContext = products;

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            stu.BelongClass.ClassAge++;
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            txtNum.Text = stu.BelongClass.ClassAge.ToString();
        }

        private void RemoveStu_Click(object sender, RoutedEventArgs e)
        {
            if (lvStu.SelectedItem != null)
            {
                products.Remove((Product)lvStu.SelectedItem);
            }
        }
    }
}
